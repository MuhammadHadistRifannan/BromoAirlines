namespace BromoAirlines.Forms.AirlineAdmin.Sidebar;

partial class DashboardMaskapaiForm
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
        sidebarMaskapai = new SidebarMaskapai();
        panelContent = new Panel();
        SuspendLayout();
        // 
        // sidebarMaskapai
        // 
        sidebarMaskapai.BackColor = Color.RoyalBlue;
        sidebarMaskapai.Dock = DockStyle.Left;
        sidebarMaskapai.Location = new Point(0, 0);
        sidebarMaskapai.Name = "sidebarMaskapai";
        sidebarMaskapai.Padding = new Padding(32, 24, 32, 24);
        sidebarMaskapai.Size = new Size(320, 1050);
        sidebarMaskapai.TabIndex = 0;
        // 
        // panelContent
        // 
        panelContent.BackColor = SystemColors.Control;
        panelContent.Dock = DockStyle.Fill;
        panelContent.Location = new Point(320, 0);
        panelContent.Name = "panelContent";
        panelContent.Size = new Size(1375, 1050);
        panelContent.TabIndex = 1;
        // 
        // DashboardMaskapaiForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1695, 1050);
        Controls.Add(panelContent);
        Controls.Add(sidebarMaskapai);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "DashboardMaskapaiForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Dashboard Maskapai";
        Load += DashboardMaskapaiFormLoad;
        ResumeLayout(false);
    }

    private SidebarMaskapai sidebarMaskapai;
    private Panel panelContent;
}
