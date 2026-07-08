namespace BromoAirlines.Models;

public sealed class Akun
{
    public int ID { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Nama { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime TanggalLahir { get; set; }
    public string NomorTelepon { get; set; } = string.Empty;
    public int MerupakanAdmin { get; set; }

    public bool IsUser => MerupakanAdmin == 0;
    public bool IsAdminMaster => MerupakanAdmin == 1;
    public bool IsAdminMaskapai => MerupakanAdmin == 2;
}
