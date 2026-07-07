namespace BromoAirlines.Models;

public sealed class JadwalPenerbanganView
{
    public int ID { get; set; }
    public string KodePenerbangan { get; set; } = string.Empty;
    public int BandaraKeberangkatanID { get; set; }
    public string BandaraKeberangkatan { get; set; } = string.Empty;
    public int BandaraTujuanID { get; set; }
    public string BandaraTujuan { get; set; } = string.Empty;
    public int MaskapaiID { get; set; }
    public string Maskapai { get; set; } = string.Empty;
    public DateTime TanggalWaktuKeberangkatan { get; set; }
    public int DurasiPenerbangan { get; set; }
    public double HargaPerTiket { get; set; }
}
