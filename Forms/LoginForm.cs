using BromoAirlines.Models;
using BromoAirlines.Services;
using System.Drawing.Drawing2D;

namespace BromoAirlines.Forms;

public partial class LoginForm : Form
{
    private readonly AuthService _authService = new();

    public event EventHandler<Akun>? LoginSucceeded;

    public LoginForm()
    {
        InitializeComponent();
    }


    private void LoginButton_Click(object? sender, EventArgs e)
    {
        var user = _authService.Login(usernameTextBox.Text, passwordTextBox.Text);
        if (user is null)
        {
            messageLabel.Text = "Username atau password tidak valid.";
            return;
        }

        LoginSucceeded?.Invoke(this, user);
    }



    private void LoginForm_Load(object sender, EventArgs e)
    {

    }

    private void usernameTextBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void daftar_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        RegisterForm register = new RegisterForm();

        register.FormClosed += (s, args) => this.Close();

        register.Show();

        this.Hide();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        var form = new DashboardForm();
        this.Hide();
        form.Show();
    }
}
