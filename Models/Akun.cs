namespace BromoAirlines.Models;

public sealed class Akun
{
    public int ID { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Nama { get; set; } = string.Empty;
    public DateTime TanggalLahir { get; set; }
    public string NomorTelepon { get; set; } = string.Empty;
    public bool MerupakanAdmin { get; set; }
}
