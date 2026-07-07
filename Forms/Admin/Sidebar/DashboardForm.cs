using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BromoAirlines.Repositories;
using BromoAirlines.Services;

namespace BromoAirlines.Forms.Sidebar
{
    public partial class DashboardForm : Form
    {
        private readonly MasterBandaraService _masterBandaraService;
        private readonly MasterMaskapaiService _masterMaskapaiService;
        private readonly MasterJadwalPenerbanganService _masterJadwalPenerbanganService;
        private readonly MasterKodePromoService _masterKodePromoService;
        private readonly StatusPenerbanganService _statusPenerbanganService;
        private readonly TransaksiService _transaksiService;
        private readonly UserManagementService _userManagementService;
        private readonly LaporanService _laporanService;

        public DashboardForm()
        {
            var bandaraRepository = new BandaraRepository();
            var maskapaiRepository = new MaskapaiRepository();

            _masterBandaraService = new MasterBandaraService(
                bandaraRepository,
                new NegaraRepository());
            _masterMaskapaiService = new MasterMaskapaiService(maskapaiRepository);
            _masterJadwalPenerbanganService = new MasterJadwalPenerbanganService(
                new JadwalPenerbanganRepository(),
                bandaraRepository,
                maskapaiRepository);
            _masterKodePromoService = new MasterKodePromoService(new KodePromoRepository());
            _statusPenerbanganService = new StatusPenerbanganService(
                new PerubahanStatusJadwalPenerbanganRepository(),
                new StatusPenerbanganRepository());
            _transaksiService = new TransaksiService(new TransaksiRepository());
            _userManagementService = new UserManagementService(new AkunRepository());
            _laporanService = new LaporanService(new LaporanRepository());

            InitializeComponent();
            this.Load += DashboardForm_Load;
        }

        private void DashboardForm_Load(object? sender, EventArgs e)
        {
            ChangePanel(new AdminDashboardForm());
        }

        void ChangePanel(Form form)
        {
            panelContent.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panelContent.AutoScroll = false;
            panelContent.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void MenuDashboardClick(object sender, EventArgs e)
        {
            ChangePanel(new AdminDashboardForm());
        }

        private void MenuBandaraClick(object sender, EventArgs e)
        {
            ChangePanel(new MasterBandaraForm(_masterBandaraService));
        }

        private void MenuMaskapaiClick(object sender, EventArgs e)
        {
            ChangePanel(new MasterMaskapaiForm(_masterMaskapaiService));
        }

        private void MenuJadwalPenerbanganClick(object sender, EventArgs e)
        {
            ChangePanel(new MasterJadwalPenerbanganForm(_masterJadwalPenerbanganService));
        }

        private void MenuKodePromoClick(object sender, EventArgs e)
        {
            ChangePanel(new MasterKodePromoForm(_masterKodePromoService));
        }

        private void MenuStatusPenerbanganClick(object sender, EventArgs e)
        {
            ChangePanel(new StatusPenerbanganForm(_statusPenerbanganService));
        }

        private void MenuTransaksiClick(object sender, EventArgs e)
        {
            ChangePanel(new TransaksiForm(_transaksiService));
        }

        private void MenuUserManagementClick(object sender, EventArgs e)
        {
            ChangePanel(new UserManagementForm(_userManagementService));
        }

        private void MenuLaporanClick(object sender, EventArgs e)
        {
            ChangePanel(new LaporanForm(_laporanService));
        }

        private void MenuProfileClick(object sender, EventArgs e)
        {
            ChangePanel(new FormProfileAdmin());
        }

        private void MenuLogoutClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
