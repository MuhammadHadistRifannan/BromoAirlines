namespace BromoAirlines.Forms.Users.Pages;

partial class ProfileUserForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitle = new Label();
        panelSummary = new Panel();
        lblSummaryDescription = new Label();
        lblSummaryTitle = new Label();
        panelContent = new Panel();
        panelProfile = new Panel();
        txtEmail = new TextBox();
        lblEmail = new Label();
        txtUsername = new TextBox();
        lblUsername = new Label();
        txtNama = new TextBox();
        lblNama = new Label();
        panelPassword = new Panel();
        txtKonfirmasiPassword = new TextBox();
        lblKonfirmasiPassword = new Label();
        txtPasswordBaru = new TextBox();
        lblPasswordBaru = new Label();
        txtPasswordLama = new TextBox();
        lblPasswordLama = new Label();
        lblPasswordTitle = new Label();
        btnEditProfile = new Button();
        btnGantiPassword = new Button();
        btnSimpan = new Button();
        btnReset = new Button();
        lblStatus = new Label();
        panelSummary.SuspendLayout();
        panelProfile.SuspendLayout();
        panelPassword.SuspendLayout();
        panelContent.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        lblTitle.ForeColor = Color.Navy;
        lblTitle.Location = new Point(48, 42);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(125, 54);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Profil";
        // 
        // panelSummary
        // 
        panelSummary.BackColor = Color.RoyalBlue;
        panelSummary.Controls.Add(lblSummaryDescription);
        panelSummary.Controls.Add(lblSummaryTitle);
        panelSummary.Location = new Point(48, 124);
        panelSummary.Name = "panelSummary";
        panelSummary.Padding = new Padding(32);
        panelSummary.Size = new Size(1220, 150);
        panelSummary.TabIndex = 1;
        // 
        // lblSummaryDescription
        // 
        lblSummaryDescription.Font = new Font("Segoe UI", 14F);
        lblSummaryDescription.ForeColor = Color.White;
        lblSummaryDescription.Location = new Point(32, 82);
        lblSummaryDescription.Name = "lblSummaryDescription";
        lblSummaryDescription.Size = new Size(900, 38);
        lblSummaryDescription.TabIndex = 1;
        lblSummaryDescription.Text = "Kelola informasi akun, edit profile, dan ganti password.";
        // 
        // lblSummaryTitle
        // 
        lblSummaryTitle.AutoSize = true;
        lblSummaryTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblSummaryTitle.ForeColor = Color.White;
        lblSummaryTitle.Location = new Point(32, 24);
        lblSummaryTitle.Name = "lblSummaryTitle";
        lblSummaryTitle.Size = new Size(250, 50);
        lblSummaryTitle.TabIndex = 0;
        lblSummaryTitle.Text = "Profile Akun";
        // 
        // panelProfile
        // 
        panelProfile.BackColor = Color.White;
        panelProfile.Controls.Add(txtEmail);
        panelProfile.Controls.Add(lblEmail);
        panelProfile.Controls.Add(txtUsername);
        panelProfile.Controls.Add(lblUsername);
        panelProfile.Controls.Add(txtNama);
        panelProfile.Controls.Add(lblNama);
        panelProfile.Location = new Point(48, 318);
        panelProfile.Name = "panelProfile";
        panelProfile.Padding = new Padding(32);
        panelProfile.Size = new Size(1220, 250);
        panelProfile.TabIndex = 2;
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(326, 170);
        txtEmail.Name = "txtEmail";
        txtEmail.ReadOnly = true;
        txtEmail.Size = new Size(520, 27);
        txtEmail.TabIndex = 5;
        txtEmail.Text = "user@bromoairlines.test";
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblEmail.ForeColor = Color.Navy;
        lblEmail.Location = new Point(32, 166);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(61, 28);
        lblEmail.TabIndex = 4;
        lblEmail.Text = "Email";
        // 
        // txtUsername
        // 
        txtUsername.Location = new Point(326, 108);
        txtUsername.Name = "txtUsername";
        txtUsername.ReadOnly = true;
        txtUsername.Size = new Size(360, 27);
        txtUsername.TabIndex = 3;
        txtUsername.Text = "user";
        // 
        // lblUsername
        // 
        lblUsername.AutoSize = true;
        lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblUsername.ForeColor = Color.Navy;
        lblUsername.Location = new Point(32, 104);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(106, 28);
        lblUsername.TabIndex = 2;
        lblUsername.Text = "Username";
        // 
        // txtNama
        // 
        txtNama.Location = new Point(326, 46);
        txtNama.Name = "txtNama";
        txtNama.ReadOnly = true;
        txtNama.Size = new Size(520, 27);
        txtNama.TabIndex = 1;
        txtNama.Text = "User BromoAirlines";
        // 
        // lblNama
        // 
        lblNama.AutoSize = true;
        lblNama.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblNama.ForeColor = Color.Navy;
        lblNama.Location = new Point(32, 42);
        lblNama.Name = "lblNama";
        lblNama.Size = new Size(67, 28);
        lblNama.TabIndex = 0;
        lblNama.Text = "Nama";
        // 
        // panelPassword
        // 
        panelPassword.BackColor = Color.White;
        panelPassword.Controls.Add(txtKonfirmasiPassword);
        panelPassword.Controls.Add(lblKonfirmasiPassword);
        panelPassword.Controls.Add(txtPasswordBaru);
        panelPassword.Controls.Add(lblPasswordBaru);
        panelPassword.Controls.Add(txtPasswordLama);
        panelPassword.Controls.Add(lblPasswordLama);
        panelPassword.Controls.Add(lblPasswordTitle);
        panelPassword.Location = new Point(48, 604);
        panelPassword.Name = "panelPassword";
        panelPassword.Padding = new Padding(32);
        panelPassword.Size = new Size(1220, 230);
        panelPassword.TabIndex = 3;
        // 
        // txtKonfirmasiPassword
        // 
        txtKonfirmasiPassword.Location = new Point(326, 158);
        txtKonfirmasiPassword.Name = "txtKonfirmasiPassword";
        txtKonfirmasiPassword.PasswordChar = '*';
        txtKonfirmasiPassword.ReadOnly = true;
        txtKonfirmasiPassword.Size = new Size(360, 27);
        txtKonfirmasiPassword.TabIndex = 6;
        // 
        // lblKonfirmasiPassword
        // 
        lblKonfirmasiPassword.AutoSize = true;
        lblKonfirmasiPassword.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblKonfirmasiPassword.ForeColor = Color.Navy;
        lblKonfirmasiPassword.Location = new Point(32, 156);
        lblKonfirmasiPassword.Name = "lblKonfirmasiPassword";
        lblKonfirmasiPassword.Size = new Size(197, 25);
        lblKonfirmasiPassword.TabIndex = 5;
        lblKonfirmasiPassword.Text = "Konfirmasi Password";
        // 
        // txtPasswordBaru
        // 
        txtPasswordBaru.Location = new Point(326, 111);
        txtPasswordBaru.Name = "txtPasswordBaru";
        txtPasswordBaru.PasswordChar = '*';
        txtPasswordBaru.ReadOnly = true;
        txtPasswordBaru.Size = new Size(360, 27);
        txtPasswordBaru.TabIndex = 4;
        // 
        // lblPasswordBaru
        // 
        lblPasswordBaru.AutoSize = true;
        lblPasswordBaru.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblPasswordBaru.ForeColor = Color.Navy;
        lblPasswordBaru.Location = new Point(32, 109);
        lblPasswordBaru.Name = "lblPasswordBaru";
        lblPasswordBaru.Size = new Size(141, 25);
        lblPasswordBaru.TabIndex = 3;
        lblPasswordBaru.Text = "Password Baru";
        // 
        // txtPasswordLama
        // 
        txtPasswordLama.Location = new Point(326, 64);
        txtPasswordLama.Name = "txtPasswordLama";
        txtPasswordLama.PasswordChar = '*';
        txtPasswordLama.ReadOnly = true;
        txtPasswordLama.Size = new Size(360, 27);
        txtPasswordLama.TabIndex = 2;
        // 
        // lblPasswordLama
        // 
        lblPasswordLama.AutoSize = true;
        lblPasswordLama.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblPasswordLama.ForeColor = Color.Navy;
        lblPasswordLama.Location = new Point(32, 62);
        lblPasswordLama.Name = "lblPasswordLama";
        lblPasswordLama.Size = new Size(146, 25);
        lblPasswordLama.TabIndex = 1;
        lblPasswordLama.Text = "Password Lama";
        // 
        // lblPasswordTitle
        // 
        lblPasswordTitle.AutoSize = true;
        lblPasswordTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblPasswordTitle.ForeColor = Color.Navy;
        lblPasswordTitle.Location = new Point(32, 20);
        lblPasswordTitle.Name = "lblPasswordTitle";
        lblPasswordTitle.Size = new Size(187, 32);
        lblPasswordTitle.TabIndex = 0;
        lblPasswordTitle.Text = "Ganti Password";
        // 
        // btnEditProfile
        // 
        btnEditProfile.BackColor = Color.RoyalBlue;
        btnEditProfile.Cursor = Cursors.Hand;
        btnEditProfile.FlatAppearance.BorderSize = 0;
        btnEditProfile.FlatStyle = FlatStyle.Flat;
        btnEditProfile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnEditProfile.ForeColor = Color.White;
        btnEditProfile.Location = new Point(48, 870);
        btnEditProfile.Name = "btnEditProfile";
        btnEditProfile.Size = new Size(170, 50);
        btnEditProfile.TabIndex = 4;
        btnEditProfile.Text = "Edit Profile";
        btnEditProfile.UseVisualStyleBackColor = false;
        btnEditProfile.Click += BtnEditProfileClick;
        // 
        // btnGantiPassword
        // 
        btnGantiPassword.BackColor = Color.RoyalBlue;
        btnGantiPassword.Cursor = Cursors.Hand;
        btnGantiPassword.FlatAppearance.BorderSize = 0;
        btnGantiPassword.FlatStyle = FlatStyle.Flat;
        btnGantiPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnGantiPassword.ForeColor = Color.White;
        btnGantiPassword.Location = new Point(236, 870);
        btnGantiPassword.Name = "btnGantiPassword";
        btnGantiPassword.Size = new Size(190, 50);
        btnGantiPassword.TabIndex = 5;
        btnGantiPassword.Text = "Ganti Password";
        btnGantiPassword.UseVisualStyleBackColor = false;
        btnGantiPassword.Click += BtnGantiPasswordClick;
        // 
        // btnSimpan
        // 
        btnSimpan.BackColor = Color.SeaGreen;
        btnSimpan.Cursor = Cursors.Hand;
        btnSimpan.FlatAppearance.BorderSize = 0;
        btnSimpan.FlatStyle = FlatStyle.Flat;
        btnSimpan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnSimpan.ForeColor = Color.White;
        btnSimpan.Location = new Point(910, 870);
        btnSimpan.Name = "btnSimpan";
        btnSimpan.Size = new Size(170, 50);
        btnSimpan.TabIndex = 6;
        btnSimpan.Text = "Simpan";
        btnSimpan.UseVisualStyleBackColor = false;
        btnSimpan.Click += BtnSimpanClick;
        // 
        // btnReset
        // 
        btnReset.BackColor = Color.White;
        btnReset.Cursor = Cursors.Hand;
        btnReset.FlatAppearance.BorderColor = Color.RoyalBlue;
        btnReset.FlatStyle = FlatStyle.Flat;
        btnReset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnReset.ForeColor = Color.RoyalBlue;
        btnReset.Location = new Point(1098, 870);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(170, 50);
        btnReset.TabIndex = 7;
        btnReset.Text = "Reset";
        btnReset.UseVisualStyleBackColor = false;
        btnReset.Click += BtnResetClick;
        // 
        // lblStatus
        // 
        lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblStatus.ForeColor = Color.DimGray;
        lblStatus.Location = new Point(48, 936);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(780, 32);
        lblStatus.TabIndex = 8;
        lblStatus.Text = "Profile siap dilihat.";
        // 
        // panelContent
        // 
        panelContent.AutoScroll = true;
        panelContent.Controls.Add(lblStatus);
        panelContent.Controls.Add(btnReset);
        panelContent.Controls.Add(btnSimpan);
        panelContent.Controls.Add(btnGantiPassword);
        panelContent.Controls.Add(btnEditProfile);
        panelContent.Controls.Add(panelPassword);
        panelContent.Controls.Add(panelProfile);
        panelContent.Controls.Add(panelSummary);
        panelContent.Controls.Add(lblTitle);
        panelContent.Dock = DockStyle.Fill;
        panelContent.Location = new Point(0, 0);
        panelContent.Name = "panelContent";
        panelContent.Size = new Size(1375, 1050);
        panelContent.TabIndex = 9;
        // 
        // ProfileUserForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1375, 1050);
        Controls.Add(panelContent);
        FormBorderStyle = FormBorderStyle.None;
        Name = "ProfileUserForm";
        Text = "Profil";
        panelSummary.ResumeLayout(false);
        panelSummary.PerformLayout();
        panelProfile.ResumeLayout(false);
        panelProfile.PerformLayout();
        panelPassword.ResumeLayout(false);
        panelPassword.PerformLayout();
        panelContent.ResumeLayout(false);
        panelContent.PerformLayout();
        ResumeLayout(false);
    }

    private Label lblTitle;
    private Panel panelSummary;
    private Label lblSummaryTitle;
    private Label lblSummaryDescription;
    private Panel panelContent;
    private Panel panelProfile;
    private Label lblNama;
    private TextBox txtNama;
    private TextBox txtUsername;
    private Label lblUsername;
    private TextBox txtEmail;
    private Label lblEmail;
    private Panel panelPassword;
    private Label lblPasswordTitle;
    private TextBox txtPasswordLama;
    private Label lblPasswordLama;
    private TextBox txtPasswordBaru;
    private Label lblPasswordBaru;
    private TextBox txtKonfirmasiPassword;
    private Label lblKonfirmasiPassword;
    private Button btnEditProfile;
    private Button btnGantiPassword;
    private Button btnSimpan;
    private Button btnReset;
    private Label lblStatus;
}
