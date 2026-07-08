using BromoAirlines.Models;

namespace BromoAirlines.Forms.Users.Pages;

public sealed class FlightSelectedEventArgs : EventArgs
{
    public FlightSelectedEventArgs(JadwalPenerbanganView flight, Maskapai maskapai)
    {
        Flight = flight;
        Maskapai = maskapai;
    }

    public JadwalPenerbanganView Flight { get; }
    public Maskapai Maskapai { get; }
}
