namespace BromoAirlines.Forms.Users.Pages;

partial class HistoryForm
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
        panelFilter = new Panel();
        btnReset = new Button();
        btnFilter = new Button();
        cmbStatus = new ComboBox();
        lblStatus = new Label();
        dtpTanggalSampai = new DateTimePicker();
        lblTanggalSampai = new Label();
        dtpTanggalMulai = new DateTimePicker();
        lblTanggalMulai = new Label();
        panelGrid = new Panel();
        gridHistory = new DataGridView();
        colTransaksi = new DataGridViewTextBoxColumn();
        colBooking = new DataGridViewTextBoxColumn();
        colTanggal = new DataGridViewTextBoxColumn();
        colJadwal = new DataGridViewTextBoxColumn();
        colStatus = new DataGridViewTextBoxColumn();
        colTotal = new DataGridViewTextBoxColumn();
        panelSummary.SuspendLayout();
        panelFilter.SuspendLayout();
        panelGrid.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridHistory).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        lblTitle.ForeColor = Color.Navy;
        lblTitle.Location = new Point(48, 42);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(162, 54);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Riwayat";
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
        lblSummaryDescription.Text = "Pantau seluruh transaksi dan filter riwayat berdasarkan tanggal atau status.";
        // 
        // lblSummaryTitle
        // 
        lblSummaryTitle.AutoSize = true;
        lblSummaryTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblSummaryTitle.ForeColor = Color.White;
        lblSummaryTitle.Location = new Point(32, 24);
        lblSummaryTitle.Name = "lblSummaryTitle";
        lblSummaryTitle.Size = new Size(323, 50);
        lblSummaryTitle.TabIndex = 0;
        lblSummaryTitle.Text = "Riwayat Transaksi";
        // 
        // panelFilter
        // 
        panelFilter.BackColor = Color.White;
        panelFilter.Controls.Add(btnReset);
        panelFilter.Controls.Add(btnFilter);
        panelFilter.Controls.Add(cmbStatus);
        panelFilter.Controls.Add(lblStatus);
        panelFilter.Controls.Add(dtpTanggalSampai);
        panelFilter.Controls.Add(lblTanggalSampai);
        panelFilter.Controls.Add(dtpTanggalMulai);
        panelFilter.Controls.Add(lblTanggalMulai);
        panelFilter.Location = new Point(48, 318);
        panelFilter.Name = "panelFilter";
        panelFilter.Padding = new Padding(32);
        panelFilter.Size = new Size(1220, 170);
        panelFilter.TabIndex = 2;
        // 
        // btnReset
        // 
        btnReset.BackColor = Color.White;
        btnReset.Cursor = Cursors.Hand;
        btnReset.FlatAppearance.BorderColor = Color.RoyalBlue;
        btnReset.FlatStyle = FlatStyle.Flat;
        btnReset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnReset.ForeColor = Color.RoyalBlue;
        btnReset.Location = new Point(910, 86);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(130, 44);
        btnReset.TabIndex = 7;
        btnReset.Text = "Reset";
        btnReset.UseVisualStyleBackColor = false;
        btnReset.Click += BtnResetClick;
        // 
        // btnFilter
        // 
        btnFilter.BackColor = Color.RoyalBlue;
        btnFilter.Cursor = Cursors.Hand;
        btnFilter.FlatAppearance.BorderSize = 0;
        btnFilter.FlatStyle = FlatStyle.Flat;
        btnFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnFilter.ForeColor = Color.White;
        btnFilter.Location = new Point(1058, 86);
        btnFilter.Name = "btnFilter";
        btnFilter.Size = new Size(130, 44);
        btnFilter.TabIndex = 6;
        btnFilter.Text = "Filter";
        btnFilter.UseVisualStyleBackColor = false;
        btnFilter.Click += BtnFilterClick;
        // 
        // cmbStatus
        // 
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbStatus.FormattingEnabled = true;
        cmbStatus.Items.AddRange(new object[] { "Paid", "Upcoming", "Cancelled" });
        cmbStatus.Location = new Point(584, 94);
        cmbStatus.Name = "cmbStatus";
        cmbStatus.Size = new Size(260, 28);
        cmbStatus.TabIndex = 5;
        // 
        // lblStatus
        // 
        lblStatus.AutoSize = true;
        lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblStatus.ForeColor = Color.Navy;
        lblStatus.Location = new Point(584, 58);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(60, 23);
        lblStatus.TabIndex = 4;
        lblStatus.Text = "Status";
        // 
        // dtpTanggalSampai
        // 
        dtpTanggalSampai.Format = DateTimePickerFormat.Short;
        dtpTanggalSampai.Location = new Point(308, 94);
        dtpTanggalSampai.Name = "dtpTanggalSampai";
        dtpTanggalSampai.Size = new Size(220, 27);
        dtpTanggalSampai.TabIndex = 3;
        // 
        // lblTanggalSampai
        // 
        lblTanggalSampai.AutoSize = true;
        lblTanggalSampai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblTanggalSampai.ForeColor = Color.Navy;
        lblTanggalSampai.Location = new Point(308, 58);
        lblTanggalSampai.Name = "lblTanggalSampai";
        lblTanggalSampai.Size = new Size(138, 23);
        lblTanggalSampai.TabIndex = 2;
        lblTanggalSampai.Text = "Tanggal Sampai";
        // 
        // dtpTanggalMulai
        // 
        dtpTanggalMulai.Format = DateTimePickerFormat.Short;
        dtpTanggalMulai.Location = new Point(32, 94);
        dtpTanggalMulai.Name = "dtpTanggalMulai";
        dtpTanggalMulai.Size = new Size(220, 27);
        dtpTanggalMulai.TabIndex = 1;
        // 
        // lblTanggalMulai
        // 
        lblTanggalMulai.AutoSize = true;
        lblTanggalMulai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblTanggalMulai.ForeColor = Color.Navy;
        lblTanggalMulai.Location = new Point(32, 58);
        lblTanggalMulai.Name = "lblTanggalMulai";
        lblTanggalMulai.Size = new Size(122, 23);
        lblTanggalMulai.TabIndex = 0;
        lblTanggalMulai.Text = "Tanggal Mulai";
        // 
        // panelGrid
        // 
        panelGrid.BackColor = Color.White;
        panelGrid.Controls.Add(gridHistory);
        panelGrid.Location = new Point(48, 528);
        panelGrid.Name = "panelGrid";
        panelGrid.Padding = new Padding(24);
        panelGrid.Size = new Size(1220, 420);
        panelGrid.TabIndex = 3;
        // 
        // gridHistory
        // 
        gridHistory.AllowUserToAddRows = false;
        gridHistory.AllowUserToDeleteRows = false;
        gridHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridHistory.BackgroundColor = Color.White;
        gridHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridHistory.Columns.AddRange(new DataGridViewColumn[] { colTransaksi, colBooking, colTanggal, colJadwal, colStatus, colTotal });
        gridHistory.Dock = DockStyle.Fill;
        gridHistory.Location = new Point(24, 24);
        gridHistory.MultiSelect = false;
        gridHistory.Name = "gridHistory";
        gridHistory.ReadOnly = true;
        gridHistory.RowHeadersVisible = false;
        gridHistory.RowHeadersWidth = 51;
        gridHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridHistory.Size = new Size(1172, 372);
        gridHistory.TabIndex = 0;
        // 
        // colTransaksi
        // 
        colTransaksi.HeaderText = "No Transaksi";
        colTransaksi.MinimumWidth = 6;
        colTransaksi.Name = "colTransaksi";
        colTransaksi.ReadOnly = true;
        // 
        // colBooking
        // 
        colBooking.HeaderText = "Nomor Booking";
        colBooking.MinimumWidth = 6;
        colBooking.Name = "colBooking";
        colBooking.ReadOnly = true;
        // 
        // colTanggal
        // 
        colTanggal.HeaderText = "Tanggal";
        colTanggal.MinimumWidth = 6;
        colTanggal.Name = "colTanggal";
        colTanggal.ReadOnly = true;
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
        // colTotal
        // 
        colTotal.HeaderText = "Total";
        colTotal.MinimumWidth = 6;
        colTotal.Name = "colTotal";
        colTotal.ReadOnly = true;
        // 
        // HistoryForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1375, 1050);
        Controls.Add(panelGrid);
        Controls.Add(panelFilter);
        Controls.Add(panelSummary);
        Controls.Add(lblTitle);
        FormBorderStyle = FormBorderStyle.None;
        Name = "HistoryForm";
        Text = "Riwayat";
        Load += HistoryFormLoad;
        panelSummary.ResumeLayout(false);
        panelSummary.PerformLayout();
        panelFilter.ResumeLayout(false);
        panelFilter.PerformLayout();
        panelGrid.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridHistory).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitle;
    private Panel panelSummary;
    private Label lblSummaryTitle;
    private Label lblSummaryDescription;
    private Panel panelFilter;
    private Label lblTanggalMulai;
    private DateTimePicker dtpTanggalMulai;
    private DateTimePicker dtpTanggalSampai;
    private Label lblTanggalSampai;
    private ComboBox cmbStatus;
    private Label lblStatus;
    private Button btnFilter;
    private Button btnReset;
    private Panel panelGrid;
    private DataGridView gridHistory;
    private DataGridViewTextBoxColumn colTransaksi;
    private DataGridViewTextBoxColumn colBooking;
    private DataGridViewTextBoxColumn colTanggal;
    private DataGridViewTextBoxColumn colJadwal;
    private DataGridViewTextBoxColumn colStatus;
    private DataGridViewTextBoxColumn colTotal;
}
