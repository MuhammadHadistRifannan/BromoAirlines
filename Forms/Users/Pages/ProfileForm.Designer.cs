namespace BromoAirlines.Forms
{
    partial class FormProfileAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            pbIconProfile = new PictureBox();
            gbDataProfile = new GroupBox();
            lblID = new Label();
            txtID = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblNama = new Label();
            txtNama = new TextBox();
            lblTanggalLahir = new Label();
            dtpTanggalLahir = new DateTimePicker();
            lblNomorTelepon = new Label();
            txtNomorTelepon = new TextBox();
            lblRole = new Label();
            txtRole = new TextBox();
            pbProfile = new PictureBox();
            btnUbahFoto = new Button();
            lblFormatFoto = new Label();
            gbUbahPassword = new GroupBox();
            lblPasswordLama = new Label();
            txtPasswordLama = new TextBox();
            lblPasswordBaru = new Label();
            txtPasswordBaru = new TextBox();
            lblKonfirmasiPassword = new Label();
            txtKonfirmasiPasssword = new TextBox();
            panel1 = new Panel();
            lblInfoTitle = new Label();
            lblInfoPassword = new Label();
            label1 = new Label();
            pnlButton = new Panel();
            btnSimpan = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)pbIconProfile).BeginInit();
            gbDataProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            gbUbahPassword.SuspendLayout();
            panel1.SuspendLayout();
            pnlButton.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(100, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(368, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "PROFILE - ADMIN";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(105, 70);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(358, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Kelola informasi akun dan ubah password";
            // 
            // pbIconProfile
            // 
            pbIconProfile.Location = new Point(30, 25);
            pbIconProfile.Name = "pbIconProfile";
            pbIconProfile.Size = new Size(60, 60);
            pbIconProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pbIconProfile.TabIndex = 2;
            pbIconProfile.TabStop = false;
            // 
            // panelLineTop
            // 
            // 
            // gbDataProfile
            // 
            gbDataProfile.Controls.Add(btnUbahFoto);
            gbDataProfile.Controls.Add(lblFormatFoto);
            gbDataProfile.Controls.Add(pbProfile);
            gbDataProfile.Controls.Add(txtRole);
            gbDataProfile.Controls.Add(lblRole);
            gbDataProfile.Controls.Add(txtNomorTelepon);
            gbDataProfile.Controls.Add(lblNomorTelepon);
            gbDataProfile.Controls.Add(dtpTanggalLahir);
            gbDataProfile.Controls.Add(lblTanggalLahir);
            gbDataProfile.Controls.Add(txtNama);
            gbDataProfile.Controls.Add(lblNama);
            gbDataProfile.Controls.Add(txtUsername);
            gbDataProfile.Controls.Add(lblUsername);
            gbDataProfile.Controls.Add(txtID);
            gbDataProfile.Controls.Add(lblID);
            gbDataProfile.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDataProfile.ForeColor = Color.Navy;
            gbDataProfile.Location = new Point(30, 140);
            gbDataProfile.Name = "gbDataProfile";
            gbDataProfile.Size = new Size(1130, 330);
            gbDataProfile.TabIndex = 4;
            gbDataProfile.TabStop = false;
            gbDataProfile.Text = "Data Profile";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.ForeColor = Color.Black;
            lblID.Location = new Point(17, 37);
            lblID.Name = "lblID";
            lblID.Size = new Size(74, 23);
            lblID.TabIndex = 0;
            lblID.Text = "ID Akun";
            // 
            // txtID
            // 
            txtID.Location = new Point(250, 45);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(360, 27);
            txtID.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(17, 92);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(92, 23);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(250, 88);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(160, 27);
            txtUsername.TabIndex = 3;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNama.ForeColor = Color.Black;
            lblNama.Location = new Point(17, 140);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(132, 23);
            lblNama.TabIndex = 4;
            lblNama.Text = "Nama Lengkap";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(250, 135);
            txtNama.Name = "txtNama";
            txtNama.ReadOnly = true;
            txtNama.Size = new Size(360, 27);
            txtNama.TabIndex = 5;
            // 
            // lblTanggalLahir
            // 
            lblTanggalLahir.AutoSize = true;
            lblTanggalLahir.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTanggalLahir.ForeColor = Color.Black;
            lblTanggalLahir.Location = new Point(17, 184);
            lblTanggalLahir.Name = "lblTanggalLahir";
            lblTanggalLahir.Size = new Size(119, 23);
            lblTanggalLahir.TabIndex = 6;
            lblTanggalLahir.Text = "Tanggal Lahir";
            lblTanggalLahir.Click += lblTanggalLahir_Click;
            // 
            // dtpTanggalLahir
            // 
            dtpTanggalLahir.Format = DateTimePickerFormat.Short;
            dtpTanggalLahir.Location = new Point(250, 180);
            dtpTanggalLahir.Name = "dtpTanggalLahir";
            dtpTanggalLahir.Size = new Size(360, 27);
            dtpTanggalLahir.TabIndex = 7;
            // 
            // lblNomorTelepon
            // 
            lblNomorTelepon.AutoSize = true;
            lblNomorTelepon.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomorTelepon.ForeColor = Color.Black;
            lblNomorTelepon.Location = new Point(17, 230);
            lblNomorTelepon.Name = "lblNomorTelepon";
            lblNomorTelepon.Size = new Size(140, 23);
            lblNomorTelepon.TabIndex = 8;
            lblNomorTelepon.Text = "Nomor Telepon";
            // 
            // txtNomorTelepon
            // 
            txtNomorTelepon.Location = new Point(250, 225);
            txtNomorTelepon.Name = "txtNomorTelepon";
            txtNomorTelepon.ReadOnly = true;
            txtNomorTelepon.Size = new Size(360, 27);
            txtNomorTelepon.TabIndex = 9;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.Black;
            lblRole.Location = new Point(30, 275);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(47, 23);
            lblRole.TabIndex = 10;
            lblRole.Text = "Role";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(250, 270);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(360, 27);
            txtRole.TabIndex = 11;
            // 
            // pbProfile
            // 
            pbProfile.BackColor = Color.AliceBlue;
            pbProfile.Location = new Point(819, 45);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(170, 170);
            pbProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProfile.TabIndex = 5;
            pbProfile.TabStop = false;
            pbProfile.Click += pbProfile_Click;
            // 
            // btnUbahFoto
            // 
            btnUbahFoto.Location = new Point(805, 222);
            btnUbahFoto.Name = "btnUbahFoto";
            btnUbahFoto.Size = new Size(210, 40);
            btnUbahFoto.TabIndex = 6;
            btnUbahFoto.Text = "Ubah Foto";
            btnUbahFoto.UseVisualStyleBackColor = true;
            // 
            // lblFormatFoto
            // 
            lblFormatFoto.AutoSize = true;
            lblFormatFoto.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFormatFoto.ForeColor = Color.Gray;
            lblFormatFoto.Location = new Point(776, 275);
            lblFormatFoto.Name = "lblFormatFoto";
            lblFormatFoto.Size = new Size(275, 23);
            lblFormatFoto.TabIndex = 12;
            lblFormatFoto.Text = "Format JPG/PNG, maksimal 2MB";
            // 
            // gbUbahPassword
            // 
            gbUbahPassword.Controls.Add(panel1);
            gbUbahPassword.Controls.Add(txtKonfirmasiPasssword);
            gbUbahPassword.Controls.Add(lblKonfirmasiPassword);
            gbUbahPassword.Controls.Add(txtPasswordBaru);
            gbUbahPassword.Controls.Add(lblPasswordBaru);
            gbUbahPassword.Controls.Add(txtPasswordLama);
            gbUbahPassword.Controls.Add(lblPasswordLama);
            gbUbahPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbUbahPassword.ForeColor = Color.Navy;
            gbUbahPassword.Location = new Point(30, 490);
            gbUbahPassword.Name = "gbUbahPassword";
            gbUbahPassword.Size = new Size(1130, 160);
            gbUbahPassword.TabIndex = 7;
            gbUbahPassword.TabStop = false;
            gbUbahPassword.Text = "Ubah Password";
            // 
            // lblPasswordLama
            // 
            lblPasswordLama.AutoSize = true;
            lblPasswordLama.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPasswordLama.ForeColor = Color.Black;
            lblPasswordLama.Location = new Point(17, 32);
            lblPasswordLama.Name = "lblPasswordLama";
            lblPasswordLama.Size = new Size(134, 23);
            lblPasswordLama.TabIndex = 13;
            lblPasswordLama.Text = "Password Lama";
            // 
            // txtPasswordLama
            // 
            txtPasswordLama.Location = new Point(250, 32);
            txtPasswordLama.Name = "txtPasswordLama";
            txtPasswordLama.PasswordChar = '*';
            txtPasswordLama.ReadOnly = true;
            txtPasswordLama.Size = new Size(360, 27);
            txtPasswordLama.TabIndex = 13;
            // 
            // lblPasswordBaru
            // 
            lblPasswordBaru.AutoSize = true;
            lblPasswordBaru.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPasswordBaru.ForeColor = Color.Black;
            lblPasswordBaru.Location = new Point(17, 74);
            lblPasswordBaru.Name = "lblPasswordBaru";
            lblPasswordBaru.Size = new Size(127, 23);
            lblPasswordBaru.TabIndex = 14;
            lblPasswordBaru.Text = "Password Baru";
            // 
            // txtPasswordBaru
            // 
            txtPasswordBaru.Location = new Point(250, 80);
            txtPasswordBaru.Name = "txtPasswordBaru";
            txtPasswordBaru.PasswordChar = '*';
            txtPasswordBaru.ReadOnly = true;
            txtPasswordBaru.Size = new Size(360, 27);
            txtPasswordBaru.TabIndex = 15;
            // 
            // lblKonfirmasiPassword
            // 
            lblKonfirmasiPassword.AutoSize = true;
            lblKonfirmasiPassword.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKonfirmasiPassword.ForeColor = Color.Black;
            lblKonfirmasiPassword.Location = new Point(17, 124);
            lblKonfirmasiPassword.Name = "lblKonfirmasiPassword";
            lblKonfirmasiPassword.Size = new Size(178, 23);
            lblKonfirmasiPassword.TabIndex = 16;
            lblKonfirmasiPassword.Text = "Konfirmasi Password";
            // 
            // txtKonfirmasiPasssword
            // 
            txtKonfirmasiPasssword.Location = new Point(250, 120);
            txtKonfirmasiPasssword.Name = "txtKonfirmasiPasssword";
            txtKonfirmasiPasssword.PasswordChar = '*';
            txtKonfirmasiPasssword.ReadOnly = true;
            txtKonfirmasiPasssword.Size = new Size(360, 27);
            txtKonfirmasiPasssword.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblInfoTitle);
            panel1.Controls.Add(lblInfoPassword);
            panel1.Location = new Point(766, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 108);
            panel1.TabIndex = 18;
            // 
            // lblInfoTitle
            // 
            lblInfoTitle.AutoSize = true;
            lblInfoTitle.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoTitle.ForeColor = Color.Navy;
            lblInfoTitle.Location = new Point(10, 13);
            lblInfoTitle.Name = "lblInfoTitle";
            lblInfoTitle.Size = new Size(86, 23);
            lblInfoTitle.TabIndex = 19;
            lblInfoTitle.Text = "Informasi";
            // 
            // lblInfoPassword
            // 
            lblInfoPassword.AutoSize = true;
            lblInfoPassword.Font = new Font("Microsoft YaHei Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoPassword.ForeColor = Color.Black;
            lblInfoPassword.Location = new Point(10, 51);
            lblInfoPassword.Name = "lblInfoPassword";
            lblInfoPassword.Size = new Size(241, 19);
            lblInfoPassword.TabIndex = 20;
            lblInfoPassword.Text = "Password baru minimal 6 karakter dan.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(10, 70);
            label1.Name = "label1";
            label1.Size = new Size(242, 19);
            label1.TabIndex = 21;
            label1.Text = "harus berbeda dengan password lama.";
            // 
            // pnlButton
            // 
            pnlButton.Controls.Add(btnReset);
            pnlButton.Controls.Add(btnSimpan);
            pnlButton.Location = new Point(30, 656);
            pnlButton.Name = "pnlButton";
            pnlButton.Size = new Size(1130, 64);
            pnlButton.TabIndex = 8;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.DodgerBlue;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(419, 3);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(220, 40);
            btnSimpan.TabIndex = 9;
            btnSimpan.Text = "Simpan Perubahan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.WhiteSmoke;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(663, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(130, 40);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // FormProfileAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 703);
            Controls.Add(pnlButton);
            Controls.Add(gbUbahPassword);
            Controls.Add(gbDataProfile);
            Controls.Add(pbIconProfile);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormProfileAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile - Admin";
            ((System.ComponentModel.ISupportInitialize)pbIconProfile).EndInit();
            gbDataProfile.ResumeLayout(false);
            gbDataProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            gbUbahPassword.ResumeLayout(false);
            gbUbahPassword.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlButton.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private PictureBox pbIconProfile;
        private GroupBox gbDataProfile;
        private Label lblID;
        private TextBox txtID;
        private Label lblNama;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblTanggalLahir;
        private TextBox txtNama;
        private DateTimePicker dtpTanggalLahir;
        private TextBox txtNomorTelepon;
        private Label lblNomorTelepon;
        private TextBox txtRole;
        private Label lblRole;
        private PictureBox pbProfile;
        private Label lblFormatFoto;
        private Button btnUbahFoto;
        private GroupBox gbUbahPassword;
        private TextBox txtPasswordLama;
        private Label lblPasswordLama;
        private TextBox txtKonfirmasiPasssword;
        private Label lblKonfirmasiPassword;
        private TextBox txtPasswordBaru;
        private Label lblPasswordBaru;
        private Panel panel1;
        private Label lblInfoTitle;
        private Label lblInfoPassword;
        private Label label1;
        private Panel pnlButton;
        private Button btnSimpan;
        private Button btnReset;
    }
}