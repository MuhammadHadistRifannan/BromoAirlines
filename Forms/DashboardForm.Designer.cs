
namespace BromoAirlines.Forms;

partial class DashboardForm
{
    private System.ComponentModel.IContainer components = null!;
    private Panel sidebarPanel = null!;
    private PictureBox logoPictureBox = null!;
    private Button dashboardButton = null!;
    private Button masterBandaraButton = null!;
    private Button masterMaskapaiButton = null!;
    private Button masterJadwalButton = null!;
    private Button masterPromoButton = null!;
    private Button masterStatusButton = null!;
    private Panel headerPanel = null!;
    private Label headerTitleLabel = null!;
    private Label userLabel = null!;
    private Panel contentPanel = null!;

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
        components = new System.ComponentModel.Container();
        sidebarPanel = new Panel();
        dashboardButton = CreateSidebarButton("Dashboard", 132);
        masterBandaraButton = CreateSidebarButton("Master Bandara", 182);
        masterMaskapaiButton = CreateSidebarButton("Master Maskapai", 232);
        masterJadwalButton = CreateSidebarButton("Jadwal Penerbangan", 282);
        masterPromoButton = CreateSidebarButton("Kode Promo", 332);
        masterStatusButton = CreateSidebarButton("Status Penerbangan", 382);
        headerPanel = new Panel();
        headerTitleLabel = new Label();
        userLabel = new Label();
        contentPanel = new Panel();
        sidebarPanel.SuspendLayout();
        headerPanel.SuspendLayout();
        SuspendLayout();

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1200, 760);
        MinimumSize = new Size(1100, 700);
        Name = "DashboardForm";
        Text = "Dashboard - Bromo Airlines";
        WindowState = FormWindowState.Maximized;

        sidebarPanel.Controls.Add(logoPictureBox);
        sidebarPanel.Controls.Add(dashboardButton);
        sidebarPanel.Controls.Add(masterBandaraButton);
        sidebarPanel.Controls.Add(masterMaskapaiButton);
        sidebarPanel.Controls.Add(masterJadwalButton);
        sidebarPanel.Controls.Add(masterPromoButton);
        sidebarPanel.Controls.Add(masterStatusButton);
        sidebarPanel.Dock = DockStyle.Left;
        sidebarPanel.Name = "sidebarPanel";
        sidebarPanel.Size = new Size(260, 760);
        sidebarPanel.TabIndex = 0;

        logoPictureBox.Location = new Point(34, 24);
        logoPictureBox.Name = "logoPictureBox";
        logoPictureBox.TabIndex = 0;
        logoPictureBox.TabStop = false;

        headerPanel.BackColor = Color.White;
        headerPanel.Controls.Add(headerTitleLabel);
        headerPanel.Controls.Add(userLabel);
        headerPanel.Dock = DockStyle.Top;
        headerPanel.Name = "headerPanel";
        headerPanel.Padding = new Padding(24, 0, 24, 0);
        headerPanel.Size = new Size(940, 78);
        headerPanel.TabIndex = 1;

        headerTitleLabel.Dock = DockStyle.Fill;
        headerTitleLabel.Name = "headerTitleLabel";
        headerTitleLabel.TabIndex = 0;
        headerTitleLabel.Text = "Dashboard";
        headerTitleLabel.TextAlign = ContentAlignment.MiddleLeft;

        userLabel.Dock = DockStyle.Right;
        userLabel.Name = "userLabel";
        userLabel.Size = new Size(240, 78);
        userLabel.TabIndex = 1;
        userLabel.Text = "Admin";
        userLabel.TextAlign = ContentAlignment.MiddleRight;

        contentPanel.Dock = DockStyle.Fill;
        contentPanel.Name = "contentPanel";
        contentPanel.Size = new Size(940, 682);
        contentPanel.TabIndex = 2;

        Controls.Add(contentPanel);
        Controls.Add(headerPanel);
        Controls.Add(sidebarPanel);
        sidebarPanel.ResumeLayout(false);
        headerPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    private static Button CreateSidebarButton(string text, int top)
    {
        var button = new Button
        {
            Cursor = Cursors.Hand,
            FlatStyle = FlatStyle.Flat,
            ForeColor = Color.White,
            Location = new Point(18, top),
            Size = new Size(224, 40),
            Text = text,
            TextAlign = ContentAlignment.MiddleLeft,
            UseVisualStyleBackColor = false
        };
        button.FlatAppearance.BorderSize = 0;
        return button;
    }
}
