namespace BromoAirlines.Forms
{
    partial class MasterJadwalPenerbanganForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
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
            cmbMaskapai = new ComboBox();
            lblMaskapai = new Label();
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
            MaskapaiID = new DataGridViewTextBoxColumn();
            Maskapai = new DataGridViewTextBoxColumn();
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
            lblTitle.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(20, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(786, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "MASTER JADWAL PENERBANGAN - ADMIN";
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
            gbJadwal.Controls.Add(cmbMaskapai);
            gbJadwal.Controls.Add(lblMaskapai);
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
            gbJadwal.Location = new Point(20, 78);
            gbJadwal.Name = "gbJadwal";
            gbJadwal.Size = new Size(1140, 300);
            gbJadwal.TabIndex = 1;
            gbJadwal.TabStop = false;
            gbJadwal.Text = "Data Jadwal Penerbangan";
            // 
            // numHarga
            // 
            numHarga.Location = new Point(815, 160);
            numHarga.Maximum = new decimal(new int[] { 2000000000, 0, 0, 0 });
            numHarga.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numHarga.Name = "numHarga";
            numHarga.Size = new Size(180, 31);
            numHarga.TabIndex = 13;
            numHarga.ThousandsSeparator = true;
            numHarga.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblRupiahPrefix
            // 
            lblRupiahPrefix.AutoSize = true;
            lblRupiahPrefix.Location = new Point(775, 162);
            lblRupiahPrefix.Name = "lblRupiahPrefix";
            lblRupiahPrefix.Size = new Size(33, 25);
            lblRupiahPrefix.TabIndex = 18;
            lblRupiahPrefix.Text = "Rp";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(600, 160);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(142, 25);
            lblHarga.TabIndex = 12;
            lblHarga.Text = "Harga Per Tiket:";
            // 
            // numDurasi
            // 
            numDurasi.Location = new Point(775, 110);
            numDurasi.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numDurasi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDurasi.Name = "numDurasi";
            numDurasi.Size = new Size(120, 31);
            numDurasi.TabIndex = 11;
            numDurasi.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDurasi
            // 
            lblDurasi.AutoSize = true;
            lblDurasi.Location = new Point(600, 110);
            lblDurasi.Name = "lblDurasi";
            lblDurasi.Size = new Size(131, 25);
            lblDurasi.TabIndex = 10;
            lblDurasi.Text = "Durasi (menit):";
            // 
            // dtpKeberangkatan
            // 
            dtpKeberangkatan.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpKeberangkatan.Format = DateTimePickerFormat.Custom;
            dtpKeberangkatan.Location = new Point(775, 60);
            dtpKeberangkatan.Name = "dtpKeberangkatan";
            dtpKeberangkatan.Size = new Size(220, 31);
            dtpKeberangkatan.TabIndex = 9;
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Location = new Point(600, 60);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(154, 25);
            lblTanggal.TabIndex = 8;
            lblTanggal.Text = "Tanggal dan Jam:";
            // 
            // cmbMaskapai
            // 
            cmbMaskapai.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaskapai.FormattingEnabled = true;
            cmbMaskapai.Location = new Point(240, 207);
            cmbMaskapai.Name = "cmbMaskapai";
            cmbMaskapai.Size = new Size(300, 33);
            cmbMaskapai.TabIndex = 7;
            // 
            // lblMaskapai
            // 
            lblMaskapai.AutoSize = true;
            lblMaskapai.Location = new Point(30, 210);
            lblMaskapai.Name = "lblMaskapai";
            lblMaskapai.Size = new Size(90, 25);
            lblMaskapai.TabIndex = 6;
            lblMaskapai.Text = "Maskapai:";
            // 
            // cmbBandaraTujuan
            // 
            cmbBandaraTujuan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBandaraTujuan.FormattingEnabled = true;
            cmbBandaraTujuan.Location = new Point(240, 157);
            cmbBandaraTujuan.Name = "cmbBandaraTujuan";
            cmbBandaraTujuan.Size = new Size(300, 33);
            cmbBandaraTujuan.TabIndex = 5;
            // 
            // lblBandaraTujuan
            // 
            lblBandaraTujuan.AutoSize = true;
            lblBandaraTujuan.Location = new Point(30, 160);
            lblBandaraTujuan.Name = "lblBandaraTujuan";
            lblBandaraTujuan.Size = new Size(140, 25);
            lblBandaraTujuan.TabIndex = 4;
            lblBandaraTujuan.Text = "Bandara Tujuan:";
            // 
            // cmbBandaraKeberangkatan
            // 
            cmbBandaraKeberangkatan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBandaraKeberangkatan.FormattingEnabled = true;
            cmbBandaraKeberangkatan.Location = new Point(240, 107);
            cmbBandaraKeberangkatan.Name = "cmbBandaraKeberangkatan";
            cmbBandaraKeberangkatan.Size = new Size(300, 33);
            cmbBandaraKeberangkatan.TabIndex = 3;
            // 
            // lblBandaraKeberangkatan
            // 
            lblBandaraKeberangkatan.AutoSize = true;
            lblBandaraKeberangkatan.Location = new Point(30, 110);
            lblBandaraKeberangkatan.Name = "lblBandaraKeberangkatan";
            lblBandaraKeberangkatan.Size = new Size(204, 25);
            lblBandaraKeberangkatan.TabIndex = 2;
            lblBandaraKeberangkatan.Text = "Bandara Keberangkatan:";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Azure;
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.Gray;
            btnReset.Location = new Point(995, 235);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(110, 40);
            btnReset.TabIndex = 17;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Crimson;
            btnHapus.Cursor = Cursors.Hand;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(865, 235);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(110, 40);
            btnHapus.TabIndex = 16;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.ForestGreen;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(735, 235);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 40);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.DodgerBlue;
            btnTambah.Cursor = Cursors.Hand;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(605, 235);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(110, 40);
            btnTambah.TabIndex = 14;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // txtKodePenerbangan
            // 
            txtKodePenerbangan.BorderStyle = BorderStyle.FixedSingle;
            txtKodePenerbangan.Location = new Point(240, 57);
            txtKodePenerbangan.MaxLength = 10;
            txtKodePenerbangan.Name = "txtKodePenerbangan";
            txtKodePenerbangan.Size = new Size(180, 31);
            txtKodePenerbangan.TabIndex = 1;
            // 
            // lblKodePenerbangan
            // 
            lblKodePenerbangan.AutoSize = true;
            lblKodePenerbangan.Location = new Point(30, 60);
            lblKodePenerbangan.Name = "lblKodePenerbangan";
            lblKodePenerbangan.Size = new Size(160, 25);
            lblKodePenerbangan.TabIndex = 0;
            lblKodePenerbangan.Text = "Kode Penerbangan:";
            // 
            // lblDaftarJadwal
            // 
            lblDaftarJadwal.AutoSize = true;
            lblDaftarJadwal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblDaftarJadwal.ForeColor = Color.Navy;
            lblDaftarJadwal.Location = new Point(20, 398);
            lblDaftarJadwal.Name = "lblDaftarJadwal";
            lblDaftarJadwal.Size = new Size(306, 25);
            lblDaftarJadwal.TabIndex = 2;
            lblDaftarJadwal.Text = "Daftar Jadwal Penerbangan";
            // 
            // txtCariJadwal
            // 
            txtCariJadwal.BorderStyle = BorderStyle.FixedSingle;
            txtCariJadwal.Location = new Point(910, 392);
            txtCariJadwal.Name = "txtCariJadwal";
            txtCariJadwal.PlaceholderText = "Cari Jadwal.....";
            txtCariJadwal.Size = new Size(250, 31);
            txtCariJadwal.TabIndex = 3;
            // 
            // dgvJadwal
            // 
            dgvJadwal.AllowUserToAddRows = false;
            dgvJadwal.AllowUserToDeleteRows = false;
            dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJadwal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJadwal.Columns.AddRange(new DataGridViewColumn[] { ID, KodePenerbangan, BandaraKeberangkatanID, BandaraKeberangkatan, BandaraTujuanID, BandaraTujuan, MaskapaiID, Maskapai, TanggalWaktuKeberangkatan, DurasiPenerbangan, HargaPerTiket });
            dgvJadwal.Location = new Point(20, 435);
            dgvJadwal.Name = "dgvJadwal";
            dgvJadwal.ReadOnly = true;
            dgvJadwal.RowHeadersVisible = false;
            dgvJadwal.RowHeadersWidth = 51;
            dgvJadwal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJadwal.Size = new Size(1140, 250);
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
            // MaskapaiID
            // 
            MaskapaiID.HeaderText = "MaskapaiID";
            MaskapaiID.MinimumWidth = 6;
            MaskapaiID.Name = "MaskapaiID";
            MaskapaiID.ReadOnly = true;
            MaskapaiID.Visible = false;
            // 
            // Maskapai
            // 
            Maskapai.HeaderText = "Maskapai";
            Maskapai.MinimumWidth = 6;
            Maskapai.Name = "Maskapai";
            Maskapai.ReadOnly = true;
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
            HargaPerTiket.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            // 
            // MasterJadwalPenerbanganForm
            // 
            AutoScroll = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1182, 715);
            Controls.Add(dgvJadwal);
            Controls.Add(txtCariJadwal);
            Controls.Add(lblDaftarJadwal);
            Controls.Add(gbJadwal);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.8F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MasterJadwalPenerbanganForm";
            Text = "MasterJadwalPenerbanganForm";
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
        private ComboBox cmbMaskapai;
        private Label lblMaskapai;
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
        private DataGridViewTextBoxColumn MaskapaiID;
        private DataGridViewTextBoxColumn Maskapai;
        private DataGridViewTextBoxColumn TanggalWaktuKeberangkatan;
        private DataGridViewTextBoxColumn DurasiPenerbangan;
        private DataGridViewTextBoxColumn HargaPerTiket;
    }
}
