namespace BromoAirlines.Forms.AirlineAdmin.Pages;

public partial class MaskapaiPlaceholderPage : Form
{
    private readonly string _title;

    public MaskapaiPlaceholderPage(string title)
    {
        _title = title;
        InitializeComponent();
    }

    private void MaskapaiPlaceholderPageLoad(object? sender, EventArgs e)
    {
        lblTitle.Text = _title;
    }
}
