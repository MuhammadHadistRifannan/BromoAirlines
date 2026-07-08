using BromoAirlines.Forms.AirlineAdmin.Pages;
using BromoAirlines.Models;
using BromoAirlines.Repositories;
using BromoAirlines.Services;

namespace BromoAirlines.Forms.AirlineAdmin.Sidebar;

public partial class DashboardMaskapaiForm : Form
{
    private readonly Akun? _currentUser;
    private readonly int _maskapaiId;
    private readonly MaskapaiDashboardService _dashboardService;
    private readonly MaskapaiJadwalPenerbanganService _jadwalService;
    private readonly MaskapaiKodePromoService _kodePromoService;
    private readonly MaskapaiReportService _reportService;

    public DashboardMaskapaiForm()
    {
        _maskapaiId = 0;
        _dashboardService = CreateDashboardService(_maskapaiId);
        _jadwalService = CreateJadwalService(_maskapaiId);
        _kodePromoService = CreateKodePromoService(_maskapaiId);
        _reportService = CreateReportService(_maskapaiId);
        InitializeComponent();
        sidebarMaskapai.MenuSelected += SidebarMaskapaiMenuSelected;
    }

    public DashboardMaskapaiForm(Akun currentUser, int maskapaiId)
    {
        _currentUser = currentUser;
        _maskapaiId = maskapaiId;
        _dashboardService = CreateDashboardService(maskapaiId);
        _jadwalService = CreateJadwalService(maskapaiId);
        _kodePromoService = CreateKodePromoService(maskapaiId);
        _reportService = CreateReportService(maskapaiId);
        InitializeComponent();
        sidebarMaskapai.MenuSelected += SidebarMaskapaiMenuSelected;
    }

    private void DashboardMaskapaiFormLoad(object? sender, EventArgs e)
    {
        ShowPage(MaskapaiMenuItem.Dashboard);
    }

    private void SidebarMaskapaiMenuSelected(object? sender, MaskapaiMenuSelectedEventArgs e)
    {
        if (e.MenuItem == MaskapaiMenuItem.Logout)
        {
            Close();
            return;
        }

        ShowPage(e.MenuItem);
    }

    private void ShowPage(MaskapaiMenuItem menuItem)
    {
        sidebarMaskapai.SetActiveMenu(menuItem);
        ChangePanel(CreatePage(menuItem));
    }

    private Form CreatePage(MaskapaiMenuItem menuItem)
    {
        return menuItem switch
        {
            MaskapaiMenuItem.Dashboard => new DashboardMaskapaiPage(_currentUser, _dashboardService),
            MaskapaiMenuItem.JadwalPenerbangan => new MaskapaiJadwalPenerbanganForm(_jadwalService),
            MaskapaiMenuItem.KodePromo => new MaskapaiKodePromoForm(_kodePromoService),
            MaskapaiMenuItem.LaporanTransaksi => new MaskapaiTransactionReportForm(_reportService),
            _ => new DashboardMaskapaiPage(_currentUser, _dashboardService)
        };
    }

    private void ChangePanel(Form form)
    {
        panelContent.Controls.Clear();
        form.TopLevel = false;
        form.FormBorderStyle = FormBorderStyle.None;
        form.Dock = DockStyle.Fill;
        panelContent.Controls.Add(form);
        form.Show();
    }

    private static MaskapaiDashboardService CreateDashboardService(int maskapaiId)
    {
        return new MaskapaiDashboardService(
            new MaskapaiDashboardRepository(),
            maskapaiId);
    }

    private static MaskapaiJadwalPenerbanganService CreateJadwalService(int maskapaiId)
    {
        return new MaskapaiJadwalPenerbanganService(
            new JadwalPenerbanganRepository(),
            new BandaraRepository(),
            maskapaiId);
    }

    private static MaskapaiKodePromoService CreateKodePromoService(int maskapaiId)
    {
        return new MaskapaiKodePromoService(
            new MaskapaiKodePromoRepository(),
            maskapaiId);
    }

    private static MaskapaiReportService CreateReportService(int maskapaiId)
    {
        return new MaskapaiReportService(
            new MaskapaiReportRepository(),
            new JadwalPenerbanganRepository(),
            maskapaiId);
    }
}
