namespace BromoAirlines.Forms;

public partial class FormMasterBandara : UserControl
{
    protected DataGridView Grid => dataGridView;

    public FormMasterBandara()
    {
        InitializeComponent();
    }

    protected FormMasterBandara(string title) : this()
    {
        titleLabel.Text = title;
    }
}
