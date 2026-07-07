using BromoAirlines.Models;

namespace BromoAirlines.Forms.Users.Pages;

public sealed class PassengerRequestedEventArgs : EventArgs
{
    public PassengerRequestedEventArgs(JadwalPenerbanganView flight, int passengerCount, KodePromo? promo)
    {
        Flight = flight;
        PassengerCount = passengerCount;
        Promo = promo;
    }

    public JadwalPenerbanganView Flight { get; }
    public int PassengerCount { get; }
    public KodePromo? Promo { get; }
}
