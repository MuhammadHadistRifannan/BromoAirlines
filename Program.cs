using BromoAirlines.Forms;
using BromoAirlines.Forms.AirlineAdmin.Sidebar;
using BromoAirlines.Forms.Sidebar;
using BromoAirlines.Forms.Users.Sidebar;
using BromoAirlines.Models;
using BromoAirlines.Repositories;

namespace BromoAirlines;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new AuthApplicationContext());
    }

    private sealed class AuthApplicationContext : ApplicationContext
    {
        private LoginForm? _loginForm;
        private RegisterForm? _registerForm;
        private Form? _dashboardForm;
        private readonly AdminMaskapaiRepository _adminMaskapaiRepository = new();
        private bool _isSwitchingForms;

        public AuthApplicationContext()
        {
            ShowLogin();
        }

        private void ShowLogin(string message = "")
        {
            _isSwitchingForms = true;
            CloseRegisterForm();
            _loginForm = new LoginForm();
            _loginForm.LoginSucceeded += LoginSucceeded;
            _loginForm.RegisterRequested += RegisterRequested;
            _loginForm.FormClosed += LoginFormClosed;
            _loginForm.Show();
            _isSwitchingForms = false;

            if (!string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show(message, "BromoAirlines", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ShowRegister()
        {
            _isSwitchingForms = true;
            CloseLoginForm();
            _registerForm = new RegisterForm();
            _registerForm.LoginRequested += RegisterLoginRequested;
            _registerForm.RegisterSucceeded += RegisterSucceeded;
            _registerForm.FormClosed += RegisterFormClosed;
            _registerForm.Show();
            _isSwitchingForms = false;
        }

        private void ShowDashboard(Akun akun)
        {
            _isSwitchingForms = true;
            try
            {
                _dashboardForm = CreateDashboard(akun);
            }
            catch
            {
                _isSwitchingForms = false;
                ShowLogin("Login admin maskapai belum dapat diproses. Periksa data mapping admin maskapai.");
                return;
            }

            if (_dashboardForm is null)
            {
                _isSwitchingForms = false;
                ShowLogin("Akun admin maskapai belum terhubung dengan data maskapai.");
                return;
            }

            _dashboardForm.FormClosed += DashboardFormClosed;
            CloseLoginForm();
            _dashboardForm.Show();
            _isSwitchingForms = false;
        }

        private Form? CreateDashboard(Akun akun)
        {
            if (akun.IsAdminMaster)
            {
                return new DashboardForm();
            }

            if (akun.IsAdminMaskapai)
            {
                var mapping = _adminMaskapaiRepository.FindByUserId(akun.ID);
                return mapping is null
                    ? null
                    : new DashboardMaskapaiForm(akun, mapping.MaskapaiID);
            }

            return new DashboardUserForm(akun);
        }

        private void LoginSucceeded(object? sender, Akun akun)
        {
            ShowDashboard(akun);
        }

        private void RegisterRequested(object? sender, EventArgs e)
        {
            ShowRegister();
        }

        private void RegisterLoginRequested(object? sender, EventArgs e)
        {
            ShowLogin();
        }

        private void RegisterSucceeded(object? sender, string message)
        {
            ShowLogin(message);
        }

        private void DashboardFormClosed(object? sender, EventArgs e)
        {
            _dashboardForm = null;
            ShowLogin();
        }

        private void LoginFormClosed(object? sender, EventArgs e)
        {
            if (!_isSwitchingForms && _dashboardForm is null && _registerForm is null)
            {
                ExitThread();
            }
        }

        private void RegisterFormClosed(object? sender, EventArgs e)
        {
            if (!_isSwitchingForms && _loginForm is null && _dashboardForm is null)
            {
                ExitThread();
            }
        }

        private void CloseLoginForm()
        {
            if (_loginForm is null)
            {
                return;
            }

            _loginForm.LoginSucceeded -= LoginSucceeded;
            _loginForm.RegisterRequested -= RegisterRequested;
            _loginForm.FormClosed -= LoginFormClosed;
            var form = _loginForm;
            _loginForm = null;
            form.Close();
        }

        private void CloseRegisterForm()
        {
            if (_registerForm is null)
            {
                return;
            }

            _registerForm.LoginRequested -= RegisterLoginRequested;
            _registerForm.RegisterSucceeded -= RegisterSucceeded;
            _registerForm.FormClosed -= RegisterFormClosed;
            var form = _registerForm;
            _registerForm = null;
            form.Close();
        }
    }
}
