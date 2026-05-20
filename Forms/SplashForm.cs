using System.Drawing.Drawing2D;

namespace BromoAirlines.Forms;

public partial class SplashForm : Form
{
    public event EventHandler? SplashCompleted;

    public SplashForm()
    {
        InitializeComponent();
    }

    private void SplashTimer_Tick(object? sender, EventArgs e)
    {
        splashTimer.Stop();
        SplashCompleted?.Invoke(this, EventArgs.Empty);
    }

    private void SplashForm_Shown(object? sender, EventArgs e)
    {
        splashTimer.Start();
    }

}
