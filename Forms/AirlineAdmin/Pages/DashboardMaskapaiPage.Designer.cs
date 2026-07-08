namespace BromoAirlines.Forms.AirlineAdmin.Pages;

partial class DashboardMaskapaiPage
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitle = new Label();
        lblWelcome = new Label();
        panelSummary = new FlowLayoutPanel();
        cardTodayFlights = new Panel();
        lblTodayFlightsValue = new Label();
        lblTodayFlightsTitle = new Label();
        cardActiveFlights = new Panel();
        lblActiveFlightsValue = new Label();
        lblActiveFlightsTitle = new Label();
        cardTodayRevenue = new Panel();
        lblTodayRevenueValue = new Label();
        lblTodayRevenueTitle = new Label();
        cardTotalBookings = new Panel();
        lblTotalBookingsValue = new Label();
        lblTotalBookingsTitle = new Label();
        cardActivePromo = new Panel();
        lblActivePromoValue = new Label();
        lblActivePromoTitle = new Label();
        lblRecentTransactions = new Label();
        gridRecentTransactions = new DataGridView();
        colKodeBooking = new DataGridViewTextBoxColumn();
        colTanggal = new DataGridViewTextBoxColumn();
        colPenerbangan = new DataGridViewTextBoxColumn();
        colPenumpang = new DataGridViewTextBoxColumn();
        colTotal = new DataGridViewTextBoxColumn();
        colStatus = new DataGridViewTextBoxColumn();
        panelSummary.SuspendLayout();
        cardTodayFlights.SuspendLayout();
        cardActiveFlights.SuspendLayout();
        cardTodayRevenue.SuspendLayout();
        cardTotalBookings.SuspendLayout();
        cardActivePromo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridRecentTransactions).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        lblTitle.ForeColor = Color.Navy;
        lblTitle.Location = new Point(48, 36);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(448, 54);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Dashboard Maskapai";
        // 
        // lblWelcome
        // 
        lblWelcome.AutoSize = true;
        lblWelcome.Font = new Font("Segoe UI", 12F);
        lblWelcome.ForeColor = Color.Black;
        lblWelcome.Location = new Point(54, 96);
        lblWelcome.Name = "lblWelcome";
        lblWelcome.Size = new Size(374, 28);
        lblWelcome.TabIndex = 1;
        lblWelcome.Text = "Ringkasan operasional maskapai hari ini.";
        // 
        // panelSummary
        // 
        panelSummary.Controls.Add(cardTodayFlights);
        panelSummary.Controls.Add(cardActiveFlights);
        panelSummary.Controls.Add(cardTodayRevenue);
        panelSummary.Controls.Add(cardTotalBookings);
        panelSummary.Controls.Add(cardActivePromo);
        panelSummary.Location = new Point(54, 154);
        panelSummary.Name = "panelSummary";
        panelSummary.Size = new Size(1230, 250);
        panelSummary.TabIndex = 2;
        // 
        // cardTodayFlights
        // 
        cardTodayFlights.BackColor = Color.White;
        cardTodayFlights.BorderStyle = BorderStyle.FixedSingle;
        cardTodayFlights.Controls.Add(lblTodayFlightsValue);
        cardTodayFlights.Controls.Add(lblTodayFlightsTitle);
        cardTodayFlights.Location = new Point(0, 0);
        cardTodayFlights.Margin = new Padding(0, 0, 18, 18);
        cardTodayFlights.Name = "cardTodayFlights";
        cardTodayFlights.Size = new Size(225, 108);
        cardTodayFlights.TabIndex = 0;
        // 
        // lblTodayFlightsValue
        // 
        lblTodayFlightsValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        lblTodayFlightsValue.ForeColor = Color.RoyalBlue;
        lblTodayFlightsValue.Location = new Point(18, 42);
        lblTodayFlightsValue.Name = "lblTodayFlightsValue";
        lblTodayFlightsValue.Size = new Size(180, 48);
        lblTodayFlightsValue.TabIndex = 1;
        lblTodayFlightsValue.Text = "0";
        // 
        // lblTodayFlightsTitle
        // 
        lblTodayFlightsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblTodayFlightsTitle.ForeColor = Color.DimGray;
        lblTodayFlightsTitle.Location = new Point(18, 14);
        lblTodayFlightsTitle.Name = "lblTodayFlightsTitle";
        lblTodayFlightsTitle.Size = new Size(190, 28);
        lblTodayFlightsTitle.TabIndex = 0;
        lblTodayFlightsTitle.Text = "Today's Flights";
        // 
        // cardActiveFlights
        // 
        cardActiveFlights.BackColor = Color.White;
        cardActiveFlights.BorderStyle = BorderStyle.FixedSingle;
        cardActiveFlights.Controls.Add(lblActiveFlightsValue);
        cardActiveFlights.Controls.Add(lblActiveFlightsTitle);
        cardActiveFlights.Location = new Point(243, 0);
        cardActiveFlights.Margin = new Padding(0, 0, 18, 18);
        cardActiveFlights.Name = "cardActiveFlights";
        cardActiveFlights.Size = new Size(225, 108);
        cardActiveFlights.TabIndex = 1;
        // 
        // lblActiveFlightsValue
        // 
        lblActiveFlightsValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        lblActiveFlightsValue.ForeColor = Color.ForestGreen;
        lblActiveFlightsValue.Location = new Point(18, 42);
        lblActiveFlightsValue.Name = "lblActiveFlightsValue";
        lblActiveFlightsValue.Size = new Size(180, 48);
        lblActiveFlightsValue.TabIndex = 1;
        lblActiveFlightsValue.Text = "0";
        // 
        // lblActiveFlightsTitle
        // 
        lblActiveFlightsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblActiveFlightsTitle.ForeColor = Color.DimGray;
        lblActiveFlightsTitle.Location = new Point(18, 14);
        lblActiveFlightsTitle.Name = "lblActiveFlightsTitle";
        lblActiveFlightsTitle.Size = new Size(190, 28);
        lblActiveFlightsTitle.TabIndex = 0;
        lblActiveFlightsTitle.Text = "Active Flights";
        // 
        // cardTodayRevenue
        // 
        cardTodayRevenue.BackColor = Color.White;
        cardTodayRevenue.BorderStyle = BorderStyle.FixedSingle;
        cardTodayRevenue.Controls.Add(lblTodayRevenueValue);
        cardTodayRevenue.Controls.Add(lblTodayRevenueTitle);
        cardTodayRevenue.Location = new Point(486, 0);
        cardTodayRevenue.Margin = new Padding(0, 0, 18, 18);
        cardTodayRevenue.Name = "cardTodayRevenue";
        cardTodayRevenue.Size = new Size(280, 108);
        cardTodayRevenue.TabIndex = 2;
        // 
        // lblTodayRevenueValue
        // 
        lblTodayRevenueValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblTodayRevenueValue.ForeColor = Color.DarkOrange;
        lblTodayRevenueValue.Location = new Point(18, 42);
        lblTodayRevenueValue.Name = "lblTodayRevenueValue";
        lblTodayRevenueValue.Size = new Size(245, 48);
        lblTodayRevenueValue.TabIndex = 1;
        lblTodayRevenueValue.Text = "Rp 0";
        // 
        // lblTodayRevenueTitle
        // 
        lblTodayRevenueTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblTodayRevenueTitle.ForeColor = Color.DimGray;
        lblTodayRevenueTitle.Location = new Point(18, 14);
        lblTodayRevenueTitle.Name = "lblTodayRevenueTitle";
        lblTodayRevenueTitle.Size = new Size(230, 28);
        lblTodayRevenueTitle.TabIndex = 0;
        lblTodayRevenueTitle.Text = "Today's Revenue";
        // 
        // cardTotalBookings
        // 
        cardTotalBookings.BackColor = Color.White;
        cardTotalBookings.BorderStyle = BorderStyle.FixedSingle;
        cardTotalBookings.Controls.Add(lblTotalBookingsValue);
        cardTotalBookings.Controls.Add(lblTotalBookingsTitle);
        cardTotalBookings.Location = new Point(784, 0);
        cardTotalBookings.Margin = new Padding(0, 0, 18, 18);
        cardTotalBookings.Name = "cardTotalBookings";
        cardTotalBookings.Size = new Size(225, 108);
        cardTotalBookings.TabIndex = 3;
        // 
        // lblTotalBookingsValue
        // 
        lblTotalBookingsValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        lblTotalBookingsValue.ForeColor = Color.MediumVioletRed;
        lblTotalBookingsValue.Location = new Point(18, 42);
        lblTotalBookingsValue.Name = "lblTotalBookingsValue";
        lblTotalBookingsValue.Size = new Size(180, 48);
        lblTotalBookingsValue.TabIndex = 1;
        lblTotalBookingsValue.Text = "0";
        // 
        // lblTotalBookingsTitle
        // 
        lblTotalBookingsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblTotalBookingsTitle.ForeColor = Color.DimGray;
        lblTotalBookingsTitle.Location = new Point(18, 14);
        lblTotalBookingsTitle.Name = "lblTotalBookingsTitle";
        lblTotalBookingsTitle.Size = new Size(190, 28);
        lblTotalBookingsTitle.TabIndex = 0;
        lblTotalBookingsTitle.Text = "Total Bookings";
        // 
        // cardActivePromo
        // 
        cardActivePromo.BackColor = Color.White;
        cardActivePromo.BorderStyle = BorderStyle.FixedSingle;
        cardActivePromo.Controls.Add(lblActivePromoValue);
        cardActivePromo.Controls.Add(lblActivePromoTitle);
        cardActivePromo.Location = new Point(0, 126);
        cardActivePromo.Margin = new Padding(0, 0, 18, 18);
        cardActivePromo.Name = "cardActivePromo";
        cardActivePromo.Size = new Size(225, 108);
        cardActivePromo.TabIndex = 4;
        // 
        // lblActivePromoValue
        // 
        lblActivePromoValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        lblActivePromoValue.ForeColor = Color.Teal;
        lblActivePromoValue.Location = new Point(18, 42);
        lblActivePromoValue.Name = "lblActivePromoValue";
        lblActivePromoValue.Size = new Size(180, 48);
        lblActivePromoValue.TabIndex = 1;
        lblActivePromoValue.Text = "0";
        // 
        // lblActivePromoTitle
        // 
        lblActivePromoTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblActivePromoTitle.ForeColor = Color.DimGray;
        lblActivePromoTitle.Location = new Point(18, 14);
        lblActivePromoTitle.Name = "lblActivePromoTitle";
        lblActivePromoTitle.Size = new Size(190, 28);
        lblActivePromoTitle.TabIndex = 0;
        lblActivePromoTitle.Text = "Active Promo";
        // 
        // lblRecentTransactions
        // 
        lblRecentTransactions.AutoSize = true;
        lblRecentTransactions.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblRecentTransactions.ForeColor = Color.Navy;
        lblRecentTransactions.Location = new Point(54, 428);
        lblRecentTransactions.Name = "lblRecentTransactions";
        lblRecentTransactions.Size = new Size(278, 37);
        lblRecentTransactions.TabIndex = 3;
        lblRecentTransactions.Text = "Recent Transactions";
        // 
        // gridRecentTransactions
        // 
        gridRecentTransactions.AllowUserToAddRows = false;
        gridRecentTransactions.AllowUserToDeleteRows = false;
        gridRecentTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridRecentTransactions.BackgroundColor = Color.White;
        gridRecentTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridRecentTransactions.Columns.AddRange(new DataGridViewColumn[] { colKodeBooking, colTanggal, colPenerbangan, colPenumpang, colTotal, colStatus });
        gridRecentTransactions.Location = new Point(54, 480);
        gridRecentTransactions.Name = "gridRecentTransactions";
        gridRecentTransactions.ReadOnly = true;
        gridRecentTransactions.RowHeadersVisible = false;
        gridRecentTransactions.RowHeadersWidth = 51;
        gridRecentTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridRecentTransactions.Size = new Size(1230, 300);
        gridRecentTransactions.TabIndex = 4;
        // 
        // colKodeBooking
        // 
        colKodeBooking.HeaderText = "Kode Booking";
        colKodeBooking.MinimumWidth = 6;
        colKodeBooking.Name = "colKodeBooking";
        colKodeBooking.ReadOnly = true;
        // 
        // colTanggal
        // 
        colTanggal.HeaderText = "Tanggal";
        colTanggal.MinimumWidth = 6;
        colTanggal.Name = "colTanggal";
        colTanggal.ReadOnly = true;
        // 
        // colPenerbangan
        // 
        colPenerbangan.HeaderText = "Penerbangan";
        colPenerbangan.MinimumWidth = 6;
        colPenerbangan.Name = "colPenerbangan";
        colPenerbangan.ReadOnly = true;
        // 
        // colPenumpang
        // 
        colPenumpang.HeaderText = "Penumpang";
        colPenumpang.MinimumWidth = 6;
        colPenumpang.Name = "colPenumpang";
        colPenumpang.ReadOnly = true;
        // 
        // colTotal
        // 
        colTotal.HeaderText = "Total";
        colTotal.MinimumWidth = 6;
        colTotal.Name = "colTotal";
        colTotal.ReadOnly = true;
        // 
        // colStatus
        // 
        colStatus.HeaderText = "Status";
        colStatus.MinimumWidth = 6;
        colStatus.Name = "colStatus";
        colStatus.ReadOnly = true;
        // 
        // DashboardMaskapaiPage
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(1375, 1050);
        Controls.Add(gridRecentTransactions);
        Controls.Add(lblRecentTransactions);
        Controls.Add(panelSummary);
        Controls.Add(lblWelcome);
        Controls.Add(lblTitle);
        FormBorderStyle = FormBorderStyle.None;
        Name = "DashboardMaskapaiPage";
        Text = "DashboardMaskapaiPage";
        Load += DashboardMaskapaiPageLoad;
        panelSummary.ResumeLayout(false);
        cardTodayFlights.ResumeLayout(false);
        cardActiveFlights.ResumeLayout(false);
        cardTodayRevenue.ResumeLayout(false);
        cardTotalBookings.ResumeLayout(false);
        cardActivePromo.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridRecentTransactions).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitle;
    private Label lblWelcome;
    private FlowLayoutPanel panelSummary;
    private Panel cardTodayFlights;
    private Label lblTodayFlightsValue;
    private Label lblTodayFlightsTitle;
    private Panel cardActiveFlights;
    private Label lblActiveFlightsValue;
    private Label lblActiveFlightsTitle;
    private Panel cardTodayRevenue;
    private Label lblTodayRevenueValue;
    private Label lblTodayRevenueTitle;
    private Panel cardTotalBookings;
    private Label lblTotalBookingsValue;
    private Label lblTotalBookingsTitle;
    private Panel cardActivePromo;
    private Label lblActivePromoValue;
    private Label lblActivePromoTitle;
    private Label lblRecentTransactions;
    private DataGridView gridRecentTransactions;
    private DataGridViewTextBoxColumn colKodeBooking;
    private DataGridViewTextBoxColumn colTanggal;
    private DataGridViewTextBoxColumn colPenerbangan;
    private DataGridViewTextBoxColumn colPenumpang;
    private DataGridViewTextBoxColumn colTotal;
    private DataGridViewTextBoxColumn colStatus;
}
