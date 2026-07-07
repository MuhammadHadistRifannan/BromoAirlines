namespace BromoAirlines.Models;

public sealed class JadwalStatusView
{
    public int JadwalPenerbanganID { get; set; }
    public string KodePenerbangan { get; set; } = string.Empty;
    public string BandaraKeberangkatan { get; set; } = string.Empty;
    public string BandaraTujuan { get; set; } = string.Empty;
    public string Maskapai { get; set; } = string.Empty;
    public DateTime TanggalWaktuKeberangkatan { get; set; }
    public int StatusPenerbanganID { get; set; }
    public string StatusPenerbangan { get; set; } = string.Empty;
    public DateTime? WaktuPerubahanTerjadi { get; set; }
    public int? PerkiraanDurasiDelay { get; set; }
}
