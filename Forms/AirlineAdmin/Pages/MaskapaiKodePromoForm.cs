using BromoAirlines.Models;
using BromoAirlines.Services;
using System.Globalization;

namespace BromoAirlines.Forms.AirlineAdmin.Pages;

public partial class MaskapaiKodePromoForm : Form
{
    private static readonly CultureInfo RupiahCulture = new("id-ID");
    private readonly MaskapaiKodePromoService _kodePromoService;
    private int _selectedPromoId;

    public MaskapaiKodePromoForm(MaskapaiKodePromoService kodePromoService)
    {
        _kodePromoService = kodePromoService;
        InitializeComponent();
        RegisterEvents();
    }

    private async void MaskapaiKodePromoFormLoad(object? sender, EventArgs e)
    {
        await LoadPromoAsync();
        ResetForm();
    }

    private async void BtnTambahClick(object? sender, EventArgs e)
    {
        await SaveAsync(() => _kodePromoService.AddAsync(CreatePromoFromInput()));
    }

    private async void BtnEditClick(object? sender, EventArgs e)
    {
        var promo = CreatePromoFromInput();
        promo.ID = _selectedPromoId;
        await SaveAsync(() => _kodePromoService.UpdateAsync(promo));
    }

    private async void BtnHapusClick(object? sender, EventArgs e)
    {
        if (_selectedPromoId <= 0)
        {
            ShowMessage("Pilih kode promo yang akan dihapus.", MessageBoxIcon.Warning);
            return;
        }

        if (ConfirmDelete())
        {
            await SaveAsync(() => _kodePromoService.DeleteAsync(_selectedPromoId));
        }
    }

    private void BtnResetClick(object? sender, EventArgs e)
    {
        ResetForm();
    }

    private async void TxtCariPromoTextChanged(object? sender, EventArgs e)
    {
        await LoadPromoAsync();
    }

    private void DgvPromoCellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            FillInputFromRow(dgvPromo.Rows[e.RowIndex]);
        }
    }

    private void DgvPromoCellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.Value is null)
        {
            return;
        }

        if (dgvPromo.Columns[e.ColumnIndex].Name == "MaksimumDiskon")
        {
            e.Value = string.Format(RupiahCulture, "Rp {0:N0}", Convert.ToDouble(e.Value));
            e.FormattingApplied = true;
        }
    }

    private void RegisterEvents()
    {
        Load += MaskapaiKodePromoFormLoad;
        btnTambah.Click += BtnTambahClick;
        btnEdit.Click += BtnEditClick;
        btnHapus.Click += BtnHapusClick;
        btnReset.Click += BtnResetClick;
        txtCariPromo.TextChanged += TxtCariPromoTextChanged;
        dgvPromo.CellClick += DgvPromoCellClick;
        dgvPromo.CellFormatting += DgvPromoCellFormatting;
    }

    private async Task LoadPromoAsync()
    {
        try
        {
            FillGrid(await _kodePromoService.SearchAsync(txtCariPromo.Text));
        }
        catch
        {
            ShowMessage("Data kode promo belum dapat dimuat. Pastikan session maskapai valid.", MessageBoxIcon.Error);
        }
    }

    private async Task SaveAsync(Func<Task<KodePromoServiceResult>> action)
    {
        try
        {
            var result = await action();
            ShowMessage(result.Message, result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (result.IsSuccess)
            {
                await LoadPromoAsync();
                ResetForm();
            }
        }
        catch
        {
            ShowMessage("Proses kode promo belum berhasil.", MessageBoxIcon.Error);
        }
    }

    private void FillGrid(IEnumerable<KodePromo> promos)
    {
        dgvPromo.Rows.Clear();
        foreach (var item in promos)
        {
            dgvPromo.Rows.Add(
                item.ID,
                item.Kode,
                item.PersentaseDiskon,
                item.MaksimumDiskon,
                item.BerlakuSampai,
                GetStatus(item.BerlakuSampai),
                item.Deskripsi);
        }
    }

    private void FillInputFromRow(DataGridViewRow row)
    {
        _selectedPromoId = Convert.ToInt32(row.Cells["ID"].Value);
        txtKode.Text = Convert.ToString(row.Cells["Kode"].Value);
        numPersentaseDiskon.Value = Convert.ToDecimal(row.Cells["PersentaseDiskon"].Value);
        numMaksimumDiskon.Value = Convert.ToDecimal(row.Cells["MaksimumDiskon"].Value);
        dtpBerlakuSampai.Value = Convert.ToDateTime(row.Cells["BerlakuSampai"].Value);
        txtDeskripsi.Text = Convert.ToString(row.Cells["Deskripsi"].Value);
        btnTambah.Enabled = false;
        btnEdit.Enabled = true;
        btnHapus.Enabled = true;
    }

    private KodePromo CreatePromoFromInput()
    {
        return new KodePromo
        {
            Kode = txtKode.Text,
            PersentaseDiskon = Convert.ToDouble(numPersentaseDiskon.Value),
            MaksimumDiskon = Convert.ToDouble(numMaksimumDiskon.Value),
            BerlakuSampai = dtpBerlakuSampai.Value,
            Deskripsi = txtDeskripsi.Text
        };
    }

    private void ResetForm()
    {
        _selectedPromoId = 0;
        txtKode.Clear();
        numPersentaseDiskon.Value = 1;
        numMaksimumDiskon.Value = 1;
        dtpBerlakuSampai.Value = DateTime.Today.AddDays(7);
        txtDeskripsi.Clear();
        btnTambah.Enabled = true;
        btnEdit.Enabled = false;
        btnHapus.Enabled = false;
        dgvPromo.ClearSelection();
    }

    private static string GetStatus(DateTime berlakuSampai)
    {
        return berlakuSampai.Date >= DateTime.Today ? "Aktif" : "Kadaluarsa";
    }

    private static bool ConfirmDelete()
    {
        return MessageBox.Show(
            "Apakah kode promo ini akan dihapus?",
            "Konfirmasi Hapus",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes;
    }

    private static void ShowMessage(string message, MessageBoxIcon icon)
    {
        MessageBox.Show(message, "Kode Promo Maskapai", MessageBoxButtons.OK, icon);
    }
}
