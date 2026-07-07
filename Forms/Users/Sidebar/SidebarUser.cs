namespace BromoAirlines.Forms.Users.Sidebar;

public partial class SidebarUser : UserControl
{
    private readonly Dictionary<UserMenuItem, Button> _menuButtons = new();
    private readonly Color _activeColor = Color.White;
    private readonly Color _activeTextColor = Color.RoyalBlue;
    private readonly Color _defaultColor = Color.RoyalBlue;
    private readonly Color _defaultTextColor = Color.White;

    public SidebarUser()
    {
        InitializeComponent();
        RegisterMenuButtons();
        SetActiveMenu(UserMenuItem.Home);
    }

    public event EventHandler<UserMenuSelectedEventArgs>? MenuSelected;

    public void SetActiveMenu(UserMenuItem menuItem)
    {
        foreach (var item in _menuButtons)
        {
            var isActive = item.Key == menuItem;
            item.Value.BackColor = isActive ? _activeColor : _defaultColor;
            item.Value.ForeColor = isActive ? _activeTextColor : _defaultTextColor;
        }
    }

    private void RegisterMenuButtons()
    {
        _menuButtons[UserMenuItem.Home] = btnHome;
        _menuButtons[UserMenuItem.SearchFlight] = btnSearchFlight;
        _menuButtons[UserMenuItem.MyTicket] = btnMyTicket;
        _menuButtons[UserMenuItem.History] = btnHistory;
        _menuButtons[UserMenuItem.Profile] = btnProfile;
        _menuButtons[UserMenuItem.Logout] = btnLogout;
    }

    private void MenuHomeClick(object sender, EventArgs e)
    {
        SelectMenu(UserMenuItem.Home);
    }

    private void MenuSearchFlightClick(object sender, EventArgs e)
    {
        SelectMenu(UserMenuItem.SearchFlight);
    }

    private void MenuMyTicketClick(object sender, EventArgs e)
    {
        SelectMenu(UserMenuItem.MyTicket);
    }

    private void MenuHistoryClick(object sender, EventArgs e)
    {
        SelectMenu(UserMenuItem.History);
    }

    private void MenuProfileClick(object sender, EventArgs e)
    {
        SelectMenu(UserMenuItem.Profile);
    }

    private void MenuLogoutClick(object sender, EventArgs e)
    {
        SelectMenu(UserMenuItem.Logout);
    }

    private void SelectMenu(UserMenuItem menuItem)
    {
        MenuSelected?.Invoke(this, new UserMenuSelectedEventArgs(menuItem));
    }
}
