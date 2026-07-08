using BromoAirlines.Models;

namespace BromoAirlines.Forms.Users.Pages;

public sealed class BookingRequestedEventArgs : EventArgs
{
    public BookingRequestedEventArgs(JadwalPenerbanganView flight, Maskapai maskapai)
    {
        Flight = flight;
        Maskapai = maskapai;
    }

    public JadwalPenerbanganView Flight { get; }
    public Maskapai Maskapai { get; }
}
