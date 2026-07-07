namespace BromoAirlines.Forms.Users.Sidebar;

public sealed class UserMenuSelectedEventArgs : EventArgs
{
    public UserMenuSelectedEventArgs(UserMenuItem menuItem)
    {
        MenuItem = menuItem;
    }

    public UserMenuItem MenuItem { get; }
}
