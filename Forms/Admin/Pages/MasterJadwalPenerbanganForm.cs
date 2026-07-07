using BromoAirlines.Models;
using BromoAirlines.Services;
using System.Globalization;

namespace BromoAirlines.Forms
{
    public partial class MasterJadwalPenerbanganForm : Form
    {
        private static readonly CultureInfo RupiahCulture = new("id-ID");
        private readonly MasterJadwalPenerbanganService _jadwalService;
        private int _selectedJadwalId;

        public MasterJadwalPenerbanganForm(MasterJadwalPenerbanganService jadwalService)
        {
            _jadwalService = jadwalService;
            InitializeComponent();
            RegisterEvents();
        }

        private async void MasterJadwalPenerbanganForm_Load(object? sender, EventArgs e)
        {
            await LoadComboDataAsync();
            await LoadJadwalAsync();
            ResetForm();
        }

        private async void BtnTambah_Click(object? sender, EventArgs e)
        {
            await SaveAsync(() => _jadwalService.AddAsync(CreateJadwalFromInput()));
        }

        private async void BtnEdit_Click(object? sender, EventArgs e)
        {
            var jadwal = CreateJadwalFromInput();
            jadwal.ID = _selectedJadwalId;
            await SaveAsync(() => _jadwalService.UpdateAsync(jadwal));
        }

        private async void BtnHapus_Click(object? sender, EventArgs e)
        {
            if (_selectedJadwalId <= 0)
            {
                ShowMessage("Pilih jadwal penerbangan yang akan dihapus.", MessageBoxIcon.Warning);
                return;
            }

            if (!ConfirmDelete())
            {
                return;
            }

            await SaveAsync(() => _jadwalService.DeleteAsync(_selectedJadwalId));
        }

        private void BtnReset_Click(object? sender, EventArgs e)
        {
            ResetForm();
        }

        private async void TxtCariJadwal_TextChanged(object? sender, EventArgs e)
        {
            await LoadJadwalAsync();
        }

        private void DgvJadwal_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            FillInputFromRow(dgvJadwal.Rows[e.RowIndex]);
        }

        private void DgvJadwal_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvJadwal.Columns[e.ColumnIndex].Name != "HargaPerTiket" || e.Value is null)
            {
                return;
            }

            e.Value = FormatRupiah(Convert.ToDouble(e.Value));
            e.FormattingApplied = true;
        }

        private void RegisterEvents()
        {
            Load += MasterJadwalPenerbanganForm_Load;
            btnTambah.Click += BtnTambah_Click;
            btnEdit.Click += BtnEdit_Click;
            btnHapus.Click += BtnHapus_Click;
            btnReset.Click += BtnReset_Click;
            txtCariJadwal.TextChanged += TxtCariJadwal_TextChanged;
            dgvJadwal.CellClick += DgvJadwal_CellClick;
            dgvJadwal.CellFormatting += DgvJadwal_CellFormatting;
        }

        private async Task LoadComboDataAsync()
        {
            try
            {
                var bandara = await _jadwalService.GetBandaraAsync();
                var maskapai = await _jadwalService.GetMaskapaiAsync();
                BindBandaraCombo(cmbBandaraKeberangkatan, bandara);
                BindBandaraCombo(cmbBandaraTujuan, bandara.ToList());
                BindMaskapaiCombo(maskapai);
            }
            catch
            {
                ShowMessage("Data bandara atau maskapai belum dapat dimuat.", MessageBoxIcon.Error);
            }
        }

        private async Task LoadJadwalAsync()
        {
            try
            {
                var jadwal = await _jadwalService.SearchAsync(txtCariJadwal.Text);
                FillGrid(jadwal);
            }
            catch
            {
                ShowMessage("Data jadwal penerbangan belum dapat dimuat.", MessageBoxIcon.Error);
            }
        }

        private async Task SaveAsync(Func<Task<JadwalPenerbanganServiceResult>> action)
        {
            try
            {
                var result = await action();
                ShowMessage(result.Message, GetMessageIcon(result));

                if (result.IsSuccess)
                {
                    await LoadJadwalAsync();
                    ResetForm();
                }
            }
            catch
            {
                ShowMessage("Proses data jadwal penerbangan belum berhasil.", MessageBoxIcon.Error);
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
                    item.MaskapaiID,
                    item.Maskapai,
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
            cmbMaskapai.SelectedValue = Convert.ToInt32(row.Cells["MaskapaiID"].Value);
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
                MaskapaiID = GetSelectedId(cmbMaskapai),
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
            cmbMaskapai.SelectedIndex = -1;
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

        private void BindMaskapaiCombo(List<Maskapai> maskapai)
        {
            cmbMaskapai.DataSource = maskapai;
            cmbMaskapai.DisplayMember = nameof(BromoAirlines.Models.Maskapai.Nama);
            cmbMaskapai.ValueMember = nameof(BromoAirlines.Models.Maskapai.ID);
            cmbMaskapai.SelectedIndex = -1;
        }

        private static int GetSelectedId(ComboBox comboBox)
        {
            return comboBox.SelectedValue is int id ? id : 0;
        }

        private static bool ConfirmDelete()
        {
            var confirm = MessageBox.Show(
                "Apakah jadwal penerbangan ini akan dihapus?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return confirm == DialogResult.Yes;
        }

        private static MessageBoxIcon GetMessageIcon(JadwalPenerbanganServiceResult result)
        {
            return result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
        }

        private static void ShowMessage(string message, MessageBoxIcon icon)
        {
            MessageBox.Show(message, "Master Jadwal Penerbangan", MessageBoxButtons.OK, icon);
        }

        private static string FormatRupiah(double value)
        {
            return string.Format(RupiahCulture, "Rp {0:N0}", value);
        }
    }
}
