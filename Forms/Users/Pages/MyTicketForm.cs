using BromoAirlines.Models;
using BromoAirlines.Services;

namespace BromoAirlines.Forms.Users.Pages;

public partial class MyTicketForm : Form
{
    private readonly int _akunId;
    private readonly List<TransaksiView> _tickets = new();
    private readonly UserTransactionService _transactionService;

    public MyTicketForm(UserTransactionService transactionService, int akunId)
    {
        _transactionService = transactionService;
        _akunId = akunId;
        InitializeComponent();
        Resize += MyTicketFormResize;
    }

    private async void MyTicketFormLoad(object sender, EventArgs e)
    {
        AdjustLayout();
        await LoadTicketsAsync();
    }

    private void MyTicketFormResize(object? sender, EventArgs e)
    {
        AdjustLayout();
    }

    private async void GridTicketSelectionChanged(object sender, EventArgs e)
    {
        await ShowSelectedTicketDetailAsync();
    }

    private async Task LoadTicketsAsync()
    {
        _tickets.Clear();
        gridTicket.Rows.Clear();

        try
        {
            _tickets.AddRange(await _transactionService.GetTicketsAsync(_akunId));
            foreach (var ticket in _tickets)
            {
                gridTicket.Rows.Add(
                    CreateBookingNumber(ticket.ID),
                    $"{ticket.Maskapai} | {ticket.Rute} | {ticket.KodePenerbangan}",
                    "Paid");
            }
        }
        catch
        {
            MessageBox.Show(
                "Data tiket belum dapat dimuat. Periksa koneksi database.",
                "BromoAirlines",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }

    private async Task ShowSelectedTicketDetailAsync()
    {
        if (gridTicket.CurrentRow == null || gridTicket.CurrentRow.Index >= _tickets.Count)
        {
            return;
        }

        var ticket = _tickets[gridTicket.CurrentRow.Index];
        var details = await _transactionService.GetDetailsAsync(ticket.ID);
        lblNomorBookingValue.Text = CreateBookingNumber(ticket.ID);
        lblJadwalValue.Text = $"{ticket.Maskapai} | {ticket.Rute} | {ticket.KodePenerbangan}";
        lblStatusValue.Text = "Paid";
        lblDetailValue.Text = details.Count == 0
            ? "-"
            : string.Join(", ", details.Select(detail => detail.NamaLengkapPenumpang));
    }

    private static string CreateBookingNumber(int transaksiId)
    {
        return $"BRM-{transaksiId:0000}";
    }

    private void AdjustLayout()
    {
        var contentWidth = Math.Max(720, panelContent.ClientSize.Width - 96);
        panelSummary.Width = contentWidth;
        panelGrid.Width = contentWidth;
        panelDetail.Width = contentWidth;

        var valueWidth = Math.Max(320, contentWidth - lblNomorBookingValue.Left - 64);
        lblSummaryDescription.Width = Math.Max(320, contentWidth - 64);
        lblNomorBookingValue.Width = valueWidth;
        lblJadwalValue.Width = valueWidth;
        lblStatusValue.Width = valueWidth;
        lblDetailValue.Width = valueWidth;
    }
}
