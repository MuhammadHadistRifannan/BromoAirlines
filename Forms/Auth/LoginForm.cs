using BromoAirlines.Models;
using BromoAirlines.Services;
using System.Drawing.Drawing2D;

namespace BromoAirlines.Forms;

public partial class LoginForm : Form
{
    private readonly AuthService _authService = new();

    public event EventHandler<Akun>? LoginSucceeded;
    public event EventHandler? RegisterRequested;

    public LoginForm()
    {
        InitializeComponent();
    }


    private void LoginButton_Click(object? sender, EventArgs e)
    {
        var result = _authService.Login(usernameTextBox.Text, passwordTextBox.Text);
        messageLabel.Text = result.Message;
        messageLabel.ForeColor = result.IsSuccess ? Color.SeaGreen : Color.Firebrick;

        if (!result.IsSuccess || result.Akun is null)
        {
            return;
        }

        LoginSucceeded?.Invoke(this, result.Akun);
    }



    private void LoginForm_Load(object sender, EventArgs e)
    {

    }

    private void usernameTextBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void daftar_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        RegisterRequested?.Invoke(this, EventArgs.Empty);
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        LoginButton_Click(sender, e);
    }
}
