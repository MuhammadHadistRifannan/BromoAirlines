namespace BromoAirlines.Forms.Users.Sidebar;

partial class DashboardUserForm
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
        sidebarUser = new SidebarUser();
        panelContent = new Panel();
        SuspendLayout();
        // 
        // sidebarUser
        // 
        sidebarUser.BackColor = Color.RoyalBlue;
        sidebarUser.Dock = DockStyle.Left;
        sidebarUser.Location = new Point(0, 0);
        sidebarUser.Name = "sidebarUser";
        sidebarUser.Padding = new Padding(32, 24, 32, 24);
        sidebarUser.Size = new Size(320, 1050);
        sidebarUser.TabIndex = 0;
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
        // DashboardUserForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1695, 1050);
        Controls.Add(panelContent);
        Controls.Add(sidebarUser);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "DashboardUserForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Dashboard User";
        Load += DashboardUserFormLoad;
        ResumeLayout(false);
    }

    private SidebarUser sidebarUser;
    private Panel panelContent;
}
