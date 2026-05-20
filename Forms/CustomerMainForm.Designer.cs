
namespace BromoAirlines.Forms;

partial class CustomerMainForm
{
    private System.ComponentModel.IContainer components = null!;
    private Panel headerPanel = null!;
    private PictureBox logoPictureBox = null!;
    private FlowLayoutPanel navigationPanel = null!;
    private Button searchButton = null!;
    private Button historyButton = null!;
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
        headerPanel = new Panel();
        navigationPanel = new FlowLayoutPanel();
        contentPanel = new Panel();
        headerPanel.SuspendLayout();
        navigationPanel.SuspendLayout();
        SuspendLayout();

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        MinimumSize = new Size(1000, 650);
        Name = "CustomerMainForm";
        Text = "Bromo Airlines";
        WindowState = FormWindowState.Maximized;

        headerPanel.BackColor = Color.White;
        headerPanel.Controls.Add(logoPictureBox);
        headerPanel.Controls.Add(navigationPanel);
        headerPanel.Dock = DockStyle.Top;
        headerPanel.Name = "headerPanel";
        headerPanel.Padding = new Padding(24, 12, 24, 12);
        headerPanel.Size = new Size(1100, 82);
        headerPanel.TabIndex = 0;

        logoPictureBox.Dock = DockStyle.Left;
        logoPictureBox.Name = "logoPictureBox";
        logoPictureBox.TabIndex = 0;
        logoPictureBox.TabStop = false;

        navigationPanel.Controls.Add(searchButton);
        navigationPanel.Controls.Add(historyButton);
        navigationPanel.Dock = DockStyle.Right;
        navigationPanel.FlowDirection = FlowDirection.LeftToRight;
        navigationPanel.Name = "navigationPanel";
        navigationPanel.Size = new Size(450, 58);
        navigationPanel.TabIndex = 1;

        searchButton.Name = "searchButton";
        searchButton.Size = new Size(120, 42);
        searchButton.TabIndex = 0;

        historyButton.Name = "historyButton";
        historyButton.Size = new Size(120, 42);
        historyButton.TabIndex = 1;

        contentPanel.Dock = DockStyle.Fill;
        contentPanel.Name = "contentPanel";
        contentPanel.Size = new Size(1100, 618);
        contentPanel.TabIndex = 1;

        Controls.Add(contentPanel);
        Controls.Add(headerPanel);
        headerPanel.ResumeLayout(false);
        navigationPanel.ResumeLayout(false);
        ResumeLayout(false);
    }
}
