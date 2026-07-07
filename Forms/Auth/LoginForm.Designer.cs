
namespace BromoAirlines.Forms;

partial class LoginForm
{
    private System.ComponentModel.IContainer components = null!;
    private Panel loginCard = null!;
    private PictureBox logoPictureBox = null!;
    private Label titleLabel = null!;
    private TextBox usernameTextBox = null!;
    private TextBox passwordTextBox = null!;
    private Button loginButton = null!;
    private Label messageLabel = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            components?.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
        loginCard = new Panel();
        pictureBox3 = new PictureBox();
        daftar_link = new LinkLabel();
        label1 = new Label();
        button1 = new Button();
        pictureBox2 = new PictureBox();
        pictureBox1 = new PictureBox();
        titleLabel = new Label();
        usernameTextBox = new TextBox();
        passwordTextBox = new TextBox();
        messageLabel = new Label();
        loginCard.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // loginCard
        // 
        loginCard.BackColor = Color.White;
        loginCard.Controls.Add(pictureBox3);
        loginCard.Controls.Add(daftar_link);
        loginCard.Controls.Add(label1);
        loginCard.Controls.Add(button1);
        loginCard.Controls.Add(pictureBox2);
        loginCard.Controls.Add(pictureBox1);
        loginCard.Controls.Add(titleLabel);
        loginCard.Controls.Add(usernameTextBox);
        loginCard.Controls.Add(passwordTextBox);
        loginCard.Controls.Add(messageLabel);
        loginCard.Location = new Point(102, 2);
        loginCard.Margin = new Padding(3, 4, 3, 4);
        loginCard.Name = "loginCard";
        loginCard.Size = new Size(782, 667);
        loginCard.TabIndex = 0;
        // 
        // pictureBox3
        // 
        pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
        pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
        pictureBox3.Location = new Point(20, 56);
        pictureBox3.Margin = new Padding(2);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(268, 232);
        pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox3.TabIndex = 11;
        pictureBox3.TabStop = false;
        // 
        // daftar_link
        // 
        daftar_link.AutoSize = true;
        daftar_link.Font = new Font("Segoe UI", 10F);
        daftar_link.Location = new Point(464, 566);
        daftar_link.Margin = new Padding(2, 0, 2, 0);
        daftar_link.Name = "daftar_link";
        daftar_link.Size = new Size(101, 23);
        daftar_link.TabIndex = 10;
        daftar_link.TabStop = true;
        daftar_link.Text = "Daftar disini";
        daftar_link.LinkClicked += daftar_link_LinkClicked;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 10F);
        label1.Location = new Point(272, 564);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(207, 23);
        label1.TabIndex = 9;
        label1.Text = "Belum mempunyai akun?.";
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 14F);
        button1.Location = new Point(365, 488);
        button1.Margin = new Padding(2);
        button1.Name = "button1";
        button1.Size = new Size(114, 46);
        button1.TabIndex = 8;
        button1.Text = "Masuk";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // pictureBox2
        // 
        pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
        pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
        pictureBox2.Location = new Point(274, 40);
        pictureBox2.Margin = new Padding(2);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(506, 257);
        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox2.TabIndex = 7;
        pictureBox2.TabStop = false;
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImageLayout = ImageLayout.Center;
        pictureBox1.Dock = DockStyle.Top;
        pictureBox1.Location = new Point(0, 0);
        pictureBox1.Margin = new Padding(2);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(782, 297);
        pictureBox1.TabIndex = 6;
        pictureBox1.TabStop = false;
        pictureBox1.Click += pictureBox1_Click;
        // 
        // titleLabel
        // 
        titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        titleLabel.ForeColor = Color.FromArgb(31, 41, 55);
        titleLabel.Location = new Point(216, 299);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(434, 65);
        titleLabel.TabIndex = 1;
        titleLabel.Text = "Masuk Akun";
        titleLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // usernameTextBox
        // 
        usernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
        usernameTextBox.Font = new Font("Segoe UI", 12F);
        usernameTextBox.Location = new Point(272, 368);
        usernameTextBox.Margin = new Padding(3, 4, 3, 4);
        usernameTextBox.Name = "usernameTextBox";
        usernameTextBox.PlaceholderText = "Username";
        usernameTextBox.Size = new Size(324, 34);
        usernameTextBox.TabIndex = 2;
        usernameTextBox.TextAlign = HorizontalAlignment.Center;
        usernameTextBox.TextChanged += usernameTextBox_TextChanged;
        // 
        // passwordTextBox
        // 
        passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
        passwordTextBox.Font = new Font("Segoe UI", 12F);
        passwordTextBox.Location = new Point(272, 429);
        passwordTextBox.Margin = new Padding(3, 4, 3, 4);
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.PlaceholderText = "Password";
        passwordTextBox.Size = new Size(324, 34);
        passwordTextBox.TabIndex = 3;
        passwordTextBox.TextAlign = HorizontalAlignment.Center;
        passwordTextBox.UseSystemPasswordChar = true;
        // 
        // messageLabel
        // 
        messageLabel.ForeColor = Color.Firebrick;
        messageLabel.Location = new Point(48, 488);
        messageLabel.Name = "messageLabel";
        messageLabel.Size = new Size(338, 46);
        messageLabel.TabIndex = 5;
        messageLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1017, 679);
        Controls.Add(loginCard);
        DoubleBuffered = true;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimumSize = new Size(978, 725);
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login - Bromo Airlines";
        Load += LoginForm_Load;
        loginCard.ResumeLayout(false);
        loginCard.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private PictureBox pictureBox1;
    private PictureBox pictureBox2;
    private Button button1;
    private LinkLabel daftar_link;
    private Label label1;
    private PictureBox pictureBox3;
}
