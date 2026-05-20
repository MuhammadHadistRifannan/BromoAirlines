using BromoAirlines.Forms;

namespace BromoAirlines;

internal sealed class BromoApplicationContext : ApplicationContext
{
    public BromoApplicationContext()
    {
        ShowSplash();
    }

    private void ShowSplash()
    {
        var splash = new SplashForm();
        splash.SplashCompleted += (_, _) =>
        {
            splash.Close();
            ShowLogin();
        };
        splash.Show();
    }

    private void ShowLogin()
    {
        var login = new LoginForm();
        login.FormClosed += (_, _) =>
        {
            if (Application.OpenForms.Count == 0)
            {
                ExitThread();
            }
        };
        login.LoginSucceeded += (_, user) =>
        {
            Form nextForm = user.MerupakanAdmin
                ? new DashboardForm(user)
                : new CustomerMainForm(user);

            nextForm.FormClosed += (_, _) => ShowLogin();
            nextForm.Show();
            login.Close();
        };
        login.Show();
    }
}
