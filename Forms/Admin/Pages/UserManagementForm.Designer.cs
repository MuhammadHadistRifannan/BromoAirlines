namespace BromoAirlines.Forms
{
    partial class UserManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            gbUser = new GroupBox();
            chkMerupakanAdmin = new CheckBox();
            dtpTanggalLahir = new DateTimePicker();
            lblTanggalLahir = new Label();
            txtNomorTelepon = new TextBox();
            lblNomorTelepon = new Label();
            txtNama = new TextBox();
            lblNama = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            btnReset = new Button();
            btnHapus = new Button();
            btnEdit = new Button();
            btnTambah = new Button();
            lblDaftarUser = new Label();
            txtCariUser = new TextBox();
            dgvUser = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            TanggalLahir = new DataGridViewTextBoxColumn();
            NomorTelepon = new DataGridViewTextBoxColumn();
            MerupakanAdmin = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            gbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(560, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "USER MANAGEMENT - ADMIN";
            // 
            // gbUser
            // 
            gbUser.Controls.Add(chkMerupakanAdmin);
            gbUser.Controls.Add(dtpTanggalLahir);
            gbUser.Controls.Add(lblTanggalLahir);
            gbUser.Controls.Add(txtNomorTelepon);
            gbUser.Controls.Add(lblNomorTelepon);
            gbUser.Controls.Add(txtNama);
            gbUser.Controls.Add(lblNama);
            gbUser.Controls.Add(txtPassword);
            gbUser.Controls.Add(lblPassword);
            gbUser.Controls.Add(txtUsername);
            gbUser.Controls.Add(lblUsername);
            gbUser.Controls.Add(btnReset);
            gbUser.Controls.Add(btnHapus);
            gbUser.Controls.Add(btnEdit);
            gbUser.Controls.Add(btnTambah);
            gbUser.Location = new Point(20, 90);
            gbUser.Name = "gbUser";
            gbUser.Size = new Size(1140, 270);
            gbUser.TabIndex = 1;
            gbUser.TabStop = false;
            gbUser.Text = "Data User";
            // 
            // chkMerupakanAdmin
            // 
            chkMerupakanAdmin.AutoSize = true;
            chkMerupakanAdmin.Location = new Point(650, 150);
            chkMerupakanAdmin.Name = "chkMerupakanAdmin";
            chkMerupakanAdmin.Size = new Size(154, 29);
            chkMerupakanAdmin.TabIndex = 11;
            chkMerupakanAdmin.Text = "Administrator";
            chkMerupakanAdmin.UseVisualStyleBackColor = true;
            // 
            // dtpTanggalLahir
            // 
            dtpTanggalLahir.CustomFormat = "dd/MM/yyyy";
            dtpTanggalLahir.Format = DateTimePickerFormat.Custom;
            dtpTanggalLahir.Location = new Point(650, 50);
            dtpTanggalLahir.Name = "dtpTanggalLahir";
            dtpTanggalLahir.Size = new Size(180, 31);
            dtpTanggalLahir.TabIndex = 7;
            // 
            // lblTanggalLahir
            // 
            lblTanggalLahir.AutoSize = true;
            lblTanggalLahir.Location = new Point(500, 50);
            lblTanggalLahir.Name = "lblTanggalLahir";
            lblTanggalLahir.Size = new Size(122, 25);
            lblTanggalLahir.TabIndex = 6;
            lblTanggalLahir.Text = "Tanggal Lahir:";
            // 
            // txtNomorTelepon
            // 
            txtNomorTelepon.BorderStyle = BorderStyle.FixedSingle;
            txtNomorTelepon.Location = new Point(650, 100);
            txtNomorTelepon.MaxLength = 20;
            txtNomorTelepon.Name = "txtNomorTelepon";
            txtNomorTelepon.Size = new Size(260, 31);
            txtNomorTelepon.TabIndex = 9;
            // 
            // lblNomorTelepon
            // 
            lblNomorTelepon.AutoSize = true;
            lblNomorTelepon.Location = new Point(500, 100);
            lblNomorTelepon.Name = "lblNomorTelepon";
            lblNomorTelepon.Size = new Size(134, 25);
            lblNomorTelepon.TabIndex = 8;
            lblNomorTelepon.Text = "Nomor Telepon:";
            // 
            // txtNama
            // 
            txtNama.BorderStyle = BorderStyle.FixedSingle;
            txtNama.Location = new Point(160, 150);
            txtNama.MaxLength = 200;
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(280, 31);
            txtNama.TabIndex = 5;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(30, 150);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(62, 25);
            lblNama.TabIndex = 4;
            lblNama.Text = "Nama:";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(160, 100);
            txtPassword.MaxLength = 200;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 31);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(30, 100);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 25);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(160, 50);
            txtUsername.MaxLength = 200;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(280, 31);
            txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(30, 50);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(95, 25);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Azure;
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.Gray;
            btnReset.Location = new Point(980, 210);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(110, 40);
            btnReset.TabIndex = 15;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Crimson;
            btnHapus.Cursor = Cursors.Hand;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(850, 210);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(110, 40);
            btnHapus.TabIndex = 14;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.ForestGreen;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(720, 210);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 40);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.DodgerBlue;
            btnTambah.Cursor = Cursors.Hand;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(590, 210);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(110, 40);
            btnTambah.TabIndex = 12;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // lblDaftarUser
            // 
            lblDaftarUser.AutoSize = true;
            lblDaftarUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblDaftarUser.ForeColor = Color.Navy;
            lblDaftarUser.Location = new Point(20, 380);
            lblDaftarUser.Name = "lblDaftarUser";
            lblDaftarUser.Size = new Size(124, 25);
            lblDaftarUser.TabIndex = 2;
            lblDaftarUser.Text = "Daftar User";
            // 
            // txtCariUser
            // 
            txtCariUser.BorderStyle = BorderStyle.FixedSingle;
            txtCariUser.Location = new Point(910, 375);
            txtCariUser.Name = "txtCariUser";
            txtCariUser.PlaceholderText = "Cari User.....";
            txtCariUser.Size = new Size(250, 31);
            txtCariUser.TabIndex = 3;
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { ID, Username, Password, Nama, TanggalLahir, NomorTelepon, MerupakanAdmin, Role });
            dgvUser.Location = new Point(20, 420);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersVisible = false;
            dgvUser.RowHeadersWidth = 51;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Size = new Size(1140, 265);
            dgvUser.TabIndex = 4;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.Visible = false;
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama";
            Nama.MinimumWidth = 6;
            Nama.Name = "Nama";
            Nama.ReadOnly = true;
            // 
            // TanggalLahir
            // 
            TanggalLahir.HeaderText = "Tanggal Lahir";
            TanggalLahir.MinimumWidth = 6;
            TanggalLahir.Name = "TanggalLahir";
            TanggalLahir.ReadOnly = true;
            // 
            // NomorTelepon
            // 
            NomorTelepon.HeaderText = "Nomor Telepon";
            NomorTelepon.MinimumWidth = 6;
            NomorTelepon.Name = "NomorTelepon";
            NomorTelepon.ReadOnly = true;
            // 
            // MerupakanAdmin
            // 
            MerupakanAdmin.HeaderText = "MerupakanAdmin";
            MerupakanAdmin.MinimumWidth = 6;
            MerupakanAdmin.Name = "MerupakanAdmin";
            MerupakanAdmin.ReadOnly = true;
            MerupakanAdmin.Visible = false;
            // 
            // Role
            // 
            Role.HeaderText = "Role";
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            Role.ReadOnly = true;
            // 
            // UserManagementForm
            // 
            AutoScroll = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1182, 715);
            Controls.Add(dgvUser);
            Controls.Add(txtCariUser);
            Controls.Add(lblDaftarUser);
            Controls.Add(gbUser);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.8F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserManagementForm";
            Text = "UserManagementForm";
            gbUser.ResumeLayout(false);
            gbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private GroupBox gbUser;
        private CheckBox chkMerupakanAdmin;
        private DateTimePicker dtpTanggalLahir;
        private Label lblTanggalLahir;
        private TextBox txtNomorTelepon;
        private Label lblNomorTelepon;
        private TextBox txtNama;
        private Label lblNama;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private Button btnReset;
        private Button btnHapus;
        private Button btnEdit;
        private Button btnTambah;
        private Label lblDaftarUser;
        private TextBox txtCariUser;
        private DataGridView dgvUser;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn TanggalLahir;
        private DataGridViewTextBoxColumn NomorTelepon;
        private DataGridViewTextBoxColumn MerupakanAdmin;
        private DataGridViewTextBoxColumn Role;
    }
}
