namespace BromoAirlines.Forms.AirlineAdmin.Sidebar;

public partial class SidebarMaskapai : UserControl
{
    private readonly Dictionary<MaskapaiMenuItem, Button> _menuButtons = new();
    private readonly Color _activeColor = Color.White;
    private readonly Color _activeTextColor = Color.RoyalBlue;
    private readonly Color _defaultColor = Color.RoyalBlue;
    private readonly Color _defaultTextColor = Color.White;

    public SidebarMaskapai()
    {
        InitializeComponent();
        RegisterMenuButtons();
        SetActiveMenu(MaskapaiMenuItem.Dashboard);
    }

    public event EventHandler<MaskapaiMenuSelectedEventArgs>? MenuSelected;

    public void SetActiveMenu(MaskapaiMenuItem menuItem)
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
        _menuButtons[MaskapaiMenuItem.Dashboard] = btnDashboard;
        _menuButtons[MaskapaiMenuItem.JadwalPenerbangan] = btnJadwalPenerbangan;
        _menuButtons[MaskapaiMenuItem.KodePromo] = btnKodePromo;
        _menuButtons[MaskapaiMenuItem.LaporanTransaksi] = btnLaporanTransaksi;
        _menuButtons[MaskapaiMenuItem.Logout] = btnLogout;
    }

    private void MenuDashboardClick(object sender, EventArgs e)
    {
        SelectMenu(MaskapaiMenuItem.Dashboard);
    }

    private void MenuJadwalPenerbanganClick(object sender, EventArgs e)
    {
        SelectMenu(MaskapaiMenuItem.JadwalPenerbangan);
    }

    private void MenuKodePromoClick(object sender, EventArgs e)
    {
        SelectMenu(MaskapaiMenuItem.KodePromo);
    }

    private void MenuLaporanTransaksiClick(object sender, EventArgs e)
    {
        SelectMenu(MaskapaiMenuItem.LaporanTransaksi);
    }

    private void MenuLogoutClick(object sender, EventArgs e)
    {
        SelectMenu(MaskapaiMenuItem.Logout);
    }

    private void SelectMenu(MaskapaiMenuItem menuItem)
    {
        MenuSelected?.Invoke(this, new MaskapaiMenuSelectedEventArgs(menuItem));
    }
}
