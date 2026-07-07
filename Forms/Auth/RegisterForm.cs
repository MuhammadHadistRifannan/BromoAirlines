using BromoAirlines.Services;

namespace BromoAirlines.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly AuthService _authService = new();

        public event EventHandler? LoginRequested;
        public event EventHandler<string>? RegisterSucceeded;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void masuk_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginRequested?.Invoke(this, EventArgs.Empty);
        }

        private async void ButtonDaftarClick(object sender, EventArgs e)
        {
            var result = await _authService.RegisterAsync(
                nama_lengkapTextbox.Text,
                usernameTextBox.Text,
                passwordTextBox.Text,
                confirmPw_textBox.Text,
                tanggalLahir_Textbox.Value,
                Telepon_Textbox.Text);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "BromoAirlines", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RegisterSucceeded?.Invoke(this, result.Message);
        }
    }
}
