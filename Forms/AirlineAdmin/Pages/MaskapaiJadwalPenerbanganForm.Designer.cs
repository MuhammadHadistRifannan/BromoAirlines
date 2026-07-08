namespace BromoAirlines.Forms.AirlineAdmin.Pages;

partial class MaskapaiJadwalPenerbanganForm
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
        gbJadwal = new GroupBox();
        lblRupiahPrefix = new Label();
        numHarga = new NumericUpDown();
        lblHarga = new Label();
        numDurasi = new NumericUpDown();
        lblDurasi = new Label();
        dtpKeberangkatan = new DateTimePicker();
        lblTanggal = new Label();
        cmbBandaraTujuan = new ComboBox();
        lblBandaraTujuan = new Label();
        cmbBandaraKeberangkatan = new ComboBox();
        lblBandaraKeberangkatan = new Label();
        btnReset = new Button();
        btnHapus = new Button();
        btnEdit = new Button();
        btnTambah = new Button();
        txtKodePenerbangan = new TextBox();
        lblKodePenerbangan = new Label();
        lblDaftarJadwal = new Label();
        txtCariJadwal = new TextBox();
        dgvJadwal = new DataGridView();
        ID = new DataGridViewTextBoxColumn();
        KodePenerbangan = new DataGridViewTextBoxColumn();
        BandaraKeberangkatanID = new DataGridViewTextBoxColumn();
        BandaraKeberangkatan = new DataGridViewTextBoxColumn();
        BandaraTujuanID = new DataGridViewTextBoxColumn();
        BandaraTujuan = new DataGridViewTextBoxColumn();
        TanggalWaktuKeberangkatan = new DataGridViewTextBoxColumn();
        DurasiPenerbangan = new DataGridViewTextBoxColumn();
        HargaPerTiket = new DataGridViewTextBoxColumn();
        gbJadwal.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numHarga).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numDurasi).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvJadwal).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblTitle.ForeColor = Color.Navy;
        lblTitle.Location = new Point(28, 24);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(530, 50);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Jadwal Penerbangan";
        // 
        // gbJadwal
        // 
        gbJadwal.Controls.Add(lblRupiahPrefix);
        gbJadwal.Controls.Add(numHarga);
        gbJadwal.Controls.Add(lblHarga);
        gbJadwal.Controls.Add(numDurasi);
        gbJadwal.Controls.Add(lblDurasi);
        gbJadwal.Controls.Add(dtpKeberangkatan);
        gbJadwal.Controls.Add(lblTanggal);
        gbJadwal.Controls.Add(cmbBandaraTujuan);
        gbJadwal.Controls.Add(lblBandaraTujuan);
        gbJadwal.Controls.Add(cmbBandaraKeberangkatan);
        gbJadwal.Controls.Add(lblBandaraKeberangkatan);
        gbJadwal.Controls.Add(btnReset);
        gbJadwal.Controls.Add(btnHapus);
        gbJadwal.Controls.Add(btnEdit);
        gbJadwal.Controls.Add(btnTambah);
        gbJadwal.Controls.Add(txtKodePenerbangan);
        gbJadwal.Controls.Add(lblKodePenerbangan);
        gbJadwal.Location = new Point(28, 94);
        gbJadwal.Name = "gbJadwal";
        gbJadwal.Size = new Size(1240, 300);
        gbJadwal.TabIndex = 1;
        gbJadwal.TabStop = false;
        gbJadwal.Text = "Data Jadwal";
        // 
        // lblRupiahPrefix
        // 
        lblRupiahPrefix.AutoSize = true;
        lblRupiahPrefix.Location = new Point(785, 158);
        lblRupiahPrefix.Name = "lblRupiahPrefix";
        lblRupiahPrefix.Size = new Size(29, 20);
        lblRupiahPrefix.TabIndex = 16;
        lblRupiahPrefix.Text = "Rp";
        // 
        // numHarga
        // 
        numHarga.Location = new Point(825, 154);
        numHarga.Maximum = new decimal(new int[] { 2000000000, 0, 0, 0 });
        numHarga.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numHarga.Name = "numHarga";
        numHarga.Size = new Size(180, 27);
        numHarga.TabIndex = 13;
        numHarga.ThousandsSeparator = true;
        numHarga.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblHarga
        // 
        lblHarga.AutoSize = true;
        lblHarga.Location = new Point(600, 158);
        lblHarga.Name = "lblHarga";
        lblHarga.Size = new Size(114, 20);
        lblHarga.TabIndex = 12;
        lblHarga.Text = "Harga Per Tiket";
        // 
        // numDurasi
        // 
        numDurasi.Location = new Point(785, 104);
        numDurasi.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        numDurasi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numDurasi.Name = "numDurasi";
        numDurasi.Size = new Size(120, 27);
        numDurasi.TabIndex = 11;
        numDurasi.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblDurasi
        // 
        lblDurasi.AutoSize = true;
        lblDurasi.Location = new Point(600, 108);
        lblDurasi.Name = "lblDurasi";
        lblDurasi.Size = new Size(104, 20);
        lblDurasi.TabIndex = 10;
        lblDurasi.Text = "Durasi (menit)";
        // 
        // dtpKeberangkatan
        // 
        dtpKeberangkatan.CustomFormat = "dd/MM/yyyy HH:mm";
        dtpKeberangkatan.Format = DateTimePickerFormat.Custom;
        dtpKeberangkatan.Location = new Point(785, 54);
        dtpKeberangkatan.Name = "dtpKeberangkatan";
        dtpKeberangkatan.Size = new Size(220, 27);
        dtpKeberangkatan.TabIndex = 9;
        // 
        // lblTanggal
        // 
        lblTanggal.AutoSize = true;
        lblTanggal.Location = new Point(600, 58);
        lblTanggal.Name = "lblTanggal";
        lblTanggal.Size = new Size(130, 20);
        lblTanggal.TabIndex = 8;
        lblTanggal.Text = "Tanggal dan Jam";
        // 
        // cmbBandaraTujuan
        // 
        cmbBandaraTujuan.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbBandaraTujuan.FormattingEnabled = true;
        cmbBandaraTujuan.Location = new Point(230, 154);
        cmbBandaraTujuan.Name = "cmbBandaraTujuan";
        cmbBandaraTujuan.Size = new Size(300, 28);
        cmbBandaraTujuan.TabIndex = 5;
        // 
        // lblBandaraTujuan
        // 
        lblBandaraTujuan.AutoSize = true;
        lblBandaraTujuan.Location = new Point(30, 158);
        lblBandaraTujuan.Name = "lblBandaraTujuan";
        lblBandaraTujuan.Size = new Size(111, 20);
        lblBandaraTujuan.TabIndex = 4;
        lblBandaraTujuan.Text = "Bandara Tujuan";
        // 
        // cmbBandaraKeberangkatan
        // 
        cmbBandaraKeberangkatan.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbBandaraKeberangkatan.FormattingEnabled = true;
        cmbBandaraKeberangkatan.Location = new Point(230, 104);
        cmbBandaraKeberangkatan.Name = "cmbBandaraKeberangkatan";
        cmbBandaraKeberangkatan.Size = new Size(300, 28);
        cmbBandaraKeberangkatan.TabIndex = 3;
        // 
        // lblBandaraKeberangkatan
        // 
        lblBandaraKeberangkatan.AutoSize = true;
        lblBandaraKeberangkatan.Location = new Point(30, 108);
        lblBandaraKeberangkatan.Name = "lblBandaraKeberangkatan";
        lblBandaraKeberangkatan.Size = new Size(168, 20);
        lblBandaraKeberangkatan.TabIndex = 2;
        lblBandaraKeberangkatan.Text = "Bandara Keberangkatan";
        // 
        // btnReset
        // 
        btnReset.BackColor = Color.Azure;
        btnReset.FlatStyle = FlatStyle.Flat;
        btnReset.ForeColor = Color.Gray;
        btnReset.Location = new Point(1095, 236);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(110, 40);
        btnReset.TabIndex = 17;
        btnReset.Text = "Reset";
        btnReset.UseVisualStyleBackColor = false;
        // 
        // btnHapus
        // 
        btnHapus.BackColor = Color.Crimson;
        btnHapus.FlatStyle = FlatStyle.Flat;
        btnHapus.ForeColor = Color.White;
        btnHapus.Location = new Point(965, 236);
        btnHapus.Name = "btnHapus";
        btnHapus.Size = new Size(110, 40);
        btnHapus.TabIndex = 16;
        btnHapus.Text = "Hapus";
        btnHapus.UseVisualStyleBackColor = false;
        // 
        // btnEdit
        // 
        btnEdit.BackColor = Color.ForestGreen;
        btnEdit.FlatStyle = FlatStyle.Flat;
        btnEdit.ForeColor = Color.White;
        btnEdit.Location = new Point(835, 236);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(110, 40);
        btnEdit.TabIndex = 15;
        btnEdit.Text = "Edit";
        btnEdit.UseVisualStyleBackColor = false;
        // 
        // btnTambah
        // 
        btnTambah.BackColor = Color.DodgerBlue;
        btnTambah.FlatStyle = FlatStyle.Flat;
        btnTambah.ForeColor = Color.White;
        btnTambah.Location = new Point(705, 236);
        btnTambah.Name = "btnTambah";
        btnTambah.Size = new Size(110, 40);
        btnTambah.TabIndex = 14;
        btnTambah.Text = "Tambah";
        btnTambah.UseVisualStyleBackColor = false;
        // 
        // txtKodePenerbangan
        // 
        txtKodePenerbangan.BorderStyle = BorderStyle.FixedSingle;
        txtKodePenerbangan.Location = new Point(230, 54);
        txtKodePenerbangan.MaxLength = 10;
        txtKodePenerbangan.Name = "txtKodePenerbangan";
        txtKodePenerbangan.Size = new Size(180, 27);
        txtKodePenerbangan.TabIndex = 1;
        // 
        // lblKodePenerbangan
        // 
        lblKodePenerbangan.AutoSize = true;
        lblKodePenerbangan.Location = new Point(30, 58);
        lblKodePenerbangan.Name = "lblKodePenerbangan";
        lblKodePenerbangan.Size = new Size(132, 20);
        lblKodePenerbangan.TabIndex = 0;
        lblKodePenerbangan.Text = "Kode Penerbangan";
        // 
        // lblDaftarJadwal
        // 
        lblDaftarJadwal.AutoSize = true;
        lblDaftarJadwal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblDaftarJadwal.ForeColor = Color.Navy;
        lblDaftarJadwal.Location = new Point(28, 426);
        lblDaftarJadwal.Name = "lblDaftarJadwal";
        lblDaftarJadwal.Size = new Size(289, 32);
        lblDaftarJadwal.TabIndex = 2;
        lblDaftarJadwal.Text = "Daftar Jadwal Maskapai";
        // 
        // txtCariJadwal
        // 
        txtCariJadwal.BorderStyle = BorderStyle.FixedSingle;
        txtCariJadwal.Location = new Point(1018, 431);
        txtCariJadwal.Name = "txtCariJadwal";
        txtCariJadwal.PlaceholderText = "Cari jadwal...";
        txtCariJadwal.Size = new Size(250, 27);
        txtCariJadwal.TabIndex = 3;
        // 
        // dgvJadwal
        // 
        dgvJadwal.AllowUserToAddRows = false;
        dgvJadwal.AllowUserToDeleteRows = false;
        dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvJadwal.BackgroundColor = Color.White;
        dgvJadwal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvJadwal.Columns.AddRange(new DataGridViewColumn[] { ID, KodePenerbangan, BandaraKeberangkatanID, BandaraKeberangkatan, BandaraTujuanID, BandaraTujuan, TanggalWaktuKeberangkatan, DurasiPenerbangan, HargaPerTiket });
        dgvJadwal.Location = new Point(28, 476);
        dgvJadwal.Name = "dgvJadwal";
        dgvJadwal.ReadOnly = true;
        dgvJadwal.RowHeadersVisible = false;
        dgvJadwal.RowHeadersWidth = 51;
        dgvJadwal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvJadwal.Size = new Size(1240, 320);
        dgvJadwal.TabIndex = 4;
        // 
        // ID
        // 
        ID.HeaderText = "ID";
        ID.MinimumWidth = 6;
        ID.Name = "ID";
        ID.ReadOnly = true;
        // 
        // KodePenerbangan
        // 
        KodePenerbangan.HeaderText = "Kode";
        KodePenerbangan.MinimumWidth = 6;
        KodePenerbangan.Name = "KodePenerbangan";
        KodePenerbangan.ReadOnly = true;
        // 
        // BandaraKeberangkatanID
        // 
        BandaraKeberangkatanID.HeaderText = "BandaraKeberangkatanID";
        BandaraKeberangkatanID.MinimumWidth = 6;
        BandaraKeberangkatanID.Name = "BandaraKeberangkatanID";
        BandaraKeberangkatanID.ReadOnly = true;
        BandaraKeberangkatanID.Visible = false;
        // 
        // BandaraKeberangkatan
        // 
        BandaraKeberangkatan.HeaderText = "Keberangkatan";
        BandaraKeberangkatan.MinimumWidth = 6;
        BandaraKeberangkatan.Name = "BandaraKeberangkatan";
        BandaraKeberangkatan.ReadOnly = true;
        // 
        // BandaraTujuanID
        // 
        BandaraTujuanID.HeaderText = "BandaraTujuanID";
        BandaraTujuanID.MinimumWidth = 6;
        BandaraTujuanID.Name = "BandaraTujuanID";
        BandaraTujuanID.ReadOnly = true;
        BandaraTujuanID.Visible = false;
        // 
        // BandaraTujuan
        // 
        BandaraTujuan.HeaderText = "Tujuan";
        BandaraTujuan.MinimumWidth = 6;
        BandaraTujuan.Name = "BandaraTujuan";
        BandaraTujuan.ReadOnly = true;
        // 
        // TanggalWaktuKeberangkatan
        // 
        TanggalWaktuKeberangkatan.HeaderText = "Tanggal";
        TanggalWaktuKeberangkatan.MinimumWidth = 6;
        TanggalWaktuKeberangkatan.Name = "TanggalWaktuKeberangkatan";
        TanggalWaktuKeberangkatan.ReadOnly = true;
        // 
        // DurasiPenerbangan
        // 
        DurasiPenerbangan.HeaderText = "Durasi";
        DurasiPenerbangan.MinimumWidth = 6;
        DurasiPenerbangan.Name = "DurasiPenerbangan";
        DurasiPenerbangan.ReadOnly = true;
        // 
        // HargaPerTiket
        // 
        HargaPerTiket.HeaderText = "Harga";
        HargaPerTiket.MinimumWidth = 6;
        HargaPerTiket.Name = "HargaPerTiket";
        HargaPerTiket.ReadOnly = true;
        // 
        // MaskapaiJadwalPenerbanganForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(1375, 1050);
        Controls.Add(dgvJadwal);
        Controls.Add(txtCariJadwal);
        Controls.Add(lblDaftarJadwal);
        Controls.Add(gbJadwal);
        Controls.Add(lblTitle);
        FormBorderStyle = FormBorderStyle.None;
        Name = "MaskapaiJadwalPenerbanganForm";
        Text = "MaskapaiJadwalPenerbanganForm";
        gbJadwal.ResumeLayout(false);
        gbJadwal.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numHarga).EndInit();
        ((System.ComponentModel.ISupportInitialize)numDurasi).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvJadwal).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitle;
    private GroupBox gbJadwal;
    private Label lblRupiahPrefix;
    private TextBox txtKodePenerbangan;
    private Label lblKodePenerbangan;
    private ComboBox cmbBandaraKeberangkatan;
    private Label lblBandaraKeberangkatan;
    private ComboBox cmbBandaraTujuan;
    private Label lblBandaraTujuan;
    private DateTimePicker dtpKeberangkatan;
    private Label lblTanggal;
    private NumericUpDown numDurasi;
    private Label lblDurasi;
    private NumericUpDown numHarga;
    private Label lblHarga;
    private Button btnReset;
    private Button btnHapus;
    private Button btnEdit;
    private Button btnTambah;
    private Label lblDaftarJadwal;
    private TextBox txtCariJadwal;
    private DataGridView dgvJadwal;
    private DataGridViewTextBoxColumn ID;
    private DataGridViewTextBoxColumn KodePenerbangan;
    private DataGridViewTextBoxColumn BandaraKeberangkatanID;
    private DataGridViewTextBoxColumn BandaraKeberangkatan;
    private DataGridViewTextBoxColumn BandaraTujuanID;
    private DataGridViewTextBoxColumn BandaraTujuan;
    private DataGridViewTextBoxColumn TanggalWaktuKeberangkatan;
    private DataGridViewTextBoxColumn DurasiPenerbangan;
    private DataGridViewTextBoxColumn HargaPerTiket;
}
