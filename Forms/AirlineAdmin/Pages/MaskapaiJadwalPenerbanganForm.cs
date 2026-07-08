using BromoAirlines.Models;
using BromoAirlines.Services;
using System.Globalization;

namespace BromoAirlines.Forms.AirlineAdmin.Pages;

public partial class MaskapaiJadwalPenerbanganForm : Form
{
    private static readonly CultureInfo RupiahCulture = new("id-ID");
    private readonly MaskapaiJadwalPenerbanganService _jadwalService;
    private int _selectedJadwalId;

    public MaskapaiJadwalPenerbanganForm(MaskapaiJadwalPenerbanganService jadwalService)
    {
        _jadwalService = jadwalService;
        InitializeComponent();
        RegisterEvents();
    }

    private async void MaskapaiJadwalPenerbanganFormLoad(object? sender, EventArgs e)
    {
        await LoadComboDataAsync();
        await LoadJadwalAsync();
        ResetForm();
    }

    private async void BtnTambahClick(object? sender, EventArgs e)
    {
        await SaveAsync(() => _jadwalService.AddAsync(CreateJadwalFromInput()));
    }

    private async void BtnEditClick(object? sender, EventArgs e)
    {
        var jadwal = CreateJadwalFromInput();
        jadwal.ID = _selectedJadwalId;
        await SaveAsync(() => _jadwalService.UpdateAsync(jadwal));
    }

    private async void BtnHapusClick(object? sender, EventArgs e)
    {
        if (_selectedJadwalId <= 0)
        {
            ShowMessage("Pilih jadwal penerbangan yang akan dihapus.", MessageBoxIcon.Warning);
            return;
        }

        if (ConfirmDelete())
        {
            await SaveAsync(() => _jadwalService.DeleteAsync(_selectedJadwalId));
        }
    }

    private void BtnResetClick(object? sender, EventArgs e)
    {
        ResetForm();
    }

    private async void TxtCariJadwalTextChanged(object? sender, EventArgs e)
    {
        await LoadJadwalAsync();
    }

    private void DgvJadwalCellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            FillInputFromRow(dgvJadwal.Rows[e.RowIndex]);
        }
    }

    private void DgvJadwalCellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (dgvJadwal.Columns[e.ColumnIndex].Name != "HargaPerTiket" || e.Value is null)
        {
            return;
        }

        e.Value = string.Format(RupiahCulture, "Rp {0:N0}", Convert.ToDouble(e.Value));
        e.FormattingApplied = true;
    }

    private void RegisterEvents()
    {
        Load += MaskapaiJadwalPenerbanganFormLoad;
        btnTambah.Click += BtnTambahClick;
        btnEdit.Click += BtnEditClick;
        btnHapus.Click += BtnHapusClick;
        btnReset.Click += BtnResetClick;
        txtCariJadwal.TextChanged += TxtCariJadwalTextChanged;
        dgvJadwal.CellClick += DgvJadwalCellClick;
        dgvJadwal.CellFormatting += DgvJadwalCellFormatting;
    }

    private async Task LoadComboDataAsync()
    {
        try
        {
            var bandara = await _jadwalService.GetBandaraAsync();
            BindBandaraCombo(cmbBandaraKeberangkatan, bandara);
            BindBandaraCombo(cmbBandaraTujuan, bandara.ToList());
        }
        catch
        {
            ShowMessage("Data bandara belum dapat dimuat.", MessageBoxIcon.Error);
        }
    }

    private async Task LoadJadwalAsync()
    {
        try
        {
            FillGrid(await _jadwalService.SearchAsync(txtCariJadwal.Text));
        }
        catch
        {
            ShowMessage("Data jadwal belum dapat dimuat. Pastikan session maskapai valid.", MessageBoxIcon.Error);
        }
    }

    private async Task SaveAsync(Func<Task<JadwalPenerbanganServiceResult>> action)
    {
        try
        {
            var result = await action();
            ShowMessage(result.Message, result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (result.IsSuccess)
            {
                await LoadJadwalAsync();
                ResetForm();
            }
        }
        catch
        {
            ShowMessage("Proses jadwal belum berhasil.", MessageBoxIcon.Error);
        }
    }

    private void FillGrid(IEnumerable<JadwalPenerbanganView> jadwal)
    {
        dgvJadwal.Rows.Clear();
        foreach (var item in jadwal)
        {
            dgvJadwal.Rows.Add(
                item.ID,
                item.KodePenerbangan,
                item.BandaraKeberangkatanID,
                item.BandaraKeberangkatan,
                item.BandaraTujuanID,
                item.BandaraTujuan,
                item.TanggalWaktuKeberangkatan,
                item.DurasiPenerbangan,
                item.HargaPerTiket);
        }
    }

    private void FillInputFromRow(DataGridViewRow row)
    {
        _selectedJadwalId = Convert.ToInt32(row.Cells["ID"].Value);
        txtKodePenerbangan.Text = Convert.ToString(row.Cells["KodePenerbangan"].Value);
        cmbBandaraKeberangkatan.SelectedValue = Convert.ToInt32(row.Cells["BandaraKeberangkatanID"].Value);
        cmbBandaraTujuan.SelectedValue = Convert.ToInt32(row.Cells["BandaraTujuanID"].Value);
        dtpKeberangkatan.Value = Convert.ToDateTime(row.Cells["TanggalWaktuKeberangkatan"].Value);
        numDurasi.Value = Convert.ToDecimal(row.Cells["DurasiPenerbangan"].Value);
        numHarga.Value = Convert.ToDecimal(row.Cells["HargaPerTiket"].Value);
        btnTambah.Enabled = false;
        btnEdit.Enabled = true;
        btnHapus.Enabled = true;
    }

    private JadwalPenerbangan CreateJadwalFromInput()
    {
        return new JadwalPenerbangan
        {
            KodePenerbangan = txtKodePenerbangan.Text,
            BandaraKeberangkatanID = GetSelectedId(cmbBandaraKeberangkatan),
            BandaraTujuanID = GetSelectedId(cmbBandaraTujuan),
            TanggalWaktuKeberangkatan = dtpKeberangkatan.Value,
            DurasiPenerbangan = Convert.ToInt32(numDurasi.Value),
            HargaPerTiket = Convert.ToDouble(numHarga.Value)
        };
    }

    private void ResetForm()
    {
        _selectedJadwalId = 0;
        txtKodePenerbangan.Clear();
        cmbBandaraKeberangkatan.SelectedIndex = -1;
        cmbBandaraTujuan.SelectedIndex = -1;
        dtpKeberangkatan.Value = DateTime.Now.AddDays(1);
        numDurasi.Value = 1;
        numHarga.Value = 1;
        btnTambah.Enabled = true;
        btnEdit.Enabled = false;
        btnHapus.Enabled = false;
        dgvJadwal.ClearSelection();
    }

    private static void BindBandaraCombo(ComboBox comboBox, List<BandaraView> bandara)
    {
        comboBox.DataSource = bandara;
        comboBox.DisplayMember = nameof(BandaraView.Nama);
        comboBox.ValueMember = nameof(BandaraView.ID);
        comboBox.SelectedIndex = -1;
    }

    private static int GetSelectedId(ComboBox comboBox)
    {
        return comboBox.SelectedValue is int id ? id : 0;
    }

    private static bool ConfirmDelete()
    {
        return MessageBox.Show(
            "Apakah jadwal penerbangan ini akan dihapus?",
            "Konfirmasi Hapus",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes;
    }

    private static void ShowMessage(string message, MessageBoxIcon icon)
    {
        MessageBox.Show(message, "Jadwal Penerbangan Maskapai", MessageBoxButtons.OK, icon);
    }
}
