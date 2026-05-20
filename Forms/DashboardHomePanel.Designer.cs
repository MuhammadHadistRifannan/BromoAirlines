
namespace BromoAirlines.Forms;

partial class DashboardHomePanel
{
    private System.ComponentModel.IContainer components = null!;
    private Label welcomeLabel = null!;

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
        welcomeLabel = new Label();
        SuspendLayout();

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Name = "DashboardHomePanel";
        Padding = new Padding(28);
        Size = new Size(900, 560);

        welcomeLabel.Dock = DockStyle.Top;
        welcomeLabel.Name = "welcomeLabel";
        welcomeLabel.Size = new Size(844, 70);
        welcomeLabel.TabIndex = 0;
        welcomeLabel.Text = "Bromo Airlines Admin";
        welcomeLabel.TextAlign = ContentAlignment.MiddleLeft;

        Controls.Add(welcomeLabel);
        ResumeLayout(false);
    }
}
