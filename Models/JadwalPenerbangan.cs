namespace BromoAirlines.Models;

public sealed class JadwalPenerbangan
{
    public int ID { get; set; }
    public string KodePenerbangan { get; set; } = string.Empty;
    public int BandaraKeberangkatanID { get; set; }
    public int BandaraTujuanID { get; set; }
    public int MaskapaiID { get; set; }
    public DateTime TanggalWaktuKeberangkatan { get; set; }
    public int DurasiPenerbangan { get; set; }
    public double HargaPerTiket { get; set; }
}
