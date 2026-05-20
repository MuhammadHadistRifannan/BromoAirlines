using BromoAirlines.Models;

namespace BromoAirlines.Forms;

public partial class CustomerMainForm : Form
{
    private Akun _user = new() { Nama = "Customer" };

    public CustomerMainForm()
    {
        InitializeComponent();
        WireNavigation();
        ShowPage(new SearchFlightForm());
    }

    public CustomerMainForm(Akun user) : this()
    {
        _user = user;
    }

    private void WireNavigation()
    {
        searchButton.Click += (_, _) => ShowPage(new SearchFlightForm());
        historyButton.Click += (_, _) => ShowPage(new TransactionHistoryForm(_user));
    }

    private void ShowPage(Control page)
    {
        contentPanel.Controls.Clear();
        page.Dock = DockStyle.Fill;
        contentPanel.Controls.Add(page);
    }
}
