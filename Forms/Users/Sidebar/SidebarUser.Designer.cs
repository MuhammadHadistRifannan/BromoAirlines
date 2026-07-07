namespace BromoAirlines.Forms.Users.Sidebar;

partial class SidebarUser
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
        lblBrand = new Label();
        pbLogo = new PictureBox();
        lblMenu = new Label();
        panelMenu = new FlowLayoutPanel();
        btnHome = new Button();
        btnSearchFlight = new Button();
        btnMyTicket = new Button();
        btnHistory = new Button();
        btnProfile = new Button();
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
        panelBrand.Controls.Add(lblBrand);
        panelBrand.Controls.Add(pbLogo);
        panelBrand.Dock = DockStyle.Top;
        panelBrand.Location = new Point(32, 24);
        panelBrand.Name = "panelBrand";
        panelBrand.Size = new Size(256, 230);
        panelBrand.TabIndex = 0;
        // 
        // lblBrand
        // 
        lblBrand.Dock = DockStyle.Top;
        lblBrand.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblBrand.ForeColor = Color.White;
        lblBrand.Location = new Point(0, 120);
        lblBrand.Name = "lblBrand";
        lblBrand.Size = new Size(256, 70);
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
        pbLogo.Size = new Size(256, 120);
        pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
        pbLogo.TabIndex = 0;
        pbLogo.TabStop = false;
        // 
        // lblMenu
        // 
        lblMenu.Dock = DockStyle.Top;
        lblMenu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblMenu.ForeColor = Color.White;
        lblMenu.Location = new Point(32, 254);
        lblMenu.Name = "lblMenu";
        lblMenu.Size = new Size(256, 42);
        lblMenu.TabIndex = 1;
        lblMenu.Text = "Menu User";
        lblMenu.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // panelMenu
        // 
        panelMenu.Controls.Add(btnHome);
        panelMenu.Controls.Add(btnSearchFlight);
        panelMenu.Controls.Add(btnMyTicket);
        panelMenu.Controls.Add(btnHistory);
        panelMenu.Controls.Add(btnProfile);
        panelMenu.Dock = DockStyle.Top;
        panelMenu.FlowDirection = FlowDirection.TopDown;
        panelMenu.Location = new Point(32, 296);
        panelMenu.Name = "panelMenu";
        panelMenu.Size = new Size(256, 330);
        panelMenu.TabIndex = 2;
        panelMenu.WrapContents = false;
        // 
        // btnHome
        // 
        btnHome.BackColor = Color.RoyalBlue;
        btnHome.Cursor = Cursors.Hand;
        btnHome.FlatAppearance.BorderColor = Color.White;
        btnHome.FlatAppearance.BorderSize = 0;
        btnHome.FlatStyle = FlatStyle.Flat;
        btnHome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnHome.ForeColor = Color.White;
        btnHome.Location = new Point(0, 0);
        btnHome.Margin = new Padding(0, 0, 0, 8);
        btnHome.Name = "btnHome";
        btnHome.Size = new Size(256, 45);
        btnHome.TabIndex = 0;
        btnHome.Text = "Home";
        btnHome.TextAlign = ContentAlignment.MiddleLeft;
        btnHome.UseVisualStyleBackColor = false;
        btnHome.Click += MenuHomeClick;
        // 
        // btnSearchFlight
        // 
        btnSearchFlight.BackColor = Color.RoyalBlue;
        btnSearchFlight.Cursor = Cursors.Hand;
        btnSearchFlight.FlatAppearance.BorderColor = Color.White;
        btnSearchFlight.FlatAppearance.BorderSize = 0;
        btnSearchFlight.FlatStyle = FlatStyle.Flat;
        btnSearchFlight.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnSearchFlight.ForeColor = Color.White;
        btnSearchFlight.Location = new Point(0, 53);
        btnSearchFlight.Margin = new Padding(0, 0, 0, 8);
        btnSearchFlight.Name = "btnSearchFlight";
        btnSearchFlight.Size = new Size(256, 45);
        btnSearchFlight.TabIndex = 1;
        btnSearchFlight.Text = "Cari Penerbangan";
        btnSearchFlight.TextAlign = ContentAlignment.MiddleLeft;
        btnSearchFlight.UseVisualStyleBackColor = false;
        btnSearchFlight.Click += MenuSearchFlightClick;
        // 
        // btnMyTicket
        // 
        btnMyTicket.BackColor = Color.RoyalBlue;
        btnMyTicket.Cursor = Cursors.Hand;
        btnMyTicket.FlatAppearance.BorderColor = Color.White;
        btnMyTicket.FlatAppearance.BorderSize = 0;
        btnMyTicket.FlatStyle = FlatStyle.Flat;
        btnMyTicket.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnMyTicket.ForeColor = Color.White;
        btnMyTicket.Location = new Point(0, 106);
        btnMyTicket.Margin = new Padding(0, 0, 0, 8);
        btnMyTicket.Name = "btnMyTicket";
        btnMyTicket.Size = new Size(256, 45);
        btnMyTicket.TabIndex = 2;
        btnMyTicket.Text = "Tiket Saya";
        btnMyTicket.TextAlign = ContentAlignment.MiddleLeft;
        btnMyTicket.UseVisualStyleBackColor = false;
        btnMyTicket.Click += MenuMyTicketClick;
        // 
        // btnHistory
        // 
        btnHistory.BackColor = Color.RoyalBlue;
        btnHistory.Cursor = Cursors.Hand;
        btnHistory.FlatAppearance.BorderColor = Color.White;
        btnHistory.FlatAppearance.BorderSize = 0;
        btnHistory.FlatStyle = FlatStyle.Flat;
        btnHistory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnHistory.ForeColor = Color.White;
        btnHistory.Location = new Point(0, 159);
        btnHistory.Margin = new Padding(0, 0, 0, 8);
        btnHistory.Name = "btnHistory";
        btnHistory.Size = new Size(256, 45);
        btnHistory.TabIndex = 3;
        btnHistory.Text = "Riwayat";
        btnHistory.TextAlign = ContentAlignment.MiddleLeft;
        btnHistory.UseVisualStyleBackColor = false;
        btnHistory.Click += MenuHistoryClick;
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
        btnProfile.Location = new Point(0, 212);
        btnProfile.Margin = new Padding(0, 0, 0, 8);
        btnProfile.Name = "btnProfile";
        btnProfile.Size = new Size(256, 45);
        btnProfile.TabIndex = 4;
        btnProfile.Text = "Profil";
        btnProfile.TextAlign = ContentAlignment.MiddleLeft;
        btnProfile.UseVisualStyleBackColor = false;
        btnProfile.Click += MenuProfileClick;
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
        btnLogout.FlatAppearance.BorderColor = Color.White;
        btnLogout.FlatAppearance.BorderSize = 0;
        btnLogout.FlatStyle = FlatStyle.Flat;
        btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnLogout.ForeColor = Color.White;
        btnLogout.Location = new Point(0, 55);
        btnLogout.Margin = new Padding(0);
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
        // SidebarUser
        // 
        BackColor = Color.RoyalBlue;
        Controls.Add(panelAccount);
        Controls.Add(panelMenu);
        Controls.Add(lblMenu);
        Controls.Add(panelBrand);
        Name = "SidebarUser";
        Padding = new Padding(32, 24, 32, 24);
        Size = new Size(320, 1050);
        panelBrand.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
        panelMenu.ResumeLayout(false);
        panelAccount.ResumeLayout(false);
        ResumeLayout(false);
    }

    private Panel panelBrand;
    private Label lblBrand;
    private PictureBox pbLogo;
    private Label lblMenu;
    private FlowLayoutPanel panelMenu;
    private Button btnHome;
    private Button btnSearchFlight;
    private Button btnMyTicket;
    private Button btnHistory;
    private Button btnProfile;
    private Panel panelAccount;
    private Button btnLogout;
    private Label lblAccount;
}
