using BromoAirlines.Models;
using BromoAirlines.Services;

namespace BromoAirlines.Forms
{
    public partial class MasterMaskapaiForm : Form
    {
        private readonly MasterMaskapaiService _maskapaiService;
        private int _selectedMaskapaiId;

        public MasterMaskapaiForm(MasterMaskapaiService maskapaiService)
        {
            _maskapaiService = maskapaiService;
            InitializeComponent();
            RegisterEvents();
        }

        private async void MasterMaskapaiForm_Load(object? sender, EventArgs e)
        {
            await LoadMaskapaiAsync();
            ResetForm();
        }

        private async void BtnTambah_Click(object? sender, EventArgs e)
        {
            await SaveAsync(() => _maskapaiService.AddAsync(CreateMaskapaiFromInput()));
        }

        private async void BtnEdit_Click(object? sender, EventArgs e)
        {
            var maskapai = CreateMaskapaiFromInput();
            maskapai.ID = _selectedMaskapaiId;
            await SaveAsync(() => _maskapaiService.UpdateAsync(maskapai));
        }

        private async void BtnHapus_Click(object? sender, EventArgs e)
        {
            if (_selectedMaskapaiId <= 0)
            {
                ShowMessage("Pilih data maskapai yang akan dihapus.", MessageBoxIcon.Warning);
                return;
            }

            if (!ConfirmDelete())
            {
                return;
            }

            await SaveAsync(() => _maskapaiService.DeleteAsync(_selectedMaskapaiId));
        }

        private void BtnReset_Click(object? sender, EventArgs e)
        {
            ResetForm();
        }

        private async void TxtCariMaskapai_TextChanged(object? sender, EventArgs e)
        {
            await LoadMaskapaiAsync();
        }

        private void DgvMaskapai_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            FillInputFromRow(dgvMaskapai.Rows[e.RowIndex]);
        }

        private void RegisterEvents()
        {
            Load += MasterMaskapaiForm_Load;
            btnTambah.Click += BtnTambah_Click;
            btnEdit.Click += BtnEdit_Click;
            btnHapus.Click += BtnHapus_Click;
            btnReset.Click += BtnReset_Click;
            txtCariMaskapai.TextChanged += TxtCariMaskapai_TextChanged;
            dgvMaskapai.CellClick += DgvMaskapai_CellClick;
        }

        private async Task LoadMaskapaiAsync()
        {
            try
            {
                var maskapai = await _maskapaiService.SearchAsync(txtCariMaskapai.Text);
                FillGrid(maskapai);
            }
            catch
            {
                ShowMessage("Data maskapai belum dapat dimuat.", MessageBoxIcon.Error);
            }
        }

        private async Task SaveAsync(Func<Task<MaskapaiServiceResult>> action)
        {
            try
            {
                var result = await action();
                ShowMessage(result.Message, GetMessageIcon(result));

                if (result.IsSuccess)
                {
                    await LoadMaskapaiAsync();
                    ResetForm();
                }
            }
            catch
            {
                ShowMessage("Proses data maskapai belum berhasil.", MessageBoxIcon.Error);
            }
        }

        private void FillGrid(IEnumerable<Maskapai> maskapai)
        {
            dgvMaskapai.Rows.Clear();
            foreach (var item in maskapai)
            {
                dgvMaskapai.Rows.Add(
                    item.ID,
                    item.Nama,
                    item.Perusahaan,
                    item.JumlahKru,
                    item.Deskripsi);
            }
        }

        private void FillInputFromRow(DataGridViewRow row)
        {
            _selectedMaskapaiId = Convert.ToInt32(row.Cells["ID"].Value);
            txtNamaMaskapai.Text = Convert.ToString(row.Cells["NamaMaskapai"].Value);
            txtPerusahaan.Text = Convert.ToString(row.Cells["Perusahaan"].Value);
            numJumlahKru.Value = Convert.ToDecimal(row.Cells["JumlahKru"].Value);
            txtDeskripsi.Text = Convert.ToString(row.Cells["Deskripsi"].Value);
            btnTambah.Enabled = false;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;
        }

        private Maskapai CreateMaskapaiFromInput()
        {
            return new Maskapai
            {
                Nama = txtNamaMaskapai.Text,
                Perusahaan = txtPerusahaan.Text,
                JumlahKru = Convert.ToInt32(numJumlahKru.Value),
                Deskripsi = txtDeskripsi.Text
            };
        }

        private void ResetForm()
        {
            _selectedMaskapaiId = 0;
            txtNamaMaskapai.Clear();
            txtPerusahaan.Clear();
            txtDeskripsi.Clear();
            numJumlahKru.Value = 1;
            btnTambah.Enabled = true;
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
            dgvMaskapai.ClearSelection();
        }

        private static bool ConfirmDelete()
        {
            var confirm = MessageBox.Show(
                "Apakah data maskapai ini akan dihapus?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return confirm == DialogResult.Yes;
        }

        private static MessageBoxIcon GetMessageIcon(MaskapaiServiceResult result)
        {
            return result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
        }

        private static void ShowMessage(string message, MessageBoxIcon icon)
        {
            MessageBox.Show(message, "Master Maskapai", MessageBoxButtons.OK, icon);
        }
    }
}
