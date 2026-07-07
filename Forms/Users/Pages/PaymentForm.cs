using BromoAirlines.Models;
using BromoAirlines.Services;

namespace BromoAirlines.Forms.Users.Pages;

public partial class PaymentForm : Form
{
    private readonly int _akunId;
    private readonly UserBookingContext _context;
    private readonly UserTransactionService _transactionService;

    public PaymentForm(UserTransactionService transactionService, int akunId, UserBookingContext context)
    {
        _transactionService = transactionService;
        _akunId = akunId;
        _context = context;
        InitializeComponent();
        Load += PaymentFormLoad;
        Resize += PaymentFormResize;
    }

    public event EventHandler? MyTicketRequested;

    private void PaymentFormLoad(object? sender, EventArgs e)
    {
        lblSummaryDescription.Text = $"{_context.Flight.KodePenerbangan} | {_context.JumlahPenumpang} penumpang";
        lblHargaValue.Text = FormatCurrency(_transactionService.CalculateSubtotal(_context));
        lblPajakValue.Text = FormatCurrency(_transactionService.CalculateTax(_context));
        lblPromoValue.Text = FormatCurrency(_transactionService.CalculatePromo(_context));
        lblTotalBayarValue.Text = FormatCurrency(_transactionService.CalculateTotal(_context));
        cmbMetodePembayaran.SelectedIndex = 0;
        AdjustLayout();
    }

    private async void BtnBayarClick(object sender, EventArgs e)
    {
        try
        {
            var result = await _transactionService.PayAsync(_akunId, _context);
            lblStatusPembayaran.Text = result.Message;
            lblStatusPembayaran.ForeColor = result.IsSuccess ? Color.SeaGreen : Color.Firebrick;
            btnBayar.Enabled = !result.IsSuccess;
            btnLihatTiket.Visible = result.IsSuccess;
        }
        catch
        {
            lblStatusPembayaran.Text = "Pembayaran belum dapat diproses. Periksa koneksi database.";
            lblStatusPembayaran.ForeColor = Color.Firebrick;
        }
    }

    private void BtnLihatTiketClick(object sender, EventArgs e)
    {
        MyTicketRequested?.Invoke(this, EventArgs.Empty);
    }

    private void PaymentFormResize(object? sender, EventArgs e)
    {
        AdjustLayout();
    }

    private void AdjustLayout()
    {
        var contentWidth = Math.Max(720, panelContent.ClientSize.Width - 96);
        panelSummary.Width = contentWidth;
        panelPayment.Width = contentWidth;
        panelMethod.Width = contentWidth;

        var actionRight = Math.Max(0, panelAction.ClientSize.Width - panelAction.Padding.Right);
        btnBayar.Left = actionRight - btnBayar.Width;
        btnLihatTiket.Left = btnBayar.Left - btnLihatTiket.Width - 24;
        lblStatusPembayaran.Left = panelAction.Padding.Left;
        lblStatusPembayaran.Width = Math.Max(320, btnLihatTiket.Left - panelAction.Padding.Left - 24);
    }

    private static string FormatCurrency(double value)
    {
        return $"Rp {value:N0}";
    }
}
