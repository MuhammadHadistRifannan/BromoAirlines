using BromoAirlines.Models;
using BromoAirlines.Services;

namespace BromoAirlines.Forms;

public partial class MasterBandaraForm : Form
{
    private readonly MasterBandaraService _bandaraService;
    private List<Negara> _negara = [];
    private int _selectedBandaraId;

    public MasterBandaraForm(MasterBandaraService bandaraService)
    {
        _bandaraService = bandaraService;
        InitializeComponent();
        RegisterEvents();
    }

    private async void MasterBandaraForm_Load(object? sender, EventArgs e)
    {
        await LoadNegaraAsync();
        await LoadBandaraAsync();
        ResetForm();
    }

    private async void BtnTambah_Click(object? sender, EventArgs e)
    {
        await SaveAsync(() => _bandaraService.AddAsync(CreateBandaraFromInput()));
    }

    private async void BtnEdit_Click(object? sender, EventArgs e)
    {
        var bandara = CreateBandaraFromInput();
        bandara.ID = _selectedBandaraId;
        await SaveAsync(() => _bandaraService.UpdateAsync(bandara));
    }

    private async void BtnHapus_Click(object? sender, EventArgs e)
    {
        if (_selectedBandaraId <= 0)
        {
            ShowMessage("Pilih data bandara yang akan dihapus.", MessageBoxIcon.Warning);
            return;
        }

        var confirm = MessageBox.Show(
            "Apakah data bandara ini akan dihapus?",
            "Konfirmasi Hapus",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirm != DialogResult.Yes)
        {
            return;
        }

        await SaveAsync(() => _bandaraService.DeleteAsync(_selectedBandaraId));
    }

    private void BtnReset_Click(object? sender, EventArgs e)
    {
        ResetForm();
    }

    private async void TxtCariBandara_TextChanged(object? sender, EventArgs e)
    {
        await LoadBandaraAsync();
    }

    private void DgvBandara_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        FillInputFromRow(dgvBandara.Rows[e.RowIndex]);
    }

    private void RegisterEvents()
    {
        Load += MasterBandaraForm_Load;
        btnTambah.Click += BtnTambah_Click;
        btnEdit.Click += BtnEdit_Click;
        btnHapus.Click += BtnHapus_Click;
        btnReset.Click += BtnReset_Click;
        txtCariBandara.TextChanged += TxtCariBandara_TextChanged;
        dgvBandara.CellClick += DgvBandara_CellClick;
    }

    private async Task LoadNegaraAsync()
    {
        try
        {
            _negara = await _bandaraService.GetNegaraAsync();
            cmbNegara.DataSource = _negara;
            cmbNegara.DisplayMember = nameof(BromoAirlines.Models.Negara.Nama);
            cmbNegara.ValueMember = nameof(BromoAirlines.Models.Negara.ID);
            cmbNegara.SelectedIndex = -1;
        }
        catch
        {
            ShowMessage("Data negara belum dapat dimuat.", MessageBoxIcon.Error);
        }
    }

    private async Task LoadBandaraAsync()
    {
        try
        {
            var bandara = await _bandaraService.SearchAsync(txtCariBandara.Text);
            FillGrid(bandara);
        }
        catch
        {
            ShowMessage("Data bandara belum dapat dimuat.", MessageBoxIcon.Error);
        }
    }

    private async Task SaveAsync(Func<Task<BandaraServiceResult>> action)
    {
        try
        {
            var result = await action();
            ShowMessage(result.Message, result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (result.IsSuccess)
            {
                await LoadBandaraAsync();
                ResetForm();
            }
        }
        catch
        {
            ShowMessage("Proses data bandara belum berhasil.", MessageBoxIcon.Error);
        }
    }

    private void FillGrid(IEnumerable<BandaraView> bandara)
    {
        dgvBandara.Rows.Clear();
        foreach (var item in bandara)
        {
            dgvBandara.Rows.Add(
                item.ID,
                item.Nama,
                item.KodeIATA,
                item.Kota,
                item.NegaraNama,
                item.JumlahTerminal,
                item.Alamat);
        }
    }

    private void FillInputFromRow(DataGridViewRow row)
    {
        _selectedBandaraId = Convert.ToInt32(row.Cells["ID"].Value);
        txtNamaBandara.Text = Convert.ToString(row.Cells["NamaBandara"].Value);
        txtKodeIATA.Text = Convert.ToString(row.Cells["KodeIATA"].Value);
        txtKota.Text = Convert.ToString(row.Cells["kota"].Value);
        SelectNegara(Convert.ToString(row.Cells["Negara"].Value));
        numTerminal.Value = Convert.ToDecimal(row.Cells["JumlahTerminal"].Value);
        txtAlamat.Text = Convert.ToString(row.Cells["Alamat"].Value);
        btnTambah.Enabled = false;
        btnEdit.Enabled = true;
        btnHapus.Enabled = true;
    }

    private Bandara CreateBandaraFromInput()
    {
        return new Bandara
        {
            Nama = txtNamaBandara.Text,
            KodeIATA = txtKodeIATA.Text,
            Kota = txtKota.Text,
            NegaraID = cmbNegara.SelectedValue is int negaraId ? negaraId : 0,
            JumlahTerminal = Convert.ToInt32(numTerminal.Value),
            Alamat = txtAlamat.Text
        };
    }

    private void ResetForm()
    {
        _selectedBandaraId = 0;
        txtNamaBandara.Clear();
        txtKodeIATA.Clear();
        txtKota.Clear();
        txtAlamat.Clear();
        numTerminal.Value = 1;
        cmbNegara.SelectedIndex = -1;
        btnTambah.Enabled = true;
        btnEdit.Enabled = false;
        btnHapus.Enabled = false;
        dgvBandara.ClearSelection();
    }

    private void SelectNegara(string? namaNegara)
    {
        var negara = _negara.FirstOrDefault(item => item.Nama == namaNegara);
        cmbNegara.SelectedValue = negara?.ID ?? 0;
    }

    private static void ShowMessage(string message, MessageBoxIcon icon)
    {
        MessageBox.Show(message, "Master Bandara", MessageBoxButtons.OK, icon);
    }
}
