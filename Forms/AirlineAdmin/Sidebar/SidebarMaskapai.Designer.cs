namespace BromoAirlines.Forms.AirlineAdmin.Sidebar;

partial class SidebarMaskapai
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
        panelBrand = new Panel();
        lblRole = new Label();
        lblBrand = new Label();
        pbLogo = new PictureBox();
        lblMenu = new Label();
        panelMenu = new FlowLayoutPanel();
        btnDashboard = new Button();
        btnJadwalPenerbangan = new Button();
        btnKodePromo = new Button();
        btnLaporanTransaksi = new Button();
        panelAccount = new Panel();
        btnLogout = new Button();
        lblAccount = new Label();
        panelBrand.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
        panelMenu.SuspendLayout();
        panelAccount.SuspendLayout();
        SuspendLayout();
        // 
        // panelBrand
        // 
        panelBrand.Controls.Add(lblRole);
        panelBrand.Controls.Add(lblBrand);
        panelBrand.Controls.Add(pbLogo);
        panelBrand.Dock = DockStyle.Top;
        panelBrand.Location = new Point(32, 24);
        panelBrand.Name = "panelBrand";
        panelBrand.Size = new Size(256, 236);
        panelBrand.TabIndex = 0;
        // 
        // lblRole
        // 
        lblRole.Dock = DockStyle.Top;
        lblRole.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblRole.ForeColor = Color.WhiteSmoke;
        lblRole.Location = new Point(0, 178);
        lblRole.Name = "lblRole";
        lblRole.Size = new Size(256, 36);
        lblRole.TabIndex = 2;
        lblRole.Text = "Maskapai Admin";
        lblRole.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblBrand
        // 
        lblBrand.Dock = DockStyle.Top;
        lblBrand.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblBrand.ForeColor = Color.White;
        lblBrand.Location = new Point(0, 116);
        lblBrand.Name = "lblBrand";
        lblBrand.Size = new Size(256, 62);
        lblBrand.TabIndex = 1;
        lblBrand.Text = "BromoAirlines";
        lblBrand.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pbLogo
        // 
        pbLogo.Dock = DockStyle.Top;
        pbLogo.ImageLocation = "Assets\\white-logo.png";
        pbLogo.Location = new Point(0, 0);
        pbLogo.Name = "pbLogo";
        pbLogo.Size = new Size(256, 116);
        pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
        pbLogo.TabIndex = 0;
        pbLogo.TabStop = false;
        // 
        // lblMenu
        // 
        lblMenu.Dock = DockStyle.Top;
        lblMenu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblMenu.ForeColor = Color.White;
        lblMenu.Location = new Point(32, 260);
        lblMenu.Name = "lblMenu";
        lblMenu.Size = new Size(256, 42);
        lblMenu.TabIndex = 1;
        lblMenu.Text = "Menu Maskapai";
        lblMenu.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // panelMenu
        // 
        panelMenu.Controls.Add(btnDashboard);
        panelMenu.Controls.Add(btnJadwalPenerbangan);
        panelMenu.Controls.Add(btnKodePromo);
        panelMenu.Controls.Add(btnLaporanTransaksi);
        panelMenu.Dock = DockStyle.Top;
        panelMenu.FlowDirection = FlowDirection.TopDown;
        panelMenu.Location = new Point(32, 302);
        panelMenu.Name = "panelMenu";
        panelMenu.Size = new Size(256, 260);
        panelMenu.TabIndex = 2;
        panelMenu.WrapContents = false;
        // 
        // btnDashboard
        // 
        btnDashboard.BackColor = Color.RoyalBlue;
        btnDashboard.Cursor = Cursors.Hand;
        btnDashboard.FlatAppearance.BorderSize = 0;
        btnDashboard.FlatStyle = FlatStyle.Flat;
        btnDashboard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnDashboard.ForeColor = Color.White;
        btnDashboard.Location = new Point(0, 0);
        btnDashboard.Margin = new Padding(0, 0, 0, 8);
        btnDashboard.Name = "btnDashboard";
        btnDashboard.Size = new Size(256, 45);
        btnDashboard.TabIndex = 0;
        btnDashboard.Text = "Dashboard";
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
        btnDashboard.UseVisualStyleBackColor = false;
        btnDashboard.Click += MenuDashboardClick;
        // 
        // btnJadwalPenerbangan
        // 
        btnJadwalPenerbangan.BackColor = Color.RoyalBlue;
        btnJadwalPenerbangan.Cursor = Cursors.Hand;
        btnJadwalPenerbangan.FlatAppearance.BorderSize = 0;
        btnJadwalPenerbangan.FlatStyle = FlatStyle.Flat;
        btnJadwalPenerbangan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnJadwalPenerbangan.ForeColor = Color.White;
        btnJadwalPenerbangan.Location = new Point(0, 53);
        btnJadwalPenerbangan.Margin = new Padding(0, 0, 0, 8);
        btnJadwalPenerbangan.Name = "btnJadwalPenerbangan";
        btnJadwalPenerbangan.Size = new Size(256, 45);
        btnJadwalPenerbangan.TabIndex = 1;
        btnJadwalPenerbangan.Text = "Jadwal Penerbangan";
        btnJadwalPenerbangan.TextAlign = ContentAlignment.MiddleLeft;
        btnJadwalPenerbangan.UseVisualStyleBackColor = false;
        btnJadwalPenerbangan.Click += MenuJadwalPenerbanganClick;
        // 
        // btnKodePromo
        // 
        btnKodePromo.BackColor = Color.RoyalBlue;
        btnKodePromo.Cursor = Cursors.Hand;
        btnKodePromo.FlatAppearance.BorderSize = 0;
        btnKodePromo.FlatStyle = FlatStyle.Flat;
        btnKodePromo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnKodePromo.ForeColor = Color.White;
        btnKodePromo.Location = new Point(0, 106);
        btnKodePromo.Margin = new Padding(0, 0, 0, 8);
        btnKodePromo.Name = "btnKodePromo";
        btnKodePromo.Size = new Size(256, 45);
        btnKodePromo.TabIndex = 2;
        btnKodePromo.Text = "Kode Promo";
        btnKodePromo.TextAlign = ContentAlignment.MiddleLeft;
        btnKodePromo.UseVisualStyleBackColor = false;
        btnKodePromo.Click += MenuKodePromoClick;
        // 
        // btnLaporanTransaksi
        // 
        btnLaporanTransaksi.BackColor = Color.RoyalBlue;
        btnLaporanTransaksi.Cursor = Cursors.Hand;
        btnLaporanTransaksi.FlatAppearance.BorderSize = 0;
        btnLaporanTransaksi.FlatStyle = FlatStyle.Flat;
        btnLaporanTransaksi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnLaporanTransaksi.ForeColor = Color.White;
        btnLaporanTransaksi.Location = new Point(0, 159);
        btnLaporanTransaksi.Margin = new Padding(0, 0, 0, 8);
        btnLaporanTransaksi.Name = "btnLaporanTransaksi";
        btnLaporanTransaksi.Size = new Size(256, 45);
        btnLaporanTransaksi.TabIndex = 3;
        btnLaporanTransaksi.Text = "Laporan Transaksi";
        btnLaporanTransaksi.TextAlign = ContentAlignment.MiddleLeft;
        btnLaporanTransaksi.UseVisualStyleBackColor = false;
        btnLaporanTransaksi.Click += MenuLaporanTransaksiClick;
        // 
        // panelAccount
        // 
        panelAccount.Controls.Add(btnLogout);
        panelAccount.Controls.Add(lblAccount);
        panelAccount.Dock = DockStyle.Bottom;
        panelAccount.Location = new Point(32, 926);
        panelAccount.Name = "panelAccount";
        panelAccount.Size = new Size(256, 100);
        panelAccount.TabIndex = 3;
        // 
        // btnLogout
        // 
        btnLogout.BackColor = Color.Firebrick;
        btnLogout.Cursor = Cursors.Hand;
        btnLogout.Dock = DockStyle.Bottom;
        btnLogout.FlatAppearance.BorderSize = 0;
        btnLogout.FlatStyle = FlatStyle.Flat;
        btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnLogout.ForeColor = Color.White;
        btnLogout.Location = new Point(0, 55);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new Size(256, 45);
        btnLogout.TabIndex = 1;
        btnLogout.Text = "Logout";
        btnLogout.TextAlign = ContentAlignment.MiddleLeft;
        btnLogout.UseVisualStyleBackColor = false;
        btnLogout.Click += MenuLogoutClick;
        // 
        // lblAccount
        // 
        lblAccount.Dock = DockStyle.Top;
        lblAccount.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblAccount.ForeColor = Color.White;
        lblAccount.Location = new Point(0, 0);
        lblAccount.Name = "lblAccount";
        lblAccount.Size = new Size(256, 38);
        lblAccount.TabIndex = 0;
        lblAccount.Text = "Akun";
        lblAccount.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SidebarMaskapai
        // 
        BackColor = Color.RoyalBlue;
        Controls.Add(panelAccount);
        Controls.Add(panelMenu);
        Controls.Add(lblMenu);
        Controls.Add(panelBrand);
        Name = "SidebarMaskapai";
        Padding = new Padding(32, 24, 32, 24);
        Size = new Size(320, 1050);
        panelBrand.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
        panelMenu.ResumeLayout(false);
        panelAccount.ResumeLayout(false);
        ResumeLayout(false);
    }

    private Panel panelBrand;
    private Label lblRole;
    private Label lblBrand;
    private PictureBox pbLogo;
    private Label lblMenu;
    private FlowLayoutPanel panelMenu;
    private Button btnDashboard;
    private Button btnJadwalPenerbangan;
    private Button btnKodePromo;
    private Button btnLaporanTransaksi;
    private Panel panelAccount;
    private Button btnLogout;
    private Label lblAccount;
}
