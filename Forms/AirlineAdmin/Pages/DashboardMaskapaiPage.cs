using BromoAirlines.Models;
using BromoAirlines.Services;
using System.Globalization;

namespace BromoAirlines.Forms.AirlineAdmin.Pages;

public partial class DashboardMaskapaiPage : Form
{
    private static readonly CultureInfo RupiahCulture = new("id-ID");
    private readonly Akun? _currentUser;
    private readonly MaskapaiDashboardService? _dashboardService;

    public DashboardMaskapaiPage()
    {
        InitializeComponent();
    }

    public DashboardMaskapaiPage(Akun? currentUser, MaskapaiDashboardService dashboardService) : this()
    {
        _currentUser = currentUser;
        _dashboardService = dashboardService;
    }

    private async void DashboardMaskapaiPageLoad(object? sender, EventArgs e)
    {
        lblWelcome.Text = string.IsNullOrWhiteSpace(_currentUser?.Nama)
            ? "Ringkasan operasional maskapai hari ini."
            : $"Selamat datang, {_currentUser.Nama}.";

        await LoadDashboardAsync();
    }

    private async Task LoadDashboardAsync()
    {
        if (_dashboardService is null)
        {
            LoadEmptyDashboard();
            return;
        }

        try
        {
            FillDashboard(await _dashboardService.GetSummaryAsync());
        }
        catch
        {
            LoadEmptyDashboard();
            MessageBox.Show(
                "Dashboard maskapai belum dapat dimuat. Pastikan session maskapai valid.",
                "Dashboard Maskapai",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void FillDashboard(MaskapaiDashboardSummary summary)
    {
        lblTitle.Text = string.IsNullOrWhiteSpace(summary.MaskapaiName)
            ? "Dashboard Maskapai"
            : $"Dashboard Maskapai ({summary.MaskapaiName})";

        lblTodayFlightsValue.Text = summary.TodayFlights.ToString("N0", RupiahCulture);
        lblActiveFlightsValue.Text = summary.ActiveFlights.ToString("N0", RupiahCulture);
        lblTodayRevenueValue.Text = string.Format(RupiahCulture, "Rp {0:N0}", summary.TodayRevenue);
        lblTotalBookingsValue.Text = summary.TotalBookings.ToString("N0", RupiahCulture);
        lblActivePromoValue.Text = summary.ActivePromo.ToString("N0", RupiahCulture);

        gridRecentTransactions.Rows.Clear();
        foreach (var item in summary.RecentTransactions)
        {
            gridRecentTransactions.Rows.Add(
                $"TRX-{item.ID:D5}",
                item.TanggalTransaksi,
                item.KodePenerbangan,
                item.JumlahPenumpang,
                string.Format(RupiahCulture, "Rp {0:N0}", item.TotalHarga),
                "Paid");
        }
    }

    private void LoadEmptyDashboard()
    {
        lblTitle.Text = "Dashboard Maskapai";
        lblTodayFlightsValue.Text = "0";
        lblActiveFlightsValue.Text = "0";
        lblTodayRevenueValue.Text = "Rp 0";
        lblTotalBookingsValue.Text = "0";
        lblActivePromoValue.Text = "0";

        gridRecentTransactions.Rows.Clear();
    }
}
