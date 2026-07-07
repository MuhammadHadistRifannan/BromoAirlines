using BromoAirlines.Models;
using BromoAirlines.Services;

namespace BromoAirlines.Forms
{
    public partial class StatusPenerbanganForm : Form
    {
        private readonly StatusPenerbanganService _statusPenerbanganService;
        private int _selectedJadwalId;

        public StatusPenerbanganForm(StatusPenerbanganService statusPenerbanganService)
        {
            _statusPenerbanganService = statusPenerbanganService;
            InitializeComponent();
            RegisterEvents();
        }

        private async void StatusPenerbanganForm_Load(object? sender, EventArgs e)
        {
            await LoadStatusAsync();
            await LoadJadwalStatusAsync();
            ResetForm();
        }

        private async void BtnSimpan_Click(object? sender, EventArgs e)
        {
            await SaveAsync();
        }

        private void BtnReset_Click(object? sender, EventArgs e)
        {
            ResetForm();
        }

        private async void TxtCariJadwal_TextChanged(object? sender, EventArgs e)
        {
            await LoadJadwalStatusAsync();
        }

        private void DgvJadwalStatus_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            FillInputFromRow(dgvJadwalStatus.Rows[e.RowIndex]);
        }

        private void DgvJadwalStatus_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is null || e.Value == DBNull.Value)
            {
                e.Value = "-";
                e.FormattingApplied = true;
                return;
            }

            ApplyGridFormat(e, dgvJadwalStatus.Columns[e.ColumnIndex].Name);
        }

        private void CmbStatus_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateDelayControlState();
        }

        private void RegisterEvents()
        {
            Load += StatusPenerbanganForm_Load;
            btnSimpan.Click += BtnSimpan_Click;
            btnReset.Click += BtnReset_Click;
            txtCariJadwal.TextChanged += TxtCariJadwal_TextChanged;
            dgvJadwalStatus.CellClick += DgvJadwalStatus_CellClick;
            dgvJadwalStatus.CellFormatting += DgvJadwalStatus_CellFormatting;
            cmbStatus.SelectedIndexChanged += CmbStatus_SelectedIndexChanged;
        }

        private async Task LoadStatusAsync()
        {
            try
            {
                var status = await _statusPenerbanganService.GetStatusPenerbanganAsync();
                cmbStatus.DataSource = status;
                cmbStatus.DisplayMember = nameof(BromoAirlines.Models.StatusPenerbangan.Nama);
                cmbStatus.ValueMember = nameof(BromoAirlines.Models.StatusPenerbangan.ID);
                cmbStatus.SelectedIndex = -1;
            }
            catch
            {
                ShowMessage("Data status penerbangan belum dapat dimuat.", MessageBoxIcon.Error);
            }
        }

        private async Task LoadJadwalStatusAsync()
        {
            try
            {
                var jadwalStatus = await _statusPenerbanganService.SearchJadwalStatusAsync(txtCariJadwal.Text);
                FillGrid(jadwalStatus);
            }
            catch
            {
                ShowMessage("Data jadwal penerbangan belum dapat dimuat.", MessageBoxIcon.Error);
            }
        }

        private async Task SaveAsync()
        {
            try
            {
                var result = await _statusPenerbanganService.ChangeStatusAsync(
                    CreatePerubahanStatusFromInput(),
                    cmbStatus.Text);

                ShowMessage(result.Message, GetMessageIcon(result));
                await RefreshAfterSaveAsync(result);
            }
            catch
            {
                ShowMessage("Proses ubah status penerbangan belum berhasil.", MessageBoxIcon.Error);
            }
        }

        private async Task RefreshAfterSaveAsync(StatusPenerbanganServiceResult result)
        {
            if (!result.IsSuccess)
            {
                return;
            }

            await LoadJadwalStatusAsync();
            ResetForm();
        }

        private void FillGrid(IEnumerable<JadwalStatusView> jadwalStatus)
        {
            dgvJadwalStatus.Rows.Clear();
            foreach (var item in jadwalStatus)
            {
                dgvJadwalStatus.Rows.Add(
                    item.JadwalPenerbanganID,
                    item.KodePenerbangan,
                    item.BandaraKeberangkatan,
                    item.BandaraTujuan,
                    item.Maskapai,
                    item.TanggalWaktuKeberangkatan,
                    item.StatusPenerbanganID,
                    item.StatusPenerbangan,
                    item.WaktuPerubahanTerjadi ?? (object)DBNull.Value,
                    item.PerkiraanDurasiDelay ?? (object)DBNull.Value);
            }
        }

        private void FillInputFromRow(DataGridViewRow row)
        {
            _selectedJadwalId = Convert.ToInt32(row.Cells["JadwalPenerbanganID"].Value);
            lblSelectedJadwal.Text = Convert.ToString(row.Cells["KodePenerbangan"].Value);
            cmbStatus.SelectedValue = Convert.ToInt32(row.Cells["StatusPenerbanganID"].Value);
            SetDelayValue(row.Cells["PerkiraanDurasiDelay"].Value);
            btnSimpan.Enabled = true;
        }

        private PerubahanStatusJadwalPenerbangan CreatePerubahanStatusFromInput()
        {
            return new PerubahanStatusJadwalPenerbangan
            {
                JadwalPenerbanganID = _selectedJadwalId,
                StatusPenerbanganID = GetSelectedStatusId(),
                PerkiraanDurasiDelay = IsDelaySelected() ? Convert.ToInt32(numDurasiDelay.Value) : null
            };
        }

        private void ResetForm()
        {
            _selectedJadwalId = 0;
            lblSelectedJadwal.Text = "-";
            cmbStatus.SelectedIndex = -1;
            numDurasiDelay.Value = 1;
            btnSimpan.Enabled = false;
            dgvJadwalStatus.ClearSelection();
            UpdateDelayControlState();
        }

        private void SetDelayValue(object? value)
        {
            if (value is null || value == DBNull.Value)
            {
                numDurasiDelay.Value = 1;
                return;
            }

            numDurasiDelay.Value = Convert.ToDecimal(value);
        }

        private void UpdateDelayControlState()
        {
            var isDelay = IsDelaySelected();
            lblDurasiDelay.Enabled = isDelay;
            numDurasiDelay.Enabled = isDelay;
        }

        private int GetSelectedStatusId()
        {
            return cmbStatus.SelectedValue is int id ? id : 0;
        }

        private bool IsDelaySelected()
        {
            return cmbStatus.Text.Equals("Delay", StringComparison.OrdinalIgnoreCase);
        }

        private static void ApplyGridFormat(DataGridViewCellFormattingEventArgs e, string columnName)
        {
            if (columnName == "TanggalWaktuKeberangkatan" || columnName == "WaktuPerubahanTerjadi")
            {
                e.Value = Convert.ToDateTime(e.Value).ToString("dd/MM/yyyy HH:mm");
                e.FormattingApplied = true;
                return;
            }

            if (columnName == "PerkiraanDurasiDelay")
            {
                e.Value = $"{e.Value} menit";
                e.FormattingApplied = true;
            }
        }

        private static MessageBoxIcon GetMessageIcon(StatusPenerbanganServiceResult result)
        {
            return result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
        }

        private static void ShowMessage(string message, MessageBoxIcon icon)
        {
            MessageBox.Show(message, "Status Penerbangan", MessageBoxButtons.OK, icon);
        }
    }
}
