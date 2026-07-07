namespace BromoAirlines.Models;

public sealed class LaporanMaskapaiView
{
    public string Maskapai { get; set; } = string.Empty;
    public int TotalTransaksi { get; set; }
    public int TotalPenumpang { get; set; }
    public double TotalPendapatan { get; set; }
}
