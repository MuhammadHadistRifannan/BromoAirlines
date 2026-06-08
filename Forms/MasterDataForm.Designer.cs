
namespace BromoAirlines.Forms;

partial class FormMasterBandara
{
    private System.ComponentModel.IContainer components = null!;
    protected Button addButton = null!;
    protected Button editButton = null!;
    protected Button deleteButton = null!;
    protected DataGridView dataGridView = null!;

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
        SuspendLayout();
        // 
        // FormMasterBandara
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Margin = new Padding(3, 4, 3, 4);
        Name = "FormMasterBandara";
        Padding = new Padding(32, 37, 32, 37);
        Size = new Size(1142, 583);
        ResumeLayout(false);
    }
}
