namespace BromoAirlines.Models;

public sealed class MaskapaiReportResult
{
    public LaporanRingkasan Ringkasan { get; set; } = new();
    public List<LaporanTransaksiView> Transaksi { get; set; } = new();
    public List<MaskapaiPopularRouteView> RutePopuler { get; set; } = new();
}
