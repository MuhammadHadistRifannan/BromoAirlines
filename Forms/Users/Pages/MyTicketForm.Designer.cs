namespace BromoAirlines.Forms.Users.Pages;

partial class MyTicketForm
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
        panelSummary = new Panel();
        lblSummaryDescription = new Label();
        lblSummaryTitle = new Label();
        panelContent = new Panel();
        panelGrid = new Panel();
        gridTicket = new DataGridView();
        colNomorBooking = new DataGridViewTextBoxColumn();
        colJadwal = new DataGridViewTextBoxColumn();
        colStatus = new DataGridViewTextBoxColumn();
        panelDetail = new Panel();
        lblDetailValue = new Label();
        lblDetail = new Label();
        lblStatusValue = new Label();
        lblStatus = new Label();
        lblJadwalValue = new Label();
        lblJadwal = new Label();
        lblNomorBookingValue = new Label();
        lblNomorBooking = new Label();
        lblDetailTitle = new Label();
        panelSummary.SuspendLayout();
        panelGrid.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridTicket).BeginInit();
        panelDetail.SuspendLayout();
        panelContent.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        lblTitle.ForeColor = Color.Navy;
        lblTitle.Location = new Point(48, 42);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(202, 54);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Tiket Saya";
        // 
        // panelSummary
        // 
        panelSummary.BackColor = Color.RoyalBlue;
        panelSummary.Controls.Add(lblSummaryDescription);
        panelSummary.Controls.Add(lblSummaryTitle);
        panelSummary.Location = new Point(48, 124);
        panelSummary.Name = "panelSummary";
        panelSummary.Padding = new Padding(32);
        panelSummary.Size = new Size(1220, 150);
        panelSummary.TabIndex = 1;
        // 
        // lblSummaryDescription
        // 
        lblSummaryDescription.Font = new Font("Segoe UI", 14F);
        lblSummaryDescription.ForeColor = Color.White;
        lblSummaryDescription.Location = new Point(32, 82);
        lblSummaryDescription.Name = "lblSummaryDescription";
        lblSummaryDescription.Size = new Size(900, 38);
        lblSummaryDescription.TabIndex = 1;
        lblSummaryDescription.Text = "Lihat nomor booking, jadwal, status, dan detail tiket perjalanan.";
        // 
        // lblSummaryTitle
        // 
        lblSummaryTitle.AutoSize = true;
        lblSummaryTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblSummaryTitle.ForeColor = Color.White;
        lblSummaryTitle.Location = new Point(32, 24);
        lblSummaryTitle.Name = "lblSummaryTitle";
        lblSummaryTitle.Size = new Size(304, 50);
        lblSummaryTitle.TabIndex = 0;
        lblSummaryTitle.Text = "Daftar Tiket Aktif";
        // 
        // panelGrid
        // 
        panelGrid.BackColor = Color.White;
        panelGrid.Controls.Add(gridTicket);
        panelGrid.Location = new Point(48, 318);
        panelGrid.Name = "panelGrid";
        panelGrid.Padding = new Padding(24);
        panelGrid.Size = new Size(1220, 290);
        panelGrid.TabIndex = 2;
        // 
        // gridTicket
        // 
        gridTicket.AllowUserToAddRows = false;
        gridTicket.AllowUserToDeleteRows = false;
        gridTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridTicket.BackgroundColor = Color.White;
        gridTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridTicket.Columns.AddRange(new DataGridViewColumn[] { colNomorBooking, colJadwal, colStatus });
        gridTicket.Dock = DockStyle.Fill;
        gridTicket.Location = new Point(24, 24);
        gridTicket.MultiSelect = false;
        gridTicket.Name = "gridTicket";
        gridTicket.ReadOnly = true;
        gridTicket.RowHeadersVisible = false;
        gridTicket.RowHeadersWidth = 51;
        gridTicket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridTicket.Size = new Size(1172, 242);
        gridTicket.TabIndex = 0;
        gridTicket.SelectionChanged += GridTicketSelectionChanged;
        // 
        // colNomorBooking
        // 
        colNomorBooking.HeaderText = "Nomor Booking";
        colNomorBooking.MinimumWidth = 6;
        colNomorBooking.Name = "colNomorBooking";
        colNomorBooking.ReadOnly = true;
        // 
        // colJadwal
        // 
        colJadwal.HeaderText = "Jadwal";
        colJadwal.MinimumWidth = 6;
        colJadwal.Name = "colJadwal";
        colJadwal.ReadOnly = true;
        // 
        // colStatus
        // 
        colStatus.HeaderText = "Status";
        colStatus.MinimumWidth = 6;
        colStatus.Name = "colStatus";
        colStatus.ReadOnly = true;
        // 
        // panelDetail
        // 
        panelDetail.BackColor = Color.White;
        panelDetail.Controls.Add(lblDetailValue);
        panelDetail.Controls.Add(lblDetail);
        panelDetail.Controls.Add(lblStatusValue);
        panelDetail.Controls.Add(lblStatus);
        panelDetail.Controls.Add(lblJadwalValue);
        panelDetail.Controls.Add(lblJadwal);
        panelDetail.Controls.Add(lblNomorBookingValue);
        panelDetail.Controls.Add(lblNomorBooking);
        panelDetail.Controls.Add(lblDetailTitle);
        panelDetail.Location = new Point(48, 646);
        panelDetail.Name = "panelDetail";
        panelDetail.Padding = new Padding(32);
        panelDetail.Size = new Size(1220, 260);
        panelDetail.TabIndex = 3;
        // 
        // lblDetailValue
        // 
        lblDetailValue.Font = new Font("Segoe UI", 11F);
        lblDetailValue.ForeColor = Color.Black;
        lblDetailValue.Location = new Point(326, 198);
        lblDetailValue.Name = "lblDetailValue";
        lblDetailValue.Size = new Size(780, 36);
        lblDetailValue.TabIndex = 8;
        lblDetailValue.Text = "-";
        // 
        // lblDetail
        // 
        lblDetail.AutoSize = true;
        lblDetail.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblDetail.ForeColor = Color.Navy;
        lblDetail.Location = new Point(32, 198);
        lblDetail.Name = "lblDetail";
        lblDetail.Size = new Size(107, 25);
        lblDetail.TabIndex = 7;
        lblDetail.Text = "Detail Tiket";
        // 
        // lblStatusValue
        // 
        lblStatusValue.Font = new Font("Segoe UI", 11F);
        lblStatusValue.ForeColor = Color.Black;
        lblStatusValue.Location = new Point(326, 152);
        lblStatusValue.Name = "lblStatusValue";
        lblStatusValue.Size = new Size(780, 30);
        lblStatusValue.TabIndex = 6;
        lblStatusValue.Text = "-";
        // 
        // lblStatus
        // 
        lblStatus.AutoSize = true;
        lblStatus.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblStatus.ForeColor = Color.Navy;
        lblStatus.Location = new Point(32, 152);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(66, 25);
        lblStatus.TabIndex = 5;
        lblStatus.Text = "Status";
        // 
        // lblJadwalValue
        // 
        lblJadwalValue.Font = new Font("Segoe UI", 11F);
        lblJadwalValue.ForeColor = Color.Black;
        lblJadwalValue.Location = new Point(326, 106);
        lblJadwalValue.Name = "lblJadwalValue";
        lblJadwalValue.Size = new Size(780, 30);
        lblJadwalValue.TabIndex = 4;
        lblJadwalValue.Text = "-";
        // 
        // lblJadwal
        // 
        lblJadwal.AutoSize = true;
        lblJadwal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblJadwal.ForeColor = Color.Navy;
        lblJadwal.Location = new Point(32, 106);
        lblJadwal.Name = "lblJadwal";
        lblJadwal.Size = new Size(70, 25);
        lblJadwal.TabIndex = 3;
        lblJadwal.Text = "Jadwal";
        // 
        // lblNomorBookingValue
        // 
        lblNomorBookingValue.Font = new Font("Segoe UI", 11F);
        lblNomorBookingValue.ForeColor = Color.Black;
        lblNomorBookingValue.Location = new Point(326, 60);
        lblNomorBookingValue.Name = "lblNomorBookingValue";
        lblNomorBookingValue.Size = new Size(780, 30);
        lblNomorBookingValue.TabIndex = 2;
        lblNomorBookingValue.Text = "-";
        // 
        // lblNomorBooking
        // 
        lblNomorBooking.AutoSize = true;
        lblNomorBooking.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblNomorBooking.ForeColor = Color.Navy;
        lblNomorBooking.Location = new Point(32, 60);
        lblNomorBooking.Name = "lblNomorBooking";
        lblNomorBooking.Size = new Size(156, 25);
        lblNomorBooking.TabIndex = 1;
        lblNomorBooking.Text = "Nomor Booking";
        // 
        // lblDetailTitle
        // 
        lblDetailTitle.AutoSize = true;
        lblDetailTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblDetailTitle.ForeColor = Color.Navy;
        lblDetailTitle.Location = new Point(32, 20);
        lblDetailTitle.Name = "lblDetailTitle";
        lblDetailTitle.Size = new Size(141, 32);
        lblDetailTitle.TabIndex = 0;
        lblDetailTitle.Text = "Detail Tiket";
        // 
        // panelContent
        // 
        panelContent.AutoScroll = true;
        panelContent.Controls.Add(panelDetail);
        panelContent.Controls.Add(panelGrid);
        panelContent.Controls.Add(panelSummary);
        panelContent.Controls.Add(lblTitle);
        panelContent.Dock = DockStyle.Fill;
        panelContent.Location = new Point(0, 0);
        panelContent.Name = "panelContent";
        panelContent.Size = new Size(1375, 1050);
        panelContent.TabIndex = 4;
        // 
        // MyTicketForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1375, 1050);
        Controls.Add(panelContent);
        FormBorderStyle = FormBorderStyle.None;
        Name = "MyTicketForm";
        Text = "Tiket Saya";
        Load += MyTicketFormLoad;
        panelSummary.ResumeLayout(false);
        panelSummary.PerformLayout();
        panelGrid.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridTicket).EndInit();
        panelDetail.ResumeLayout(false);
        panelDetail.PerformLayout();
        panelContent.ResumeLayout(false);
        panelContent.PerformLayout();
        ResumeLayout(false);
    }

    private Label lblTitle;
    private Panel panelSummary;
    private Label lblSummaryTitle;
    private Label lblSummaryDescription;
    private Panel panelContent;
    private Panel panelGrid;
    private DataGridView gridTicket;
    private DataGridViewTextBoxColumn colNomorBooking;
    private DataGridViewTextBoxColumn colJadwal;
    private DataGridViewTextBoxColumn colStatus;
    private Panel panelDetail;
    private Label lblDetailTitle;
    private Label lblNomorBooking;
    private Label lblNomorBookingValue;
    private Label lblJadwalValue;
    private Label lblJadwal;
    private Label lblStatusValue;
    private Label lblStatus;
    private Label lblDetailValue;
    private Label lblDetail;
}
