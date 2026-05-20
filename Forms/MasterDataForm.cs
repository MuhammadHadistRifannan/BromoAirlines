namespace BromoAirlines.Forms;

public partial class MasterDataForm : UserControl
{
    protected DataGridView Grid => dataGridView;

    public MasterDataForm()
    {
        InitializeComponent();
    }

    protected MasterDataForm(string title) : this()
    {
        titleLabel.Text = title;
    }
}
