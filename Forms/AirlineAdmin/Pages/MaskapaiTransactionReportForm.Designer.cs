namespace BromoAirlines.Forms.AirlineAdmin.Pages;

partial class MaskapaiTransactionReportForm
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
        gbFilter = new GroupBox();
        btnTampilkan = new Button();
        cmbStatus = new ComboBox();
        lblStatus = new Label();
        cmbJadwal = new ComboBox();
        lblJadwal = new Label();
        dtpSampai = new DateTimePicker();
        lblSampai = new Label();
        dtpMulai = new DateTimePicker();
        lblMulai = new Label();
        lblTotalTransaksi = new Label();
        lblTotalTransaksiValue = new Label();
        lblTotalPenumpang = new Label();
        lblTotalPenumpangValue = new Label();
        lblTotalPendapatan = new Label();
        lblTotalPendapatanValue = new Label();
        lblTransaksi = new Label();
        dgvTransaksi = new DataGridView();
        ID = new DataGridViewTextBoxColumn();
        TanggalTransaksi = new DataGridViewTextBoxColumn();
        NamaAkun = new DataGridViewTextBoxColumn();
        KodePenerbangan = new DataGridViewTextBoxColumn();
        Rute = new DataGridViewTextBoxColumn();
        JumlahPenumpang = new DataGridViewTextBoxColumn();
        TotalHarga = new DataGridViewTextBoxColumn();
        KodePromo = new DataGridViewTextBoxColumn();
        lblRutePopuler = new Label();
        dgvRutePopuler = new DataGridView();
        RutePopuler = new DataGridViewTextBoxColumn();
        TotalTransaksiRute = new DataGridViewTextBoxColumn();
        TotalPenumpangRute = new DataGridViewTextBoxColumn();
        TotalPendapatan = new DataGridViewTextBoxColumn();
        gbFilter.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTransaksi).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvRutePopuler).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblTitle.ForeColor = Color.Navy;
        lblTitle.Location = new Point(28, 24);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(493, 50);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Laporan Transaksi";
        // 
        // gbFilter
        // 
        gbFilter.Controls.Add(btnTampilkan);
        gbFilter.Controls.Add(cmbStatus);
        gbFilter.Controls.Add(lblStatus);
        gbFilter.Controls.Add(cmbJadwal);
        gbFilter.Controls.Add(lblJadwal);
        gbFilter.Controls.Add(dtpSampai);
        gbFilter.Controls.Add(lblSampai);
        gbFilter.Controls.Add(dtpMulai);
        gbFilter.Controls.Add(lblMulai);
        gbFilter.Location = new Point(28, 94);
        gbFilter.Name = "gbFilter";
        gbFilter.Size = new Size(1240, 118);
        gbFilter.TabIndex = 1;
        gbFilter.TabStop = false;
        gbFilter.Text = "Filter";
        // 
        // btnTampilkan
        // 
        btnTampilkan.BackColor = Color.DodgerBlue;
        btnTampilkan.FlatStyle = FlatStyle.Flat;
        btnTampilkan.ForeColor = Color.White;
        btnTampilkan.Location = new Point(1084, 47);
        btnTampilkan.Name = "btnTampilkan";
        btnTampilkan.Size = new Size(120, 40);
        btnTampilkan.TabIndex = 8;
        btnTampilkan.Text = "Tampilkan";
        btnTampilkan.UseVisualStyleBackColor = false;
        // 
        // cmbStatus
        // 
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbStatus.FormattingEnabled = true;
        cmbStatus.Location = new Point(900, 54);
        cmbStatus.Name = "cmbStatus";
        cmbStatus.Size = new Size(140, 28);
        cmbStatus.TabIndex = 7;
        // 
        // lblStatus
        // 
        lblStatus.AutoSize = true;
        lblStatus.Location = new Point(840, 58);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(49, 20);
        lblStatus.TabIndex = 6;
        lblStatus.Text = "Status";
        // 
        // cmbJadwal
        // 
        cmbJadwal.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbJadwal.FormattingEnabled = true;
        cmbJadwal.Location = new Point(570, 54);
        cmbJadwal.Name = "cmbJadwal";
        cmbJadwal.Size = new Size(230, 28);
        cmbJadwal.TabIndex = 5;
        // 
        // lblJadwal
        // 
        lblJadwal.AutoSize = true;
        lblJadwal.Location = new Point(500, 58);
        lblJadwal.Name = "lblJadwal";
        lblJadwal.Size = new Size(53, 20);
        lblJadwal.TabIndex = 4;
        lblJadwal.Text = "Jadwal";
        // 
        // dtpSampai
        // 
        dtpSampai.CustomFormat = "dd/MM/yyyy";
        dtpSampai.Format = DateTimePickerFormat.Custom;
        dtpSampai.Location = new Point(330, 54);
        dtpSampai.Name = "dtpSampai";
        dtpSampai.Size = new Size(130, 27);
        dtpSampai.TabIndex = 3;
        // 
        // lblSampai
        // 
        lblSampai.AutoSize = true;
        lblSampai.Location = new Point(260, 58);
        lblSampai.Name = "lblSampai";
        lblSampai.Size = new Size(58, 20);
        lblSampai.TabIndex = 2;
        lblSampai.Text = "Sampai";
        // 
        // dtpMulai
        // 
        dtpMulai.CustomFormat = "dd/MM/yyyy";
        dtpMulai.Format = DateTimePickerFormat.Custom;
        dtpMulai.Location = new Point(100, 54);
        dtpMulai.Name = "dtpMulai";
        dtpMulai.Size = new Size(130, 27);
        dtpMulai.TabIndex = 1;
        // 
        // lblMulai
        // 
        lblMulai.AutoSize = true;
        lblMulai.Location = new Point(30, 58);
        lblMulai.Name = "lblMulai";
        lblMulai.Size = new Size(46, 20);
        lblMulai.TabIndex = 0;
        lblMulai.Text = "Mulai";
        // 
        // lblTotalTransaksi
        // 
        lblTotalTransaksi.AutoSize = true;
        lblTotalTransaksi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTotalTransaksi.ForeColor = Color.Navy;
        lblTotalTransaksi.Location = new Point(28, 238);
        lblTotalTransaksi.Name = "lblTotalTransaksi";
        lblTotalTransaksi.Size = new Size(144, 25);
        lblTotalTransaksi.TabIndex = 2;
        lblTotalTransaksi.Text = "Total Transaksi";
        // 
        // lblTotalTransaksiValue
        // 
        lblTotalTransaksiValue.AutoSize = true;
        lblTotalTransaksiValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTotalTransaksiValue.Location = new Point(28, 266);
        lblTotalTransaksiValue.Name = "lblTotalTransaksiValue";
        lblTotalTransaksiValue.Size = new Size(35, 41);
        lblTotalTransaksiValue.TabIndex = 3;
        lblTotalTransaksiValue.Text = "0";
        // 
        // lblTotalPenumpang
        // 
        lblTotalPenumpang.AutoSize = true;
        lblTotalPenumpang.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTotalPenumpang.ForeColor = Color.Navy;
        lblTotalPenumpang.Location = new Point(320, 238);
        lblTotalPenumpang.Name = "lblTotalPenumpang";
        lblTotalPenumpang.Size = new Size(170, 25);
        lblTotalPenumpang.TabIndex = 4;
        lblTotalPenumpang.Text = "Tiket Terjual";
        // 
        // lblTotalPenumpangValue
        // 
        lblTotalPenumpangValue.AutoSize = true;
        lblTotalPenumpangValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTotalPenumpangValue.Location = new Point(320, 266);
        lblTotalPenumpangValue.Name = "lblTotalPenumpangValue";
        lblTotalPenumpangValue.Size = new Size(35, 41);
        lblTotalPenumpangValue.TabIndex = 5;
        lblTotalPenumpangValue.Text = "0";
        // 
        // lblTotalPendapatan
        // 
        lblTotalPendapatan.AutoSize = true;
        lblTotalPendapatan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTotalPendapatan.ForeColor = Color.Navy;
        lblTotalPendapatan.Location = new Point(612, 238);
        lblTotalPendapatan.Name = "lblTotalPendapatan";
        lblTotalPendapatan.Size = new Size(181, 25);
        lblTotalPendapatan.TabIndex = 6;
        lblTotalPendapatan.Text = "Total Pendapatan";
        // 
        // lblTotalPendapatanValue
        // 
        lblTotalPendapatanValue.AutoSize = true;
        lblTotalPendapatanValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTotalPendapatanValue.Location = new Point(612, 266);
        lblTotalPendapatanValue.Name = "lblTotalPendapatanValue";
        lblTotalPendapatanValue.Size = new Size(88, 41);
        lblTotalPendapatanValue.TabIndex = 7;
        lblTotalPendapatanValue.Text = "Rp 0";
        // 
        // lblTransaksi
        // 
        lblTransaksi.AutoSize = true;
        lblTransaksi.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTransaksi.ForeColor = Color.Navy;
        lblTransaksi.Location = new Point(28, 336);
        lblTransaksi.Name = "lblTransaksi";
        lblTransaksi.Size = new Size(193, 32);
        lblTransaksi.TabIndex = 8;
        lblTransaksi.Text = "Daftar Transaksi";
        // 
        // dgvTransaksi
        // 
        dgvTransaksi.AllowUserToAddRows = false;
        dgvTransaksi.AllowUserToDeleteRows = false;
        dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvTransaksi.BackgroundColor = Color.White;
        dgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvTransaksi.Columns.AddRange(new DataGridViewColumn[] { ID, TanggalTransaksi, NamaAkun, KodePenerbangan, Rute, JumlahPenumpang, TotalHarga, KodePromo });
        dgvTransaksi.Location = new Point(28, 382);
        dgvTransaksi.Name = "dgvTransaksi";
        dgvTransaksi.ReadOnly = true;
        dgvTransaksi.RowHeadersVisible = false;
        dgvTransaksi.RowHeadersWidth = 51;
        dgvTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvTransaksi.Size = new Size(1240, 300);
        dgvTransaksi.TabIndex = 9;
        // 
        // ID
        // 
        ID.HeaderText = "ID";
        ID.MinimumWidth = 6;
        ID.Name = "ID";
        ID.ReadOnly = true;
        // 
        // TanggalTransaksi
        // 
        TanggalTransaksi.HeaderText = "Tanggal";
        TanggalTransaksi.MinimumWidth = 6;
        TanggalTransaksi.Name = "TanggalTransaksi";
        TanggalTransaksi.ReadOnly = true;
        // 
        // NamaAkun
        // 
        NamaAkun.HeaderText = "Customer";
        NamaAkun.MinimumWidth = 6;
        NamaAkun.Name = "NamaAkun";
        NamaAkun.ReadOnly = true;
        // 
        // KodePenerbangan
        // 
        KodePenerbangan.HeaderText = "Kode";
        KodePenerbangan.MinimumWidth = 6;
        KodePenerbangan.Name = "KodePenerbangan";
        KodePenerbangan.ReadOnly = true;
        // 
        // Rute
        // 
        Rute.HeaderText = "Rute";
        Rute.MinimumWidth = 6;
        Rute.Name = "Rute";
        Rute.ReadOnly = true;
        // 
        // JumlahPenumpang
        // 
        JumlahPenumpang.HeaderText = "Penumpang";
        JumlahPenumpang.MinimumWidth = 6;
        JumlahPenumpang.Name = "JumlahPenumpang";
        JumlahPenumpang.ReadOnly = true;
        // 
        // TotalHarga
        // 
        TotalHarga.HeaderText = "Total";
        TotalHarga.MinimumWidth = 6;
        TotalHarga.Name = "TotalHarga";
        TotalHarga.ReadOnly = true;
        // 
        // KodePromo
        // 
        KodePromo.HeaderText = "Promo";
        KodePromo.MinimumWidth = 6;
        KodePromo.Name = "KodePromo";
        KodePromo.ReadOnly = true;
        // 
        // lblRutePopuler
        // 
        lblRutePopuler.AutoSize = true;
        lblRutePopuler.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblRutePopuler.ForeColor = Color.Navy;
        lblRutePopuler.Location = new Point(28, 720);
        lblRutePopuler.Name = "lblRutePopuler";
        lblRutePopuler.Size = new Size(157, 32);
        lblRutePopuler.TabIndex = 10;
        lblRutePopuler.Text = "Rute Populer";
        // 
        // dgvRutePopuler
        // 
        dgvRutePopuler.AllowUserToAddRows = false;
        dgvRutePopuler.AllowUserToDeleteRows = false;
        dgvRutePopuler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvRutePopuler.BackgroundColor = Color.White;
        dgvRutePopuler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvRutePopuler.Columns.AddRange(new DataGridViewColumn[] { RutePopuler, TotalTransaksiRute, TotalPenumpangRute, TotalPendapatan });
        dgvRutePopuler.Location = new Point(28, 766);
        dgvRutePopuler.Name = "dgvRutePopuler";
        dgvRutePopuler.ReadOnly = true;
        dgvRutePopuler.RowHeadersVisible = false;
        dgvRutePopuler.RowHeadersWidth = 51;
        dgvRutePopuler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvRutePopuler.Size = new Size(1240, 220);
        dgvRutePopuler.TabIndex = 11;
        // 
        // RutePopuler
        // 
        RutePopuler.HeaderText = "Rute";
        RutePopuler.MinimumWidth = 6;
        RutePopuler.Name = "RutePopuler";
        RutePopuler.ReadOnly = true;
        // 
        // TotalTransaksiRute
        // 
        TotalTransaksiRute.HeaderText = "Transaksi";
        TotalTransaksiRute.MinimumWidth = 6;
        TotalTransaksiRute.Name = "TotalTransaksiRute";
        TotalTransaksiRute.ReadOnly = true;
        // 
        // TotalPenumpangRute
        // 
        TotalPenumpangRute.HeaderText = "Penumpang";
        TotalPenumpangRute.MinimumWidth = 6;
        TotalPenumpangRute.Name = "TotalPenumpangRute";
        TotalPenumpangRute.ReadOnly = true;
        // 
        // TotalPendapatan
        // 
        TotalPendapatan.HeaderText = "Pendapatan";
        TotalPendapatan.MinimumWidth = 6;
        TotalPendapatan.Name = "TotalPendapatan";
        TotalPendapatan.ReadOnly = true;
        // 
        // MaskapaiTransactionReportForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(1375, 1050);
        Controls.Add(dgvRutePopuler);
        Controls.Add(lblRutePopuler);
        Controls.Add(dgvTransaksi);
        Controls.Add(lblTransaksi);
        Controls.Add(lblTotalPendapatanValue);
        Controls.Add(lblTotalPendapatan);
        Controls.Add(lblTotalPenumpangValue);
        Controls.Add(lblTotalPenumpang);
        Controls.Add(lblTotalTransaksiValue);
        Controls.Add(lblTotalTransaksi);
        Controls.Add(gbFilter);
        Controls.Add(lblTitle);
        FormBorderStyle = FormBorderStyle.None;
        Name = "MaskapaiTransactionReportForm";
        Text = "MaskapaiTransactionReportForm";
        gbFilter.ResumeLayout(false);
        gbFilter.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTransaksi).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvRutePopuler).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitle;
    private GroupBox gbFilter;
    private Button btnTampilkan;
    private ComboBox cmbStatus;
    private Label lblStatus;
    private ComboBox cmbJadwal;
    private Label lblJadwal;
    private DateTimePicker dtpSampai;
    private Label lblSampai;
    private DateTimePicker dtpMulai;
    private Label lblMulai;
    private Label lblTotalTransaksi;
    private Label lblTotalTransaksiValue;
    private Label lblTotalPenumpang;
    private Label lblTotalPenumpangValue;
    private Label lblTotalPendapatan;
    private Label lblTotalPendapatanValue;
    private Label lblTransaksi;
    private DataGridView dgvTransaksi;
    private DataGridViewTextBoxColumn ID;
    private DataGridViewTextBoxColumn TanggalTransaksi;
    private DataGridViewTextBoxColumn NamaAkun;
    private DataGridViewTextBoxColumn KodePenerbangan;
    private DataGridViewTextBoxColumn Rute;
    private DataGridViewTextBoxColumn JumlahPenumpang;
    private DataGridViewTextBoxColumn TotalHarga;
    private DataGridViewTextBoxColumn KodePromo;
    private Label lblRutePopuler;
    private DataGridView dgvRutePopuler;
    private DataGridViewTextBoxColumn RutePopuler;
    private DataGridViewTextBoxColumn TotalTransaksiRute;
    private DataGridViewTextBoxColumn TotalPenumpangRute;
    private DataGridViewTextBoxColumn TotalPendapatan;
}
