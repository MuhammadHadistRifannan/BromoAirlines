
namespace BromoAirlines.Forms;

partial class BookingForm
{
    private System.ComponentModel.IContainer components = null!;
    private Label titleLabel = null!;

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
        SuspendLayout();

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Name = "BookingForm";
        Padding = new Padding(28);
        Size = new Size(900, 560);

        titleLabel.Dock = DockStyle.Top;
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(844, 48);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "Booking Tiket";

        Controls.Add(titleLabel);
        ResumeLayout(false);
    }
}
