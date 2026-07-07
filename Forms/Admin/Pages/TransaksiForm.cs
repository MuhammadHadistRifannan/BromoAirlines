using BromoAirlines.Models;
using BromoAirlines.Services;
using System.Globalization;

namespace BromoAirlines.Forms
{
    public partial class TransaksiForm : Form
    {
        private static readonly CultureInfo RupiahCulture = new("id-ID");
        private readonly TransaksiService _transaksiService;
        private int _selectedTransaksiId;

        public TransaksiForm(TransaksiService transaksiService)
        {
            _transaksiService = transaksiService;
            InitializeComponent();
            RegisterEvents();
        }

        private async void TransaksiForm_Load(object? sender, EventArgs e)
        {
            await LoadTransaksiAsync();
            ResetSelection();
        }

        private async void TxtCariTransaksi_TextChanged(object? sender, EventArgs e)
        {
            await LoadTransaksiAsync();
        }

        private async void BtnRefresh_Click(object? sender, EventArgs e)
        {
            await LoadTransaksiAsync();
            ResetSelection();
        }

        private async void BtnHapus_Click(object? sender, EventArgs e)
        {
            await DeleteSelectedTransaksiAsync();
        }

        private async void DgvTransaksi_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            await SelectTransaksiAsync(dgvTransaksi.Rows[e.RowIndex]);
        }

        private void DgvTransaksi_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is null || e.Value == DBNull.Value)
            {
                e.Value = "-";
                e.FormattingApplied = true;
                return;
            }

            ApplyGridFormat(e, dgvTransaksi.Columns[e.ColumnIndex].Name);
        }

        private void RegisterEvents()
        {
            Load += TransaksiForm_Load;
            txtCariTransaksi.TextChanged += TxtCariTransaksi_TextChanged;
            btnRefresh.Click += BtnRefresh_Click;
            btnHapus.Click += BtnHapus_Click;
            dgvTransaksi.CellClick += DgvTransaksi_CellClick;
            dgvTransaksi.CellFormatting += DgvTransaksi_CellFormatting;
        }

        private async Task LoadTransaksiAsync()
        {
            try
            {
                var transaksi = await _transaksiService.SearchAsync(txtCariTransaksi.Text);
                FillTransaksiGrid(transaksi);
            }
            catch
            {
                ShowMessage("Data transaksi belum dapat dimuat.", MessageBoxIcon.Error);
            }
        }

        private async Task SelectTransaksiAsync(DataGridViewRow row)
        {
            _selectedTransaksiId = Convert.ToInt32(row.Cells["ID"].Value);
            lblSelectedTransaksi.Text = $"#{_selectedTransaksiId} - {row.Cells["NamaAkun"].Value}";
            btnHapus.Enabled = true;
            await LoadDetailPenumpangAsync(_selectedTransaksiId);
        }

        private async Task LoadDetailPenumpangAsync(int transaksiId)
        {
            try
            {
                var details = await _transaksiService.GetDetailsAsync(transaksiId);
                FillDetailGrid(details);
            }
            catch
            {
                ShowMessage("Detail penumpang belum dapat dimuat.", MessageBoxIcon.Error);
            }
        }

        private async Task DeleteSelectedTransaksiAsync()
        {
            if (_selectedTransaksiId <= 0)
            {
                ShowMessage("Pilih transaksi yang akan dihapus.", MessageBoxIcon.Warning);
                return;
            }

            if (!ConfirmDelete())
            {
                return;
            }

            await ExecuteDeleteAsync();
        }

        private async Task ExecuteDeleteAsync()
        {
            var result = await _transaksiService.DeleteAsync(_selectedTransaksiId);
            ShowMessage(result.Message, GetMessageIcon(result));

            if (result.IsSuccess)
            {
                await LoadTransaksiAsync();
                ResetSelection();
            }
        }

        private void FillTransaksiGrid(IEnumerable<TransaksiView> transaksi)
        {
            dgvTransaksi.Rows.Clear();
            foreach (var item in transaksi)
            {
                dgvTransaksi.Rows.Add(
                    item.ID,
                    item.AkunID,
                    item.NamaAkun,
                    item.TanggalTransaksi,
                    item.JadwalPenerbanganID,
                    item.KodePenerbangan,
                    item.Rute,
                    item.Maskapai,
                    item.JumlahPenumpang,
                    item.TotalHarga,
                    item.KodePromoID ?? (object)DBNull.Value,
                    item.KodePromo);
            }
        }

        private void FillDetailGrid(IEnumerable<TransaksiDetail> details)
        {
            dgvDetailPenumpang.Rows.Clear();
            foreach (var item in details)
            {
                dgvDetailPenumpang.Rows.Add(
                    item.ID,
                    item.TransaksiHeaderID,
                    item.TitelPenumpang,
                    item.NamaLengkapPenumpang);
            }
        }

        private void ResetSelection()
        {
            _selectedTransaksiId = 0;
            lblSelectedTransaksi.Text = "-";
            btnHapus.Enabled = false;
            dgvTransaksi.ClearSelection();
            dgvDetailPenumpang.Rows.Clear();
        }

        private static void ApplyGridFormat(DataGridViewCellFormattingEventArgs e, string columnName)
        {
            if (columnName == "TanggalTransaksi")
            {
                e.Value = Convert.ToDateTime(e.Value).ToString("dd/MM/yyyy HH:mm");
                e.FormattingApplied = true;
                return;
            }

            if (columnName == "TotalHarga")
            {
                e.Value = FormatRupiah(Convert.ToDouble(e.Value));
                e.FormattingApplied = true;
            }
        }

        private static bool ConfirmDelete()
        {
            var confirm = MessageBox.Show(
                "Apakah transaksi dan seluruh detail penumpangnya akan dihapus?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return confirm == DialogResult.Yes;
        }

        private static MessageBoxIcon GetMessageIcon(TransaksiServiceResult result)
        {
            return result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
        }

        private static void ShowMessage(string message, MessageBoxIcon icon)
        {
            MessageBox.Show(message, "Transaksi", MessageBoxButtons.OK, icon);
        }

        private static string FormatRupiah(double value)
        {
            return string.Format(RupiahCulture, "Rp {0:N0}", value);
        }
    }
}
