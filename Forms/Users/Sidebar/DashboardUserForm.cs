using BromoAirlines.Forms.Users.Pages;
using BromoAirlines.Models;
using BromoAirlines.Repositories;
using BromoAirlines.Services;

namespace BromoAirlines.Forms.Users.Sidebar;

public partial class DashboardUserForm : Form
{
    private readonly int _akunId;
    private readonly UserBookingService _bookingService;
    private readonly UserProfileService _profileService;
    private readonly UserSearchFlightService _searchFlightService;
    private readonly UserTransactionService _transactionService;

    public DashboardUserForm(Akun currentUser)
    {
        _akunId = currentUser.ID;
        _bookingService = new UserBookingService(new KodePromoRepository());
        _searchFlightService = new UserSearchFlightService(
            new BandaraRepository(),
            new JadwalPenerbanganRepository());
        _profileService = new UserProfileService(new AkunRepository());
        _transactionService = new UserTransactionService(new TransaksiRepository());

        InitializeComponent();
        sidebarUser.MenuSelected += SidebarUserMenuSelected;
    }

    private void DashboardUserFormLoad(object? sender, EventArgs e)
    {
        ShowPage(UserMenuItem.Home);
    }

    private void SidebarUserMenuSelected(object? sender, UserMenuSelectedEventArgs e)
    {
        if (e.MenuItem == UserMenuItem.Logout)
        {
            Close();
            return;
        }

        ShowPage(e.MenuItem);
    }

    private void ShowPage(UserMenuItem menuItem)
    {
        sidebarUser.SetActiveMenu(menuItem);
        ChangePanel(CreatePage(menuItem));
    }

    private Form CreatePage(UserMenuItem menuItem)
    {
        return menuItem switch
        {
            UserMenuItem.Home => CreateHomePage(),
            UserMenuItem.SearchFlight => CreateSearchFlightPage(),
            UserMenuItem.MyTicket => new MyTicketForm(_transactionService, _akunId),
            UserMenuItem.History => new HistoryForm(_transactionService, _akunId),
            UserMenuItem.Profile => new ProfileUserForm(_profileService, _akunId),
            _ => new UserPlaceholderPage("Home")
        };
    }

    private HomeUserForm CreateHomePage()
    {
        var form = new HomeUserForm();
        form.SearchFlightRequested += HomeSearchFlightRequested;
        return form;
    }

    private SearchFlightForm CreateSearchFlightPage()
    {
        var form = new SearchFlightForm(_searchFlightService);
        form.FlightDetailRequested += SearchFlightDetailRequested;
        return form;
    }

    private void HomeSearchFlightRequested(object? sender, EventArgs e)
    {
        ShowPage(UserMenuItem.SearchFlight);
    }

    private void SearchFlightDetailRequested(object? sender, FlightSelectedEventArgs e)
    {
        var form = new FlightDetailForm(e.Flight);
        form.BookingRequested += FlightDetailBookingRequested;
        ChangePanel(form);
    }

    private void FlightDetailBookingRequested(object? sender, BookingRequestedEventArgs e)
    {
        var form = new BookingForm(_bookingService, e.Flight);
        form.PassengerRequested += BookingPassengerRequested;
        ChangePanel(form);
    }

    private void BookingPassengerRequested(object? sender, PassengerRequestedEventArgs e)
    {
        var form = new PassengerForm(e.Flight, e.PassengerCount, e.Promo);
        form.PaymentRequested += PassengerPaymentRequested;
        ChangePanel(form);
    }

    private void PassengerPaymentRequested(object? sender, PaymentRequestedEventArgs e)
    {
        var form = new PaymentForm(_transactionService, _akunId, e.Context);
        form.MyTicketRequested += PaymentMyTicketRequested;
        ChangePanel(form);
    }

    private void PaymentMyTicketRequested(object? sender, EventArgs e)
    {
        ShowPage(UserMenuItem.MyTicket);
    }

    private void ChangePanel(Form form)
    {
        panelContent.Controls.Clear();
        form.TopLevel = false;
        form.FormBorderStyle = FormBorderStyle.None;
        form.Dock = DockStyle.Fill;
        panelContent.Controls.Add(form);
        form.Show();
    }
}
