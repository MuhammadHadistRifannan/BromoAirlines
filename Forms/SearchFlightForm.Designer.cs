
namespace BromoAirlines.Forms;

partial class SearchFlightForm
{
    private System.ComponentModel.IContainer components = null!;
    private Label titleLabel = null!;
    private Panel gridPanel = null!;
    private DataGridView flightsGridView = null!;

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
        titleLabel = new Label();
        gridPanel = new Panel();
        gridPanel.SuspendLayout();
        SuspendLayout();

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Name = "SearchFlightForm";
        Padding = new Padding(28);
        Size = new Size(900, 560);

        titleLabel.Dock = DockStyle.Top;
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(844, 48);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "Cari Penerbangan";

        gridPanel.BackColor = Color.White;
        gridPanel.Controls.Add(flightsGridView);
        gridPanel.Dock = DockStyle.Fill;
        gridPanel.Name = "gridPanel";
        gridPanel.Padding = new Padding(12);
        gridPanel.Size = new Size(844, 456);
        gridPanel.TabIndex = 1;

        flightsGridView.Name = "flightsGridView";
        flightsGridView.TabIndex = 0;

        Controls.Add(gridPanel);
        Controls.Add(titleLabel);
        gridPanel.ResumeLayout(false);
        ResumeLayout(false);
    }
}
