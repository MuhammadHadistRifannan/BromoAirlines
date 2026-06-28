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
        }

        void ChangePanel(Form form)
        {
            sidebarPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            sidebarPanel.AutoScroll = false;
            sidebarPanel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void MenuPenerbanganClick(object sender, EventArgs e)
        {
            ChangePanel(new SearchFlightForm());
        }

        private void MenuDashboardClick(object sender, EventArgs e)
        {
        }

        private void MenuBandaraClick(object sender, EventArgs e)
        {
        }
    }
}
