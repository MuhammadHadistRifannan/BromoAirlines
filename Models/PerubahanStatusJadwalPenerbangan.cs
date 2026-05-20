namespace BromoAirlines.Models;

public sealed class PerubahanStatusJadwalPenerbangan
{
    public int ID { get; set; }
    public int JadwalPenerbanganID { get; set; }
    public int StatusPenerbanganID { get; set; }
    public DateTime WaktuPerubahanTerjadi { get; set; }
    public int? PerkiraanDurasiDelay { get; set; }
}
