namespace BromoAirlines.Models;

public sealed class UserBookingContext
{
    public JadwalPenerbanganView Flight { get; set; } = new();
    public int JumlahPenumpang { get; set; }
    public KodePromo? Promo { get; set; }
    public List<PassengerInputData> Passengers { get; set; } = new();
}
