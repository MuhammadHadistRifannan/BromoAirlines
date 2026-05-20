using BromoAirlines.Models;

namespace BromoAirlines.Forms;

public partial class DashboardForm : Form
{
    public DashboardForm() : this(new Akun { Nama = "Admin", MerupakanAdmin = true })
    {
    }

    public DashboardForm(Akun user)
    {
        InitializeComponent();
        userLabel.Text = user.Nama;
        WireNavigation();
        ShowPage(new DashboardHomePanel(), "Dashboard");
    }

    private void WireNavigation()
    {
        dashboardButton.Click += (_, _) => ShowPage(new DashboardHomePanel(), "Dashboard");
        masterBandaraButton.Click += (_, _) => ShowPage(new MasterBandaraForm(), "Master Bandara");
        masterMaskapaiButton.Click += (_, _) => ShowPage(new MasterMaskapaiForm(), "Master Maskapai");
        masterJadwalButton.Click += (_, _) => ShowPage(new MasterJadwalPenerbanganForm(), "Master Jadwal Penerbangan");
        masterPromoButton.Click += (_, _) => ShowPage(new MasterKodePromoForm(), "Master Kode Promo");
        masterStatusButton.Click += (_, _) => ShowPage(new MasterStatusPenerbanganForm(), "Master Status Penerbangan");
    }

    private void ShowPage(Control page, string title)
    {
        contentPanel.Controls.Clear();
        page.Dock = DockStyle.Fill;
        contentPanel.Controls.Add(page);
        headerTitleLabel.Text = title;
    }
}
