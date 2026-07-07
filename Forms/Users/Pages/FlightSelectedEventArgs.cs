using BromoAirlines.Models;

namespace BromoAirlines.Forms.Users.Pages;

public sealed class FlightSelectedEventArgs : EventArgs
{
    public FlightSelectedEventArgs(JadwalPenerbanganView flight)
    {
        Flight = flight;
    }

    public JadwalPenerbanganView Flight { get; }
}
