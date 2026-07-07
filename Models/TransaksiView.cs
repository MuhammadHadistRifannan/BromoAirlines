namespace BromoAirlines.Models;

public sealed class TransaksiView
{
    public int ID { get; set; }
    public int AkunID { get; set; }
    public string NamaAkun { get; set; } = string.Empty;
    public DateTime TanggalTransaksi { get; set; }
    public int JadwalPenerbanganID { get; set; }
    public string KodePenerbangan { get; set; } = string.Empty;
    public string Rute { get; set; } = string.Empty;
    public string Maskapai { get; set; } = string.Empty;
    public int JumlahPenumpang { get; set; }
    public double TotalHarga { get; set; }
    public int? KodePromoID { get; set; }
    public string KodePromo { get; set; } = string.Empty;
}
