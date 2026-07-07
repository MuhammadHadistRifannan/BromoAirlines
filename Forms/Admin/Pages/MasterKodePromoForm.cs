using BromoAirlines.Models;
using BromoAirlines.Services;
using System.Globalization;

namespace BromoAirlines.Forms
{
    public partial class MasterKodePromoForm : Form
    {
        private static readonly CultureInfo RupiahCulture = new("id-ID");
        private readonly MasterKodePromoService _kodePromoService;
        private int _selectedKodePromoId;

        public MasterKodePromoForm(MasterKodePromoService kodePromoService)
        {
            _kodePromoService = kodePromoService;
            InitializeComponent();
            RegisterEvents();
        }

        private async void MasterKodePromoForm_Load(object? sender, EventArgs e)
        {
            await LoadKodePromoAsync();
            ResetForm();
        }

        private async void BtnTambah_Click(object? sender, EventArgs e)
        {
            await SaveAsync(() => _kodePromoService.AddAsync(CreateKodePromoFromInput()));
        }

        private async void BtnEdit_Click(object? sender, EventArgs e)
        {
            var kodePromo = CreateKodePromoFromInput();
            kodePromo.ID = _selectedKodePromoId;
            await SaveAsync(() => _kodePromoService.UpdateAsync(kodePromo));
        }

        private async void BtnHapus_Click(object? sender, EventArgs e)
        {
            if (_selectedKodePromoId <= 0)
            {
                ShowMessage("Pilih kode promo yang akan dihapus.", MessageBoxIcon.Warning);
                return;
            }

            if (!ConfirmDelete())
            {
                return;
            }

            await SaveAsync(() => _kodePromoService.DeleteAsync(_selectedKodePromoId));
        }

        private void BtnReset_Click(object? sender, EventArgs e)
        {
            ResetForm();
        }

        private async void TxtCariPromo_TextChanged(object? sender, EventArgs e)
        {
            await LoadKodePromoAsync();
        }

        private void DgvKodePromo_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            FillInputFromRow(dgvKodePromo.Rows[e.RowIndex]);
        }

        private void DgvKodePromo_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            var columnName = dgvKodePromo.Columns[e.ColumnIndex].Name;
            if (e.Value is null)
            {
                return;
            }

            ApplyGridFormat(e, columnName);
        }

        private void RegisterEvents()
        {
            Load += MasterKodePromoForm_Load;
            btnTambah.Click += BtnTambah_Click;
            btnEdit.Click += BtnEdit_Click;
            btnHapus.Click += BtnHapus_Click;
            btnReset.Click += BtnReset_Click;
            txtCariPromo.TextChanged += TxtCariPromo_TextChanged;
            dgvKodePromo.CellClick += DgvKodePromo_CellClick;
            dgvKodePromo.CellFormatting += DgvKodePromo_CellFormatting;
        }

        private async Task LoadKodePromoAsync()
        {
            try
            {
                var kodePromo = await _kodePromoService.SearchAsync(txtCariPromo.Text);
                FillGrid(kodePromo);
            }
            catch
            {
                ShowMessage("Data kode promo belum dapat dimuat.", MessageBoxIcon.Error);
            }
        }

        private async Task SaveAsync(Func<Task<KodePromoServiceResult>> action)
        {
            try
            {
                var result = await action();
                ShowMessage(result.Message, GetMessageIcon(result));

                if (result.IsSuccess)
                {
                    await LoadKodePromoAsync();
                    ResetForm();
                }
            }
            catch
            {
                ShowMessage("Proses data kode promo belum berhasil.", MessageBoxIcon.Error);
            }
        }

        private void FillGrid(IEnumerable<KodePromo> kodePromo)
        {
            dgvKodePromo.Rows.Clear();
            foreach (var item in kodePromo)
            {
                dgvKodePromo.Rows.Add(
                    item.ID,
                    item.Kode,
                    item.PersentaseDiskon,
                    item.MaksimumDiskon,
                    item.BerlakuSampai,
                    item.Deskripsi);
            }
        }

        private void FillInputFromRow(DataGridViewRow row)
        {
            _selectedKodePromoId = Convert.ToInt32(row.Cells["ID"].Value);
            txtKode.Text = Convert.ToString(row.Cells["Kode"].Value);
            numPersentaseDiskon.Value = Convert.ToDecimal(row.Cells["PersentaseDiskon"].Value);
            numMaksimumDiskon.Value = Convert.ToDecimal(row.Cells["MaksimumDiskon"].Value);
            dtpBerlakuSampai.Value = Convert.ToDateTime(row.Cells["BerlakuSampai"].Value);
            txtDeskripsi.Text = Convert.ToString(row.Cells["Deskripsi"].Value);
            btnTambah.Enabled = false;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;
        }

        private KodePromo CreateKodePromoFromInput()
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
            _selectedKodePromoId = 0;
            txtKode.Clear();
            txtDeskripsi.Clear();
            numPersentaseDiskon.Value = 1;
            numMaksimumDiskon.Value = 1;
            dtpBerlakuSampai.Value = DateTime.Today.AddDays(1);
            btnTambah.Enabled = true;
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
            dgvKodePromo.ClearSelection();
        }

        private static void ApplyGridFormat(DataGridViewCellFormattingEventArgs e, string columnName)
        {
            if (columnName == "PersentaseDiskon")
            {
                e.Value = $"{Convert.ToDouble(e.Value):0.##}%";
                e.FormattingApplied = true;
                return;
            }

            if (columnName == "MaksimumDiskon")
            {
                e.Value = FormatRupiah(Convert.ToDouble(e.Value));
                e.FormattingApplied = true;
                return;
            }

            if (columnName == "BerlakuSampai")
            {
                e.Value = Convert.ToDateTime(e.Value).ToString("dd/MM/yyyy");
                e.FormattingApplied = true;
            }
        }

        private static bool ConfirmDelete()
        {
            var confirm = MessageBox.Show(
                "Apakah kode promo ini akan dihapus?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return confirm == DialogResult.Yes;
        }

        private static MessageBoxIcon GetMessageIcon(KodePromoServiceResult result)
        {
            return result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
        }

        private static void ShowMessage(string message, MessageBoxIcon icon)
        {
            MessageBox.Show(message, "Master Kode Promo", MessageBoxButtons.OK, icon);
        }

        private static string FormatRupiah(double value)
        {
            return string.Format(RupiahCulture, "Rp {0:N0}", value);
        }
    }
}
