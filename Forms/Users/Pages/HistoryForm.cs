using BromoAirlines.Models;
using BromoAirlines.Services;

namespace BromoAirlines.Forms.Users.Pages;

public partial class HistoryForm : Form
{
    private readonly int _akunId;
    private readonly UserTransactionService _transactionService;

    public HistoryForm(UserTransactionService transactionService, int akunId)
    {
        _transactionService = transactionService;
        _akunId = akunId;
        InitializeComponent();
    }

    private async void HistoryFormLoad(object sender, EventArgs e)
    {
        dtpTanggalMulai.Value = DateTime.Today.AddYears(-10);
        dtpTanggalSampai.Value = DateTime.Today;
        await LoadHistoryAsync();
    }

    private async void BtnResetClick(object sender, EventArgs e)
    {
        dtpTanggalMulai.Value = DateTime.Today.AddYears(-10);
        dtpTanggalSampai.Value = DateTime.Today;
        cmbStatus.SelectedIndex = -1;
        await LoadHistoryAsync();
    }

    private async void BtnFilterClick(object sender, EventArgs e)
    {
        await LoadHistoryAsync();
    }

    private async Task LoadHistoryAsync()
    {
        gridHistory.Rows.Clear();

        try
        {
            var history = await _transactionService.GetHistoryAsync(
                _akunId,
                dtpTanggalMulai.Value,
                dtpTanggalSampai.Value,
                cmbStatus.Text);

            BindHistory(history);
        }
        catch
        {
            MessageBox.Show(
                "Riwayat transaksi belum dapat dimuat. Periksa koneksi database.",
                "BromoAirlines",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }

    private void BindHistory(List<TransaksiView> history)
    {
        foreach (var item in history)
        {
            gridHistory.Rows.Add(
                $"TRX-{item.ID:0000}",
                $"BRM-{item.ID:0000}",
                item.TanggalTransaksi.ToString("dd/MM/yyyy"),
                $"{item.Maskapai} | {item.Rute} | {item.KodePenerbangan}",
                "Paid",
                $"Rp {item.TotalHarga:N0}");
        }
    }
}
