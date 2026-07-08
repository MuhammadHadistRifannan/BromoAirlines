namespace BromoAirlines.Forms.Users.Pages;

partial class SearchFlightForm
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
        panelSearch = new Panel();
        btnReset = new Button();
        btnSearch = new Button();
        numJumlahPenumpang = new NumericUpDown();
        lblJumlahPenumpang = new Label();
        cmbMaskapai = new ComboBox();
        lblMaskapai = new Label();
        chkFilterTanggal = new CheckBox();
        dtpTanggalBerangkat = new DateTimePicker();
        lblTanggalBerangkat = new Label();
        cmbBandaraTujuan = new ComboBox();
        lblBandaraTujuan = new Label();
        cmbBandaraAsal = new ComboBox();
        lblBandaraAsal = new Label();
        lblHasil = new Label();
        panelGrid = new Panel();
        btnDetail = new Button();
        gridFlight = new DataGridView();
        colKodePenerbangan = new DataGridViewTextBoxColumn();
        colMaskapai = new DataGridViewTextBoxColumn();
        colBandaraAsal = new DataGridViewTextBoxColumn();
        colBandaraTujuan = new DataGridViewTextBoxColumn();
        colTanggalBerangkat = new DataGridViewTextBoxColumn();
        colWaktuBerangkat = new DataGridViewTextBoxColumn();
        colDurasi = new DataGridViewTextBoxColumn();
        colHarga = new DataGridViewTextBoxColumn();
        colKursiTersedia = new DataGridViewTextBoxColumn();
        panelSearch.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numJumlahPenumpang).BeginInit();
        panelGrid.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridFlight).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        lblTitle.ForeColor = Color.Navy;
        lblTitle.Location = new Point(48, 42);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(355, 54);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Cari Penerbangan";
        // 
        // panelSearch
        // 
        panelSearch.BackColor = Color.White;
        panelSearch.Controls.Add(btnReset);
        panelSearch.Controls.Add(btnSearch);
        panelSearch.Controls.Add(numJumlahPenumpang);
        panelSearch.Controls.Add(lblJumlahPenumpang);
        panelSearch.Controls.Add(cmbMaskapai);
        panelSearch.Controls.Add(lblMaskapai);
        panelSearch.Controls.Add(chkFilterTanggal);
        panelSearch.Controls.Add(dtpTanggalBerangkat);
        panelSearch.Controls.Add(lblTanggalBerangkat);
        panelSearch.Controls.Add(cmbBandaraTujuan);
        panelSearch.Controls.Add(lblBandaraTujuan);
        panelSearch.Controls.Add(cmbBandaraAsal);
        panelSearch.Controls.Add(lblBandaraAsal);
        panelSearch.Location = new Point(48, 124);
        panelSearch.Name = "panelSearch";
        panelSearch.Padding = new Padding(32);
        panelSearch.Size = new Size(1220, 245);
        panelSearch.TabIndex = 1;
        // 
        // btnReset
        // 
        btnReset.BackColor = Color.White;
        btnReset.Cursor = Cursors.Hand;
        btnReset.FlatAppearance.BorderColor = Color.RoyalBlue;
        btnReset.FlatStyle = FlatStyle.Flat;
        btnReset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnReset.ForeColor = Color.RoyalBlue;
        btnReset.Location = new Point(920, 159);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(130, 44);
        btnReset.TabIndex = 9;
        btnReset.Text = "Reset";
        btnReset.UseVisualStyleBackColor = false;
        btnReset.Click += BtnResetClick;
        // 
        // btnSearch
        // 
        btnSearch.BackColor = Color.RoyalBlue;
        btnSearch.Cursor = Cursors.Hand;
        btnSearch.FlatAppearance.BorderSize = 0;
        btnSearch.FlatStyle = FlatStyle.Flat;
        btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnSearch.ForeColor = Color.White;
        btnSearch.Location = new Point(1068, 159);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(120, 44);
        btnSearch.TabIndex = 8;
        btnSearch.Text = "Cari";
        btnSearch.UseVisualStyleBackColor = false;
        btnSearch.Click += BtnSearchClick;
        // 
        // numJumlahPenumpang
        // 
        numJumlahPenumpang.Location = new Point(720, 166);
        numJumlahPenumpang.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
        numJumlahPenumpang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numJumlahPenumpang.Name = "numJumlahPenumpang";
        numJumlahPenumpang.Size = new Size(150, 27);
        numJumlahPenumpang.TabIndex = 7;
        numJumlahPenumpang.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblJumlahPenumpang
        // 
        lblJumlahPenumpang.AutoSize = true;
        lblJumlahPenumpang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblJumlahPenumpang.ForeColor = Color.Navy;
        lblJumlahPenumpang.Location = new Point(720, 132);
        lblJumlahPenumpang.Name = "lblJumlahPenumpang";
        lblJumlahPenumpang.Size = new Size(164, 23);
        lblJumlahPenumpang.TabIndex = 6;
        lblJumlahPenumpang.Text = "Jumlah Penumpang";
        // 
        // cmbMaskapai
        // 
        cmbMaskapai.DropDownStyle = ComboBoxStyle.DropDown;
        cmbMaskapai.FormattingEnabled = true;
        cmbMaskapai.Location = new Point(370, 166);
        cmbMaskapai.Name = "cmbMaskapai";
        cmbMaskapai.Size = new Size(300, 28);
        cmbMaskapai.TabIndex = 11;
        // 
        // lblMaskapai
        // 
        lblMaskapai.AutoSize = true;
        lblMaskapai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblMaskapai.ForeColor = Color.Navy;
        lblMaskapai.Location = new Point(370, 132);
        lblMaskapai.Name = "lblMaskapai";
        lblMaskapai.Size = new Size(83, 23);
        lblMaskapai.TabIndex = 10;
        lblMaskapai.Text = "Maskapai";
        // 
        // chkFilterTanggal
        // 
        chkFilterTanggal.AutoSize = true;
        chkFilterTanggal.Font = new Font("Segoe UI", 9F);
        chkFilterTanggal.ForeColor = Color.DimGray;
        chkFilterTanggal.Location = new Point(32, 203);
        chkFilterTanggal.Name = "chkFilterTanggal";
        chkFilterTanggal.Size = new Size(124, 24);
        chkFilterTanggal.TabIndex = 12;
        chkFilterTanggal.Text = "Filter tanggal";
        chkFilterTanggal.UseVisualStyleBackColor = true;
        // 
        // dtpTanggalBerangkat
        // 
        dtpTanggalBerangkat.Format = DateTimePickerFormat.Short;
        dtpTanggalBerangkat.Location = new Point(32, 166);
        dtpTanggalBerangkat.Name = "dtpTanggalBerangkat";
        dtpTanggalBerangkat.Size = new Size(300, 27);
        dtpTanggalBerangkat.TabIndex = 5;
        // 
        // lblTanggalBerangkat
        // 
        lblTanggalBerangkat.AutoSize = true;
        lblTanggalBerangkat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblTanggalBerangkat.ForeColor = Color.Navy;
        lblTanggalBerangkat.Location = new Point(32, 132);
        lblTanggalBerangkat.Name = "lblTanggalBerangkat";
        lblTanggalBerangkat.Size = new Size(159, 23);
        lblTanggalBerangkat.TabIndex = 4;
        lblTanggalBerangkat.Text = "Tanggal Berangkat";
        // 
        // cmbBandaraTujuan
        // 
        cmbBandaraTujuan.DropDownStyle = ComboBoxStyle.DropDown;
        cmbBandaraTujuan.FormattingEnabled = true;
        cmbBandaraTujuan.Location = new Point(570, 70);
        cmbBandaraTujuan.Name = "cmbBandaraTujuan";
        cmbBandaraTujuan.Size = new Size(520, 28);
        cmbBandaraTujuan.TabIndex = 3;
        // 
        // lblBandaraTujuan
        // 
        lblBandaraTujuan.AutoSize = true;
        lblBandaraTujuan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblBandaraTujuan.ForeColor = Color.Navy;
        lblBandaraTujuan.Location = new Point(570, 36);
        lblBandaraTujuan.Name = "lblBandaraTujuan";
        lblBandaraTujuan.Size = new Size(132, 23);
        lblBandaraTujuan.TabIndex = 2;
        lblBandaraTujuan.Text = "Bandara Tujuan";
        // 
        // cmbBandaraAsal
        // 
        cmbBandaraAsal.DropDownStyle = ComboBoxStyle.DropDown;
        cmbBandaraAsal.FormattingEnabled = true;
        cmbBandaraAsal.Location = new Point(32, 70);
        cmbBandaraAsal.Name = "cmbBandaraAsal";
        cmbBandaraAsal.Size = new Size(500, 28);
        cmbBandaraAsal.TabIndex = 1;
        // 
        // lblBandaraAsal
        // 
        lblBandaraAsal.AutoSize = true;
        lblBandaraAsal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblBandaraAsal.ForeColor = Color.Navy;
        lblBandaraAsal.Location = new Point(32, 36);
        lblBandaraAsal.Name = "lblBandaraAsal";
        lblBandaraAsal.Size = new Size(113, 23);
        lblBandaraAsal.TabIndex = 0;
        lblBandaraAsal.Text = "Bandara Asal";
        // 
        // lblHasil
        // 
        lblHasil.AutoSize = true;
        lblHasil.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblHasil.ForeColor = Color.Navy;
        lblHasil.Location = new Point(48, 410);
        lblHasil.Name = "lblHasil";
        lblHasil.Size = new Size(237, 46);
        lblHasil.TabIndex = 2;
        lblHasil.Text = "Daftar Jadwal";
        // 
        // panelGrid
        // 
        panelGrid.BackColor = Color.White;
        panelGrid.Controls.Add(btnDetail);
        panelGrid.Controls.Add(gridFlight);
        panelGrid.Location = new Point(48, 482);
        panelGrid.Name = "panelGrid";
        panelGrid.Padding = new Padding(24);
        panelGrid.Size = new Size(1220, 470);
        panelGrid.TabIndex = 3;
        // 
        // btnDetail
        // 
        btnDetail.BackColor = Color.RoyalBlue;
        btnDetail.Cursor = Cursors.Hand;
        btnDetail.FlatAppearance.BorderSize = 0;
        btnDetail.FlatStyle = FlatStyle.Flat;
        btnDetail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnDetail.ForeColor = Color.White;
        btnDetail.Location = new Point(1000, 402);
        btnDetail.Name = "btnDetail";
        btnDetail.Size = new Size(196, 44);
        btnDetail.TabIndex = 1;
        btnDetail.Text = "Lihat Detail";
        btnDetail.UseVisualStyleBackColor = false;
        btnDetail.Click += BtnDetailClick;
        // 
        // gridFlight
        // 
        gridFlight.AllowUserToAddRows = false;
        gridFlight.AllowUserToDeleteRows = false;
        gridFlight.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridFlight.BackgroundColor = Color.White;
        gridFlight.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridFlight.Columns.AddRange(new DataGridViewColumn[] { colKodePenerbangan, colMaskapai, colBandaraAsal, colBandaraTujuan, colTanggalBerangkat, colWaktuBerangkat, colDurasi, colHarga, colKursiTersedia });
        gridFlight.Dock = DockStyle.Fill;
        gridFlight.Location = new Point(24, 24);
        gridFlight.MultiSelect = false;
        gridFlight.Name = "gridFlight";
        gridFlight.ReadOnly = true;
        gridFlight.RowHeadersVisible = false;
        gridFlight.RowHeadersWidth = 51;
        gridFlight.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridFlight.Size = new Size(1172, 362);
        gridFlight.TabIndex = 0;
        gridFlight.CellDoubleClick += GridFlightCellDoubleClick;
        // 
        // colKodePenerbangan
        // 
        colKodePenerbangan.HeaderText = "Kode";
        colKodePenerbangan.MinimumWidth = 6;
        colKodePenerbangan.Name = "colKodePenerbangan";
        colKodePenerbangan.ReadOnly = true;
        // 
        // colMaskapai
        // 
        colMaskapai.HeaderText = "Maskapai";
        colMaskapai.MinimumWidth = 6;
        colMaskapai.Name = "colMaskapai";
        colMaskapai.ReadOnly = true;
        // 
        // colBandaraAsal
        // 
        colBandaraAsal.HeaderText = "Asal";
        colBandaraAsal.MinimumWidth = 6;
        colBandaraAsal.Name = "colBandaraAsal";
        colBandaraAsal.ReadOnly = true;
        // 
        // colBandaraTujuan
        // 
        colBandaraTujuan.HeaderText = "Tujuan";
        colBandaraTujuan.MinimumWidth = 6;
        colBandaraTujuan.Name = "colBandaraTujuan";
        colBandaraTujuan.ReadOnly = true;
        // 
        // colTanggalBerangkat
        // 
        colTanggalBerangkat.HeaderText = "Tanggal";
        colTanggalBerangkat.MinimumWidth = 6;
        colTanggalBerangkat.Name = "colTanggalBerangkat";
        colTanggalBerangkat.ReadOnly = true;
        // 
        // colWaktuBerangkat
        // 
        colWaktuBerangkat.HeaderText = "Waktu";
        colWaktuBerangkat.MinimumWidth = 6;
        colWaktuBerangkat.Name = "colWaktuBerangkat";
        colWaktuBerangkat.ReadOnly = true;
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
        colHarga.HeaderText = "Harga";
        colHarga.MinimumWidth = 6;
        colHarga.Name = "colHarga";
        colHarga.ReadOnly = true;
        // 
        // colKursiTersedia
        // 
        colKursiTersedia.HeaderText = "Kursi";
        colKursiTersedia.MinimumWidth = 6;
        colKursiTersedia.Name = "colKursiTersedia";
        colKursiTersedia.ReadOnly = true;
        // 
        // SearchFlightForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1375, 1050);
        Controls.Add(panelGrid);
        Controls.Add(lblHasil);
        Controls.Add(panelSearch);
        Controls.Add(lblTitle);
        FormBorderStyle = FormBorderStyle.None;
        Name = "SearchFlightForm";
        Text = "Cari Penerbangan";
        panelSearch.ResumeLayout(false);
        panelSearch.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numJumlahPenumpang).EndInit();
        panelGrid.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridFlight).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitle;
    private Panel panelSearch;
    private ComboBox cmbBandaraAsal;
    private Label lblBandaraAsal;
    private ComboBox cmbBandaraTujuan;
    private Label lblBandaraTujuan;
    private DateTimePicker dtpTanggalBerangkat;
    private Label lblTanggalBerangkat;
    private CheckBox chkFilterTanggal;
    private ComboBox cmbMaskapai;
    private Label lblMaskapai;
    private NumericUpDown numJumlahPenumpang;
    private Label lblJumlahPenumpang;
    private Button btnSearch;
    private Button btnReset;
    private Label lblHasil;
    private Panel panelGrid;
    private Button btnDetail;
    private DataGridView gridFlight;
    private DataGridViewTextBoxColumn colKodePenerbangan;
    private DataGridViewTextBoxColumn colMaskapai;
    private DataGridViewTextBoxColumn colBandaraAsal;
    private DataGridViewTextBoxColumn colBandaraTujuan;
    private DataGridViewTextBoxColumn colTanggalBerangkat;
    private DataGridViewTextBoxColumn colWaktuBerangkat;
    private DataGridViewTextBoxColumn colDurasi;
    private DataGridViewTextBoxColumn colHarga;
    private DataGridViewTextBoxColumn colKursiTersedia;
}
