namespace BromoAirlines.Models;

public sealed class LaporanTransaksiView
{
    public int ID { get; set; }
    public DateTime TanggalTransaksi { get; set; }
    public string NamaAkun { get; set; } = string.Empty;
    public string KodePenerbangan { get; set; } = string.Empty;
    public string Rute { get; set; } = string.Empty;
    public string Maskapai { get; set; } = string.Empty;
    public int JumlahPenumpang { get; set; }
    public double TotalHarga { get; set; }
    public string KodePromo { get; set; } = string.Empty;
}
