using BromoAirlines.Models;
using BromoAirlines.Services;

namespace BromoAirlines.Forms
{
    public partial class UserManagementForm : Form
    {
        private readonly UserManagementService _userManagementService;
        private int _selectedUserId;

        public UserManagementForm(UserManagementService userManagementService)
        {
            _userManagementService = userManagementService;
            InitializeComponent();
            RegisterEvents();
        }

        private async void UserManagementForm_Load(object? sender, EventArgs e)
        {
            await LoadUserAsync();
            ResetForm();
        }

        private async void BtnTambah_Click(object? sender, EventArgs e)
        {
            await SaveAsync(() => _userManagementService.AddAsync(CreateAkunFromInput()));
        }

        private async void BtnEdit_Click(object? sender, EventArgs e)
        {
            var akun = CreateAkunFromInput();
            akun.ID = _selectedUserId;
            await SaveAsync(() => _userManagementService.UpdateAsync(akun));
        }

        private async void BtnHapus_Click(object? sender, EventArgs e)
        {
            if (_selectedUserId <= 0)
            {
                ShowMessage("Pilih user yang akan dihapus.", MessageBoxIcon.Warning);
                return;
            }

            if (ConfirmDelete())
            {
                await SaveAsync(() => _userManagementService.DeleteAsync(_selectedUserId));
            }
        }

        private void BtnReset_Click(object? sender, EventArgs e)
        {
            ResetForm();
        }

        private async void TxtCariUser_TextChanged(object? sender, EventArgs e)
        {
            await LoadUserAsync();
        }

        private void DgvUser_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            FillInputFromRow(dgvUser.Rows[e.RowIndex]);
        }

        private void DgvUser_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUser.Columns[e.ColumnIndex].Name == "TanggalLahir" && e.Value is not null)
            {
                e.Value = Convert.ToDateTime(e.Value).ToString("dd/MM/yyyy");
                e.FormattingApplied = true;
            }
        }

        private void RegisterEvents()
        {
            Load += UserManagementForm_Load;
            btnTambah.Click += BtnTambah_Click;
            btnEdit.Click += BtnEdit_Click;
            btnHapus.Click += BtnHapus_Click;
            btnReset.Click += BtnReset_Click;
            txtCariUser.TextChanged += TxtCariUser_TextChanged;
            dgvUser.CellClick += DgvUser_CellClick;
            dgvUser.CellFormatting += DgvUser_CellFormatting;
        }

        private async Task LoadUserAsync()
        {
            try
            {
                var users = await _userManagementService.SearchAsync(txtCariUser.Text);
                FillGrid(users);
            }
            catch
            {
                ShowMessage("Data user belum dapat dimuat.", MessageBoxIcon.Error);
            }
        }

        private async Task SaveAsync(Func<Task<UserManagementServiceResult>> action)
        {
            try
            {
                var result = await action();
                ShowMessage(result.Message, GetMessageIcon(result));

                if (result.IsSuccess)
                {
                    await LoadUserAsync();
                    ResetForm();
                }
            }
            catch
            {
                ShowMessage("Proses data user belum berhasil.", MessageBoxIcon.Error);
            }
        }

        private void FillGrid(IEnumerable<Akun> users)
        {
            dgvUser.Rows.Clear();
            foreach (var item in users)
            {
                dgvUser.Rows.Add(
                    item.ID,
                    item.Username,
                    item.Password,
                    item.Nama,
                    item.TanggalLahir,
                    item.NomorTelepon,
                    item.MerupakanAdmin,
                    item.MerupakanAdmin ? "Admin" : "User");
            }
        }

        private void FillInputFromRow(DataGridViewRow row)
        {
            _selectedUserId = Convert.ToInt32(row.Cells["ID"].Value);
            txtUsername.Text = Convert.ToString(row.Cells["Username"].Value);
            txtPassword.Text = Convert.ToString(row.Cells["Password"].Value);
            txtNama.Text = Convert.ToString(row.Cells["Nama"].Value);
            dtpTanggalLahir.Value = Convert.ToDateTime(row.Cells["TanggalLahir"].Value);
            txtNomorTelepon.Text = Convert.ToString(row.Cells["NomorTelepon"].Value);
            chkMerupakanAdmin.Checked = Convert.ToBoolean(row.Cells["MerupakanAdmin"].Value);
            btnTambah.Enabled = false;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;
        }

        private Akun CreateAkunFromInput()
        {
            return new Akun
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Nama = txtNama.Text,
                TanggalLahir = dtpTanggalLahir.Value,
                NomorTelepon = txtNomorTelepon.Text,
                MerupakanAdmin = chkMerupakanAdmin.Checked
            };
        }

        private void ResetForm()
        {
            _selectedUserId = 0;
            txtUsername.Clear();
            txtPassword.Clear();
            txtNama.Clear();
            txtNomorTelepon.Clear();
            dtpTanggalLahir.Value = DateTime.Today.AddYears(-18);
            chkMerupakanAdmin.Checked = false;
            btnTambah.Enabled = true;
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
            dgvUser.ClearSelection();
        }

        private static bool ConfirmDelete()
        {
            var confirm = MessageBox.Show(
                "Apakah user ini akan dihapus?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return confirm == DialogResult.Yes;
        }

        private static MessageBoxIcon GetMessageIcon(UserManagementServiceResult result)
        {
            return result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
        }

        private static void ShowMessage(string message, MessageBoxIcon icon)
        {
            MessageBox.Show(message, "User Management", MessageBoxButtons.OK, icon);
        }
    }
}
