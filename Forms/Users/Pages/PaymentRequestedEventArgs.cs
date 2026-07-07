using BromoAirlines.Models;

namespace BromoAirlines.Forms.Users.Pages;

public sealed class PaymentRequestedEventArgs : EventArgs
{
    public PaymentRequestedEventArgs(UserBookingContext context)
    {
        Context = context;
    }

    public UserBookingContext Context { get; }
}
