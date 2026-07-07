namespace BromoAirlines.Forms.Sidebar
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            panelContent = new Panel();
            btnDashboard = new Button();
            btnMasterJadwalPenerbangan = new Button();
            btnMasterBandara = new Button();
            btnProfile = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnLogout = new Button();
            label1 = new Label();
            label2 = new Label();
            btnMasterMaskapai = new Button();
            btnMasterKodePromo = new Button();
            btnStatusPenerbangan = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.BackColor = SystemColors.Control;
            panelContent.Dock = DockStyle.Right;
            panelContent.Location = new Point(360, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1335, 1050);
            panelContent.TabIndex = 0;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.RoyalBlue;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderColor = Color.White;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(46, 380);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(273, 45);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += MenuDashboardClick;
            // 
            // btnMasterBandara
            // 
            btnMasterBandara.BackColor = Color.RoyalBlue;
            btnMasterBandara.Cursor = Cursors.Hand;
            btnMasterBandara.FlatAppearance.BorderColor = Color.White;
            btnMasterBandara.FlatAppearance.BorderSize = 0;
            btnMasterBandara.FlatStyle = FlatStyle.Flat;
            btnMasterBandara.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMasterBandara.ForeColor = Color.White;
            btnMasterBandara.Location = new Point(46, 433);
            btnMasterBandara.Name = "btnMasterBandara";
            btnMasterBandara.Size = new Size(273, 45);
            btnMasterBandara.TabIndex = 2;
            btnMasterBandara.Text = "Master Bandara";
            btnMasterBandara.TextAlign = ContentAlignment.MiddleLeft;
            btnMasterBandara.UseVisualStyleBackColor = false;
            btnMasterBandara.Click += MenuBandaraClick;
            // 
            // btnMasterMaskapai
            // 
            btnMasterMaskapai.BackColor = Color.RoyalBlue;
            btnMasterMaskapai.Cursor = Cursors.Hand;
            btnMasterMaskapai.FlatAppearance.BorderColor = Color.White;
            btnMasterMaskapai.FlatAppearance.BorderSize = 0;
            btnMasterMaskapai.FlatStyle = FlatStyle.Flat;
            btnMasterMaskapai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMasterMaskapai.ForeColor = Color.White;
            btnMasterMaskapai.Location = new Point(46, 486);
            btnMasterMaskapai.Name = "btnMasterMaskapai";
            btnMasterMaskapai.Size = new Size(273, 45);
            btnMasterMaskapai.TabIndex = 3;
            btnMasterMaskapai.Text = "Master Maskapai";
            btnMasterMaskapai.TextAlign = ContentAlignment.MiddleLeft;
            btnMasterMaskapai.UseVisualStyleBackColor = false;
            btnMasterMaskapai.Click += MenuMaskapaiClick;
            // 
            // btnMasterJadwalPenerbangan
            // 
            btnMasterJadwalPenerbangan.BackColor = Color.RoyalBlue;
            btnMasterJadwalPenerbangan.Cursor = Cursors.Hand;
            btnMasterJadwalPenerbangan.FlatAppearance.BorderColor = Color.White;
            btnMasterJadwalPenerbangan.FlatAppearance.BorderSize = 0;
            btnMasterJadwalPenerbangan.FlatStyle = FlatStyle.Flat;
            btnMasterJadwalPenerbangan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMasterJadwalPenerbangan.ForeColor = Color.White;
            btnMasterJadwalPenerbangan.Location = new Point(46, 539);
            btnMasterJadwalPenerbangan.Name = "btnMasterJadwalPenerbangan";
            btnMasterJadwalPenerbangan.Size = new Size(273, 45);
            btnMasterJadwalPenerbangan.TabIndex = 4;
            btnMasterJadwalPenerbangan.Text = "Master Jadwal Penerbangan";
            btnMasterJadwalPenerbangan.TextAlign = ContentAlignment.MiddleLeft;
            btnMasterJadwalPenerbangan.UseVisualStyleBackColor = false;
            btnMasterJadwalPenerbangan.Click += MenuJadwalPenerbanganClick;
            // 
            // btnMasterKodePromo
            // 
            btnMasterKodePromo.BackColor = Color.RoyalBlue;
            btnMasterKodePromo.Cursor = Cursors.Hand;
            btnMasterKodePromo.FlatAppearance.BorderColor = Color.White;
            btnMasterKodePromo.FlatAppearance.BorderSize = 0;
            btnMasterKodePromo.FlatStyle = FlatStyle.Flat;
            btnMasterKodePromo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMasterKodePromo.ForeColor = Color.White;
            btnMasterKodePromo.Location = new Point(46, 592);
            btnMasterKodePromo.Name = "btnMasterKodePromo";
            btnMasterKodePromo.Size = new Size(273, 45);
            btnMasterKodePromo.TabIndex = 5;
            btnMasterKodePromo.Text = "Master Kode Promo";
            btnMasterKodePromo.TextAlign = ContentAlignment.MiddleLeft;
            btnMasterKodePromo.UseVisualStyleBackColor = false;
            btnMasterKodePromo.Click += MenuKodePromoClick;
            // 
            // btnStatusPenerbangan
            // 
            btnStatusPenerbangan.BackColor = Color.RoyalBlue;
            btnStatusPenerbangan.Cursor = Cursors.Hand;
            btnStatusPenerbangan.FlatAppearance.BorderColor = Color.White;
            btnStatusPenerbangan.FlatAppearance.BorderSize = 0;
            btnStatusPenerbangan.FlatStyle = FlatStyle.Flat;
            btnStatusPenerbangan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnStatusPenerbangan.ForeColor = Color.White;
            btnStatusPenerbangan.Location = new Point(46, 645);
            btnStatusPenerbangan.Name = "btnStatusPenerbangan";
            btnStatusPenerbangan.Size = new Size(273, 45);
            btnStatusPenerbangan.TabIndex = 6;
            btnStatusPenerbangan.Text = "Ubah Status Penerbangan";
            btnStatusPenerbangan.TextAlign = ContentAlignment.MiddleLeft;
            btnStatusPenerbangan.UseVisualStyleBackColor = false;
            btnStatusPenerbangan.Click += MenuStatusPenerbanganClick;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.RoyalBlue;
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.FlatAppearance.BorderColor = Color.White;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(46, 745);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(273, 45);
            btnProfile.TabIndex = 7;
            btnProfile.Text = "Profile";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += MenuProfileClick;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Firebrick;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderColor = Color.White;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(46, 798);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(273, 45);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += MenuLogoutClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(66, 185);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(253, 152);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 340);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 11;
            label1.Text = "Menu Admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 715);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 12;
            label2.Text = "Akun";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1695, 1050);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnProfile);
            Controls.Add(btnStatusPenerbangan);
            Controls.Add(btnMasterKodePromo);
            Controls.Add(btnMasterJadwalPenerbangan);
            Controls.Add(btnMasterMaskapai);
            Controls.Add(btnMasterBandara);
            Controls.Add(btnDashboard);
            Controls.Add(panelContent);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelContent;
        private Button btnDashboard;
        private Button btnMasterBandara;
        private Button btnMasterMaskapai;
        private Button btnMasterJadwalPenerbangan;
        private Button btnMasterKodePromo;
        private Button btnStatusPenerbangan;
        private Button btnProfile;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
    }
}