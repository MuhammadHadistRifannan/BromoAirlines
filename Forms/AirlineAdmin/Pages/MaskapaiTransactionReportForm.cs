using BromoAirlines.Models;
using BromoAirlines.Services;
using System.Globalization;

namespace BromoAirlines.Forms.AirlineAdmin.Pages;

public partial class MaskapaiTransactionReportForm : Form
{
    private static readonly CultureInfo RupiahCulture = new("id-ID");
    private readonly MaskapaiReportService _reportService;

    public MaskapaiTransactionReportForm(MaskapaiReportService reportService)
    {
        _reportService = reportService;
        InitializeComponent();
        RegisterEvents();
    }

    private async void MaskapaiTransactionReportFormLoad(object? sender, EventArgs e)
    {
        SetupDefaultFilter();
        await LoadJadwalAsync();
        await LoadReportAsync();
    }

    private async void BtnTampilkanClick(object? sender, EventArgs e)
    {
        await LoadReportAsync();
    }

    private void GridCellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (sender is not DataGridView grid || e.Value is null)
        {
            return;
        }

        var columnName = grid.Columns[e.ColumnIndex].Name;
        if (columnName is "TotalHarga" or "TotalPendapatan")
        {
            e.Value = string.Format(RupiahCulture, "Rp {0:N0}", Convert.ToDouble(e.Value));
            e.FormattingApplied = true;
        }
    }

    private void RegisterEvents()
    {
        Load += MaskapaiTransactionReportFormLoad;
        btnTampilkan.Click += BtnTampilkanClick;
        dgvTransaksi.CellFormatting += GridCellFormatting;
        dgvRutePopuler.CellFormatting += GridCellFormatting;
    }

    private void SetupDefaultFilter()
    {
        dtpMulai.Value = DateTime.Today.AddMonths(-1);
        dtpSampai.Value = DateTime.Today;
        cmbStatus.Items.Clear();
        cmbStatus.Items.Add("Semua");
        cmbStatus.Items.Add("Paid");
        cmbStatus.SelectedIndex = 0;
    }

    private async Task LoadJadwalAsync()
    {
        try
        {
            var jadwal = await _reportService.GetJadwalAsync();
            jadwal.Insert(0, new JadwalPenerbanganView
            {
                ID = 0,
                KodePenerbangan = "Semua Jadwal"
            });

            cmbJadwal.DataSource = jadwal;
            cmbJadwal.DisplayMember = nameof(JadwalPenerbanganView.KodePenerbangan);
            cmbJadwal.ValueMember = nameof(JadwalPenerbanganView.ID);
        }
        catch
        {
            ShowMessage("Data jadwal belum dapat dimuat.", MessageBoxIcon.Error);
        }
    }

    private async Task LoadReportAsync()
    {
        try
        {
            var report = await _reportService.GetReportAsync(
                dtpMulai.Value,
                dtpSampai.Value,
                GetSelectedJadwalId(),
                Convert.ToString(cmbStatus.SelectedItem) ?? "Semua");

            FillSummary(report.Ringkasan);
            FillTransactionGrid(report.Transaksi);
            FillPopularRouteGrid(report.RutePopuler);
        }
        catch (InvalidOperationException ex)
        {
            ShowMessage(ex.Message, MessageBoxIcon.Warning);
        }
        catch
        {
            ShowMessage("Laporan transaksi belum dapat dimuat.", MessageBoxIcon.Error);
        }
    }

    private void FillSummary(LaporanRingkasan ringkasan)
    {
        lblTotalTransaksiValue.Text = ringkasan.TotalTransaksi.ToString("N0", RupiahCulture);
        lblTotalPenumpangValue.Text = ringkasan.TotalPenumpang.ToString("N0", RupiahCulture);
        lblTotalPendapatanValue.Text = string.Format(RupiahCulture, "Rp {0:N0}", ringkasan.TotalPendapatan);
    }

    private void FillTransactionGrid(IEnumerable<LaporanTransaksiView> transaksi)
    {
        dgvTransaksi.Rows.Clear();
        foreach (var item in transaksi)
        {
            dgvTransaksi.Rows.Add(
                item.ID,
                item.TanggalTransaksi,
                item.NamaAkun,
                item.KodePenerbangan,
                item.Rute,
                item.JumlahPenumpang,
                item.TotalHarga,
                item.KodePromo);
        }
    }

    private void FillPopularRouteGrid(IEnumerable<MaskapaiPopularRouteView> routes)
    {
        dgvRutePopuler.Rows.Clear();
        foreach (var item in routes)
        {
            dgvRutePopuler.Rows.Add(
                item.Rute,
                item.TotalTransaksi,
                item.TotalPenumpang,
                item.TotalPendapatan);
        }
    }

    private int GetSelectedJadwalId()
    {
        return cmbJadwal.SelectedValue is int id ? id : 0;
    }

    private static void ShowMessage(string message, MessageBoxIcon icon)
    {
        MessageBox.Show(message, "Laporan Transaksi Maskapai", MessageBoxButtons.OK, icon);
    }
}
