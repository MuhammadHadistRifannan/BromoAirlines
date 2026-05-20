using BromoAirlines.Models;

namespace BromoAirlines.Forms;

public partial class TransactionHistoryForm : UserControl
{
    public TransactionHistoryForm()
    {
        InitializeComponent();
    }

    public TransactionHistoryForm(Akun user) : this()
    {
        titleLabel.Text = $"Riwayat Transaksi - {user.Nama}";
    }
}
