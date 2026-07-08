namespace BromoAirlines.Models;

public sealed class TransaksiHeader
{
    public int ID { get; set; }
    public int AkunID { get; set; }
    public DateTime TanggalTransaksi { get; set; }
    public int JadwalPenerbanganID { get; set; }
    public int JumlahPenumpang { get; set; }
    public int MaskapaiID { get; set; }
    public double TotalHarga { get; set; }
    public int? KodePromoID { get; set; }
}
