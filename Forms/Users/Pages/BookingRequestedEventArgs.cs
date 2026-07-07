using BromoAirlines.Models;

namespace BromoAirlines.Forms.Users.Pages;

public sealed class BookingRequestedEventArgs : EventArgs
{
    public BookingRequestedEventArgs(JadwalPenerbanganView flight)
    {
        Flight = flight;
    }

    public JadwalPenerbanganView Flight { get; }
}
