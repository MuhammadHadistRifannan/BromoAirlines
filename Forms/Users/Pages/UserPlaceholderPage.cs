namespace BromoAirlines.Forms.Users.Pages;

public partial class UserPlaceholderPage : Form
{
    public UserPlaceholderPage()
    {
        InitializeComponent();
    }

    public UserPlaceholderPage(string title)
        : this()
    {
        SetTitle(title);
    }

    public void SetTitle(string title)
    {
        lblTitle.Text = title;
    }
}
