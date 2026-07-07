namespace BromoAirlines.Models;

public sealed class BandaraView
{
    public int ID { get; set; }
    public string Nama { get; set; } = string.Empty;
    public string KodeIATA { get; set; } = string.Empty;
    public string Kota { get; set; } = string.Empty;
    public int NegaraID { get; set; }
    public string NegaraNama { get; set; } = string.Empty;
    public int JumlahTerminal { get; set; }
    public string Alamat { get; set; } = string.Empty;
}
