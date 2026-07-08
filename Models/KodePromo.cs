namespace BromoAirlines.Models;

public sealed class KodePromo
{
    public int ID { get; set; }
    public int MaskapaiID { get; set; }
    public string Kode { get; set; } = string.Empty;
    public double PersentaseDiskon { get; set; }
    public double MaksimumDiskon { get; set; }
    public DateTime BerlakuSampai { get; set; }
    public string Deskripsi { get; set; } = string.Empty;
}
