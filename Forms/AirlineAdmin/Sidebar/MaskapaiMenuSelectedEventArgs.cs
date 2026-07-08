namespace BromoAirlines.Forms.AirlineAdmin.Sidebar;

public sealed class MaskapaiMenuSelectedEventArgs : EventArgs
{
    public MaskapaiMenuSelectedEventArgs(MaskapaiMenuItem menuItem)
    {
        MenuItem = menuItem;
    }

    public MaskapaiMenuItem MenuItem { get; }
}
