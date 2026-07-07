namespace BromoAirlines.Forms.Users.Pages;

public partial class HomeUserForm : Form
{
    public HomeUserForm()
    {
        InitializeComponent();
    }

    public event EventHandler? SearchFlightRequested;

    private void BtnSearchFlightClick(object sender, EventArgs e)
    {
        SearchFlightRequested?.Invoke(this, EventArgs.Empty);
    }
}
