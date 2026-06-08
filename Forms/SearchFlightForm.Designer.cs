
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
        dgvFlight = new DataGridView();
        lblHasil = new Label();
        colID = new DataGridViewTextBoxColumn();
        colKode = new DataGridViewTextBoxColumn();
        colAsal = new DataGridViewTextBoxColumn();
        colTujuan = new DataGridViewTextBoxColumn();
        colMaskapai = new DataGridViewTextBoxColumn();
        colJadwal = new DataGridViewTextBoxColumn();
        colDurasi = new DataGridViewTextBoxColumn();
        colHarga = new DataGridViewTextBoxColumn();
        gbSearch.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvFlight).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitle.ForeColor = Color.Navy;
        lblTitle.Location = new Point(50, 30);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(503, 54);
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
        gbSearch.Location = new Point(30, 90);
        gbSearch.Name = "gbSearch";
        gbSearch.Size = new Size(920, 270);
        gbSearch.TabIndex = 1;
        gbSearch.TabStop = false;
        gbSearch.Text = "Data Pencarian";
        // 
        // btnReset
        // 
        btnReset.BackColor = Color.DodgerBlue;
        btnReset.ForeColor = Color.White;
        btnReset.Location = new Point(440, 230);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(120, 35);
        btnReset.TabIndex = 11;
        btnReset.Text = "Reset";
        btnReset.UseVisualStyleBackColor = false;
        // 
        // btnSearch
        // 
        btnSearch.BackColor = Color.DodgerBlue;
        btnSearch.ForeColor = Color.White;
        btnSearch.Location = new Point(300, 230);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(120, 35);
        btnSearch.TabIndex = 10;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = false;
        // 
        // dtpTanggal
        // 
        dtpTanggal.Format = DateTimePickerFormat.Short;
        dtpTanggal.Location = new Point(230, 195);
        dtpTanggal.Name = "dtpTanggal";
        dtpTanggal.Size = new Size(250, 27);
        dtpTanggal.TabIndex = 9;
        // 
        // lblTanggal
        // 
        lblTanggal.AutoSize = true;
        lblTanggal.Location = new Point(30, 200);
        lblTanggal.Name = "lblTanggal";
        lblTanggal.Size = new Size(132, 20);
        lblTanggal.TabIndex = 8;
        lblTanggal.Text = "Tanggal Berangkat";
        // 
        // cmbMaskapai
        // 
        cmbMaskapai.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbMaskapai.FormattingEnabled = true;
        cmbMaskapai.Location = new Point(230, 155);
        cmbMaskapai.Name = "cmbMaskapai";
        cmbMaskapai.Size = new Size(350, 28);
        cmbMaskapai.TabIndex = 7;
        // 
        // lblMaskapai
        // 
        lblMaskapai.AutoSize = true;
        lblMaskapai.Location = new Point(30, 160);
        lblMaskapai.Name = "lblMaskapai";
        lblMaskapai.Size = new Size(72, 20);
        lblMaskapai.TabIndex = 6;
        lblMaskapai.Text = "Maskapai";
        // 
        // cmbTujuan
        // 
        cmbTujuan.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTujuan.FormattingEnabled = true;
        cmbTujuan.Location = new Point(230, 115);
        cmbTujuan.Name = "cmbTujuan";
        cmbTujuan.Size = new Size(350, 28);
        cmbTujuan.TabIndex = 5;
        // 
        // lblTujuan
        // 
        lblTujuan.AutoSize = true;
        lblTujuan.Location = new Point(30, 118);
        lblTujuan.Name = "lblTujuan";
        lblTujuan.Size = new Size(112, 20);
        lblTujuan.TabIndex = 4;
        lblTujuan.Text = "Bandara Tujuan";
        // 
        // cmbKeberangkatan
        // 
        cmbKeberangkatan.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbKeberangkatan.FormattingEnabled = true;
        cmbKeberangkatan.Location = new Point(230, 75);
        cmbKeberangkatan.Name = "cmbKeberangkatan";
        cmbKeberangkatan.Size = new Size(350, 28);
        cmbKeberangkatan.TabIndex = 3;
        // 
        // lblKeberangkatan
        // 
        lblKeberangkatan.AutoSize = true;
        lblKeberangkatan.Location = new Point(30, 80);
        lblKeberangkatan.Name = "lblKeberangkatan";
        lblKeberangkatan.Size = new Size(168, 20);
        lblKeberangkatan.TabIndex = 2;
        lblKeberangkatan.Text = "Bandara Keberangkatan";
        // 
        // txtKodePenerbangan
        // 
        txtKodePenerbangan.Location = new Point(230, 35);
        txtKodePenerbangan.Name = "txtKodePenerbangan";
        txtKodePenerbangan.Size = new Size(350, 27);
        txtKodePenerbangan.TabIndex = 1;
        // 
        // lblKode
        // 
        lblKode.AutoSize = true;
        lblKode.Location = new Point(30, 40);
        lblKode.Name = "lblKode";
        lblKode.Size = new Size(134, 20);
        lblKode.TabIndex = 0;
        lblKode.Text = "Kode Penerbangan";
        // 
        // dgvFlight
        // 
        dgvFlight.AllowUserToAddRows = false;
        dgvFlight.AllowUserToDeleteRows = false;
        dgvFlight.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvFlight.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvFlight.Columns.AddRange(new DataGridViewColumn[] { colID, colKode, colAsal, colTujuan, colMaskapai, colJadwal, colDurasi, colHarga });
        dgvFlight.Location = new Point(30, 400);
        dgvFlight.Name = "dgvFlight";
        dgvFlight.ReadOnly = true;
        dgvFlight.RowHeadersVisible = false;
        dgvFlight.RowHeadersWidth = 51;
        dgvFlight.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvFlight.Size = new Size(920, 190);
        dgvFlight.TabIndex = 2;
        // 
        // lblHasil
        // 
        lblHasil.AutoSize = true;
        lblHasil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblHasil.ForeColor = Color.Navy;
        lblHasil.Location = new Point(30, 370);
        lblHasil.Name = "lblHasil";
        lblHasil.Size = new Size(157, 28);
        lblHasil.TabIndex = 12;
        lblHasil.Text = "Hasil Pencarian";
        // 
        // colID
        // 
        colID.HeaderText = "ID";
        colID.MinimumWidth = 6;
        colID.Name = "colID";
        colID.ReadOnly = true;
        // 
        // colKode
        // 
        colKode.HeaderText = "Kode Penerbangan";
        colKode.MinimumWidth = 6;
        colKode.Name = "colKode";
        colKode.ReadOnly = true;
        // 
        // colAsal
        // 
        colAsal.HeaderText = "Bandara Keberangkatan";
        colAsal.MinimumWidth = 6;
        colAsal.Name = "colAsal";
        colAsal.ReadOnly = true;
        // 
        // colTujuan
        // 
        colTujuan.HeaderText = "Bandara Tujuan";
        colTujuan.MinimumWidth = 6;
        colTujuan.Name = "colTujuan";
        colTujuan.ReadOnly = true;
        // 
        // colMaskapai
        // 
        colMaskapai.HeaderText = "Maskapai";
        colMaskapai.MinimumWidth = 6;
        colMaskapai.Name = "colMaskapai";
        colMaskapai.ReadOnly = true;
        // 
        // colJadwal
        // 
        colJadwal.HeaderText = "Tanggal Berangkat";
        colJadwal.MinimumWidth = 6;
        colJadwal.Name = "colJadwal";
        colJadwal.ReadOnly = true;
        // 
        // colDurasi
        // 
        colDurasi.HeaderText = "Durasi";
        colDurasi.MinimumWidth = 6;
        colDurasi.Name = "colDurasi";
        colDurasi.ReadOnly = true;
        // 
        // colHarga
        // 
        colHarga.HeaderText = "Harga Tiket";
        colHarga.MinimumWidth = 6;
        colHarga.Name = "colHarga";
        colHarga.ReadOnly = true;
        // 
        // SearchFlightForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblHasil);
        Controls.Add(dgvFlight);
        Controls.Add(gbSearch);
        Controls.Add(lblTitle);
        Location = new Point(30, 400);
        Margin = new Padding(3, 4, 3, 4);
        Name = "SearchFlightForm";
        Padding = new Padding(32, 37, 32, 37);
        Size = new Size(1189, 670);
        Load += SearchFlightForm_Load;
        gbSearch.ResumeLayout(false);
        gbSearch.PerformLayout();
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
    private DataGridView dgvFlight;
    private Label lblHasil;
    private DataGridViewTextBoxColumn colID;
    private DataGridViewTextBoxColumn colKode;
    private DataGridViewTextBoxColumn colAsal;
    private DataGridViewTextBoxColumn colTujuan;
    private DataGridViewTextBoxColumn colMaskapai;
    private DataGridViewTextBoxColumn colJadwal;
    private DataGridViewTextBoxColumn colDurasi;
    private DataGridViewTextBoxColumn colHarga;
}
