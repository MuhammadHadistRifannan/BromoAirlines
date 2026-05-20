namespace BromoAirlines.Models;

public sealed class TransaksiDetail
{
    public int ID { get; set; }
    public int TransaksiHeaderID { get; set; }
    public string TitelPenumpang { get; set; } = string.Empty;
    public string NamaLengkapPenumpang { get; set; } = string.Empty;
}
