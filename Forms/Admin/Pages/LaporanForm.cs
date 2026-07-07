using BromoAirlines.Models;
using BromoAirlines.Services;
using System.Globalization;

namespace BromoAirlines.Forms
{
    public partial class LaporanForm : Form
    {
        private static readonly CultureInfo RupiahCulture = new("id-ID");
        private readonly LaporanService _laporanService;

        public LaporanForm(LaporanService laporanService)
        {
            _laporanService = laporanService;
            InitializeComponent();
            RegisterEvents();
        }

        private async void LaporanForm_Load(object? sender, EventArgs e)
        {
            dtpMulai.Value = DateTime.Today.AddMonths(-1);
            dtpSampai.Value = DateTime.Today;
            await LoadLaporanAsync();
        }

        private async void BtnTampilkan_Click(object? sender, EventArgs e)
        {
            await LoadLaporanAsync();
        }

        private void Grid_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = sender as DataGridView;
            if (grid is null || e.Value is null || e.Value == DBNull.Value)
            {
                return;
            }

            var columnName = grid.Columns[e.ColumnIndex].Name;
            if (columnName is "TotalHarga" or "TotalPendapatan")
            {
                e.Value = FormatRupiah(Convert.ToDouble(e.Value));
                e.FormattingApplied = true;
                return;
            }

            if (columnName == "TanggalTransaksi")
            {
                e.Value = Convert.ToDateTime(e.Value).ToString("dd/MM/yyyy HH:mm");
                e.FormattingApplied = true;
            }
        }

        private void RegisterEvents()
        {
            Load += LaporanForm_Load;
            btnTampilkan.Click += BtnTampilkan_Click;
            dgvTransaksi.CellFormatting += Grid_CellFormatting;
            dgvMaskapai.CellFormatting += Grid_CellFormatting;
        }

        private async Task LoadLaporanAsync()
        {
            try
            {
                var mulai = dtpMulai.Value.Date;
                var sampai = dtpSampai.Value.Date;
                var ringkasan = await _laporanService.GetRingkasanAsync(mulai, sampai);
                var transaksi = await _laporanService.GetTransaksiAsync(mulai, sampai);
                var maskapai = await _laporanService.GetMaskapaiAsync(mulai, sampai);

                FillRingkasan(ringkasan);
                FillTransaksiGrid(transaksi);
                FillMaskapaiGrid(maskapai);
            }
            catch (InvalidOperationException ex)
            {
                ShowMessage(ex.Message, MessageBoxIcon.Warning);
            }
            catch
            {
                ShowMessage("Data laporan belum dapat dimuat.", MessageBoxIcon.Error);
            }
        }

        private void FillRingkasan(LaporanRingkasan ringkasan)
        {
            lblTotalTransaksi.Text = ringkasan.TotalTransaksi.ToString();
            lblTotalPenumpang.Text = ringkasan.TotalPenumpang.ToString();
            lblTotalPendapatan.Text = FormatRupiah(ringkasan.TotalPendapatan);
        }

        private void FillTransaksiGrid(IEnumerable<LaporanTransaksiView> transaksi)
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
                    item.Maskapai,
                    item.JumlahPenumpang,
                    item.TotalHarga,
                    item.KodePromo);
            }
        }

        private void FillMaskapaiGrid(IEnumerable<LaporanMaskapaiView> maskapai)
        {
            dgvMaskapai.Rows.Clear();
            foreach (var item in maskapai)
            {
                dgvMaskapai.Rows.Add(
                    item.Maskapai,
                    item.TotalTransaksi,
                    item.TotalPenumpang,
                    item.TotalPendapatan);
            }
        }

        private static void ShowMessage(string message, MessageBoxIcon icon)
        {
            MessageBox.Show(message, "Laporan", MessageBoxButtons.OK, icon);
        }

        private static string FormatRupiah(double value)
        {
            return string.Format(RupiahCulture, "Rp {0:N0}", value);
        }
    }
}
