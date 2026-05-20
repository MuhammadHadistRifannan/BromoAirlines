namespace BromoAirlines.Models;

public sealed class Maskapai
{
    public int ID { get; set; }
    public string Nama { get; set; } = string.Empty;
    public string Perusahaan { get; set; } = string.Empty;
    public int JumlahKru { get; set; }
    public string Deskripsi { get; set; } = string.Empty;
}
