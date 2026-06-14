
namespace BromoAirlines.Forms;

partial class SearchFlightForm
{
    private System.ComponentModel.IContainer components = null!;
    private DataGridView flightsGridView = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            components?.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitle = new Label();
        gbSearch = new GroupBox();
        btnReset = new Button();
        btnSearch = new Button();
        dtpTanggal = new DateTimePicker();
        lblTanggal = new Label();
        cmbMaskapai = new ComboBox();
        lblMaskapai = new Label();
        cmbTujuan = new ComboBox();
        lblTujuan = new Label();
        cmbKeberangkatan = new ComboBox();
        lblKeberangkatan = new Label();
        txtKodePenerbangan = new TextBox();
        lblKode = new Label();
        lblHasil = new Label();
        panel1 = new Panel();
        dgvFlight = new DataGridView();
        colID = new DataGridViewTextBoxColumn();
        colKode = new DataGridViewTextBoxColumn();
        colAsal = new DataGridViewTextBoxColumn();
        colTujuan = new DataGridViewTextBoxColumn();
        colMaskapai = new DataGridViewTextBoxColumn();
        colJadwal = new DataGridViewTextBoxColumn();
        colDurasi = new DataGridViewTextBoxColumn();
        colHarga = new DataGridViewTextBoxColumn();
        gbSearch.SuspendLayout();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvFlight).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitle.ForeColor = Color.Navy;
        lblTitle.Location = new Point(62, 38);
        lblTitle.Margin = new Padding(4, 0, 4, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(604, 65);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "SEARCH FLIGHT - ADMIN";
        // 
        // gbSearch
        // 
        gbSearch.Controls.Add(btnReset);
        gbSearch.Controls.Add(btnSearch);
        gbSearch.Controls.Add(dtpTanggal);
        gbSearch.Controls.Add(lblTanggal);
        gbSearch.Controls.Add(cmbMaskapai);
        gbSearch.Controls.Add(lblMaskapai);
        gbSearch.Controls.Add(cmbTujuan);
        gbSearch.Controls.Add(lblTujuan);
        gbSearch.Controls.Add(cmbKeberangkatan);
        gbSearch.Controls.Add(lblKeberangkatan);
        gbSearch.Controls.Add(txtKodePenerbangan);
        gbSearch.Controls.Add(lblKode);
        gbSearch.Location = new Point(38, 112);
        gbSearch.Margin = new Padding(4);
        gbSearch.Name = "gbSearch";
        gbSearch.Padding = new Padding(4);
        gbSearch.Size = new Size(1150, 338);
        gbSearch.TabIndex = 1;
        gbSearch.TabStop = false;
        gbSearch.Text = "Data Pencarian";
        // 
        // btnReset
        // 
        btnReset.BackColor = Color.DodgerBlue;
        btnReset.ForeColor = Color.White;
        btnReset.Location = new Point(550, 288);
        btnReset.Margin = new Padding(4);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(150, 44);
        btnReset.TabIndex = 11;
        btnReset.Text = "Reset";
        btnReset.UseVisualStyleBackColor = false;
        // 
        // btnSearch
        // 
        btnSearch.BackColor = Color.DodgerBlue;
        btnSearch.ForeColor = Color.White;
        btnSearch.Location = new Point(375, 288);
        btnSearch.Margin = new Padding(4);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(150, 44);
        btnSearch.TabIndex = 10;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = false;
        // 
        // dtpTanggal
        // 
        dtpTanggal.Format = DateTimePickerFormat.Short;
        dtpTanggal.Location = new Point(288, 244);
        dtpTanggal.Margin = new Padding(4);
        dtpTanggal.Name = "dtpTanggal";
        dtpTanggal.Size = new Size(312, 31);
        dtpTanggal.TabIndex = 9;
        // 
        // lblTanggal
        // 
        lblTanggal.AutoSize = true;
        lblTanggal.Location = new Point(38, 250);
        lblTanggal.Margin = new Padding(4, 0, 4, 0);
        lblTanggal.Name = "lblTanggal";
        lblTanggal.Size = new Size(157, 25);
        lblTanggal.TabIndex = 8;
        lblTanggal.Text = "Tanggal Berangkat";
        // 
        // cmbMaskapai
        // 
        cmbMaskapai.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbMaskapai.FormattingEnabled = true;
        cmbMaskapai.Location = new Point(288, 194);
        cmbMaskapai.Margin = new Padding(4);
        cmbMaskapai.Name = "cmbMaskapai";
        cmbMaskapai.Size = new Size(436, 33);
        cmbMaskapai.TabIndex = 7;
        // 
        // lblMaskapai
        // 
        lblMaskapai.AutoSize = true;
        lblMaskapai.Location = new Point(38, 200);
        lblMaskapai.Margin = new Padding(4, 0, 4, 0);
        lblMaskapai.Name = "lblMaskapai";
        lblMaskapai.Size = new Size(87, 25);
        lblMaskapai.TabIndex = 6;
        lblMaskapai.Text = "Maskapai";
        // 
        // cmbTujuan
        // 
        cmbTujuan.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTujuan.FormattingEnabled = true;
        cmbTujuan.Location = new Point(288, 144);
        cmbTujuan.Margin = new Padding(4);
        cmbTujuan.Name = "cmbTujuan";
        cmbTujuan.Size = new Size(436, 33);
        cmbTujuan.TabIndex = 5;
        // 
        // lblTujuan
        // 
        lblTujuan.AutoSize = true;
        lblTujuan.Location = new Point(38, 148);
        lblTujuan.Margin = new Padding(4, 0, 4, 0);
        lblTujuan.Name = "lblTujuan";
        lblTujuan.Size = new Size(133, 25);
        lblTujuan.TabIndex = 4;
        lblTujuan.Text = "Bandara Tujuan";
        // 
        // cmbKeberangkatan
        // 
        cmbKeberangkatan.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbKeberangkatan.FormattingEnabled = true;
        cmbKeberangkatan.Location = new Point(288, 94);
        cmbKeberangkatan.Margin = new Padding(4);
        cmbKeberangkatan.Name = "cmbKeberangkatan";
        cmbKeberangkatan.Size = new Size(436, 33);
        cmbKeberangkatan.TabIndex = 3;
        // 
        // lblKeberangkatan
        // 
        lblKeberangkatan.AutoSize = true;
        lblKeberangkatan.Location = new Point(38, 100);
        lblKeberangkatan.Margin = new Padding(4, 0, 4, 0);
        lblKeberangkatan.Name = "lblKeberangkatan";
        lblKeberangkatan.Size = new Size(199, 25);
        lblKeberangkatan.TabIndex = 2;
        lblKeberangkatan.Text = "Bandara Keberangkatan";
        // 
        // txtKodePenerbangan
        // 
        txtKodePenerbangan.Location = new Point(288, 44);
        txtKodePenerbangan.Margin = new Padding(4);
        txtKodePenerbangan.Name = "txtKodePenerbangan";
        txtKodePenerbangan.Size = new Size(436, 31);
        txtKodePenerbangan.TabIndex = 1;
        txtKodePenerbangan.TextChanged += txtKodePenerbangan_TextChanged;
        // 
        // lblKode
        // 
        lblKode.AutoSize = true;
        lblKode.Location = new Point(38, 50);
        lblKode.Margin = new Padding(4, 0, 4, 0);
        lblKode.Name = "lblKode";
        lblKode.Size = new Size(161, 25);
        lblKode.TabIndex = 0;
        lblKode.Text = "Kode Penerbangan";
        // 
        // lblHasil
        // 
        lblHasil.AutoSize = true;
        lblHasil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblHasil.ForeColor = Color.Navy;
        lblHasil.Location = new Point(38, 462);
        lblHasil.Margin = new Padding(4, 0, 4, 0);
        lblHasil.Name = "lblHasil";
        lblHasil.Size = new Size(189, 32);
        lblHasil.TabIndex = 12;
        lblHasil.Text = "Hasil Pencarian";
        // 
        // panel1
        // 
        panel1.Controls.Add(dgvFlight);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(40, 658);
        panel1.Name = "panel1";
        panel1.Size = new Size(976, 343);
        panel1.TabIndex = 13;
        // 
        // dgvFlight
        // 
        dgvFlight.AllowUserToAddRows = false;
        dgvFlight.AllowUserToDeleteRows = false;
        dgvFlight.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        dgvFlight.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvFlight.Columns.AddRange(new DataGridViewColumn[] { colID, colKode, colAsal, colTujuan, colMaskapai, colJadwal, colDurasi, colHarga });
        dgvFlight.Dock = DockStyle.Bottom;
        dgvFlight.Location = new Point(0, 6);
        dgvFlight.Margin = new Padding(4);
        dgvFlight.Name = "dgvFlight";
        dgvFlight.ReadOnly = true;
        dgvFlight.RowHeadersVisible = false;
        dgvFlight.RowHeadersWidth = 51;
        dgvFlight.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvFlight.Size = new Size(976, 337);
        dgvFlight.TabIndex = 3;
        // 
        // colID
        // 
        colID.HeaderText = "ID";
        colID.MinimumWidth = 6;
        colID.Name = "colID";
        colID.ReadOnly = true;
        colID.Width = 66;
        // 
        // colKode
        // 
        colKode.HeaderText = "Kode Penerbangan";
        colKode.MinimumWidth = 6;
        colKode.Name = "colKode";
        colKode.ReadOnly = true;
        colKode.Width = 180;
        // 
        // colAsal
        // 
        colAsal.HeaderText = "Bandara Keberangkatan";
        colAsal.MinimumWidth = 6;
        colAsal.Name = "colAsal";
        colAsal.ReadOnly = true;
        colAsal.Width = 215;
        // 
        // colTujuan
        // 
        colTujuan.HeaderText = "Bandara Tujuan";
        colTujuan.MinimumWidth = 6;
        colTujuan.Name = "colTujuan";
        colTujuan.ReadOnly = true;
        colTujuan.Width = 155;
        // 
        // colMaskapai
        // 
        colMaskapai.HeaderText = "Maskapai";
        colMaskapai.MinimumWidth = 6;
        colMaskapai.Name = "colMaskapai";
        colMaskapai.ReadOnly = true;
        colMaskapai.Width = 123;
        // 
        // colJadwal
        // 
        colJadwal.HeaderText = "Tanggal Berangkat";
        colJadwal.MinimumWidth = 6;
        colJadwal.Name = "colJadwal";
        colJadwal.ReadOnly = true;
        colJadwal.Width = 177;
        // 
        // colDurasi
        // 
        colDurasi.HeaderText = "Durasi";
        colDurasi.MinimumWidth = 6;
        colDurasi.Name = "colDurasi";
        colDurasi.ReadOnly = true;
        colDurasi.Width = 98;
        // 
        // colHarga
        // 
        colHarga.HeaderText = "Harga Tiket";
        colHarga.MinimumWidth = 6;
        colHarga.Name = "colHarga";
        colHarga.ReadOnly = true;
        colHarga.Width = 127;
        // 
        // SearchFlightForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1056, 1047);
        Controls.Add(panel1);
        Controls.Add(lblHasil);
        Controls.Add(gbSearch);
        Controls.Add(lblTitle);
        FormBorderStyle = FormBorderStyle.None;
        Location = new Point(30, 400);
        Margin = new Padding(4, 5, 4, 5);
        Name = "SearchFlightForm";
        Padding = new Padding(40, 46, 40, 46);
        Load += SearchFlightForm_Load;
        gbSearch.ResumeLayout(false);
        gbSearch.PerformLayout();
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvFlight).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitle;
    private GroupBox gbSearch;
    private Label lblKode;
    private ComboBox cmbTujuan;
    private Label lblTujuan;
    private ComboBox cmbKeberangkatan;
    private Label lblKeberangkatan;
    private TextBox txtKodePenerbangan;
    private DateTimePicker dtpTanggal;
    private Label lblTanggal;
    private ComboBox cmbMaskapai;
    private Label lblMaskapai;
    private Button btnReset;
    private Button btnSearch;
    private Label lblHasil;
    private Panel panel1;
    private DataGridView dgvFlight;
    private DataGridViewTextBoxColumn colID;
    private DataGridViewTextBoxColumn colKode;
    private DataGridViewTextBoxColumn colAsal;
    private DataGridViewTextBoxColumn colTujuan;
    private DataGridViewTextBoxColumn colMaskapai;
    private DataGridViewTextBoxColumn colJadwal;
    private DataGridViewTextBoxColumn colDurasi;
    private DataGridViewTextBoxColumn colHarga;
}
