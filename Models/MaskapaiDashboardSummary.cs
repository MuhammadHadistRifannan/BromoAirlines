namespace BromoAirlines.Models;

public sealed class MaskapaiDashboardSummary
{
    public string MaskapaiName { get; set; } = string.Empty;
    public int TodayFlights { get; set; }
    public int ActiveFlights { get; set; }
    public double TodayRevenue { get; set; }
    public int TotalBookings { get; set; }
    public int ActivePromo { get; set; }
    public List<LaporanTransaksiView> RecentTransactions { get; set; } = new();
}
