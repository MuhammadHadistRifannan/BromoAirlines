using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BromoAirlines.Forms.Sidebar
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
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
            ChangePanel(new MasterBandaraForm());
        }

        private void MenuMaskapaiClick(object sender, EventArgs e)
        {
            ChangePanel(new MasterMaskapaiForm());
        }

        private void MenuJadwalPenerbanganClick(object sender, EventArgs e)
        {
            ChangePanel(new MasterJadwalPenerbanganForm());
        }

        private void MenuKodePromoClick(object sender, EventArgs e)
        {
            ChangePanel(new MasterKodePromoForm());
        }

        private void MenuStatusPenerbanganClick(object sender, EventArgs e)
        {
            ChangePanel(new StatusPenerbanganForm());
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
