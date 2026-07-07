namespace BromoAirlines.Forms
{
    partial class StatusPenerbanganForm
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
            gbStatus = new GroupBox();
            lblSelectedJadwal = new Label();
            lblSelectedKode = new Label();
            numDurasiDelay = new NumericUpDown();
            lblDurasiDelay = new Label();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            btnReset = new Button();
            btnSimpan = new Button();
            lblDaftarJadwal = new Label();
            txtCariJadwal = new TextBox();
            dgvJadwalStatus = new DataGridView();
            JadwalPenerbanganID = new DataGridViewTextBoxColumn();
            KodePenerbangan = new DataGridViewTextBoxColumn();
            BandaraKeberangkatan = new DataGridViewTextBoxColumn();
            BandaraTujuan = new DataGridViewTextBoxColumn();
            Maskapai = new DataGridViewTextBoxColumn();
            TanggalWaktuKeberangkatan = new DataGridViewTextBoxColumn();
            StatusPenerbanganID = new DataGridViewTextBoxColumn();
            StatusPenerbangan = new DataGridViewTextBoxColumn();
            WaktuPerubahanTerjadi = new DataGridViewTextBoxColumn();
            PerkiraanDurasiDelay = new DataGridViewTextBoxColumn();
            gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDurasiDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvJadwalStatus).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(698, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "UBAH STATUS PENERBANGAN - ADMIN";
            // 
            // gbStatus
            // 
            gbStatus.Controls.Add(lblSelectedJadwal);
            gbStatus.Controls.Add(lblSelectedKode);
            gbStatus.Controls.Add(numDurasiDelay);
            gbStatus.Controls.Add(lblDurasiDelay);
            gbStatus.Controls.Add(cmbStatus);
            gbStatus.Controls.Add(lblStatus);
            gbStatus.Controls.Add(btnReset);
            gbStatus.Controls.Add(btnSimpan);
            gbStatus.Location = new Point(20, 90);
            gbStatus.Name = "gbStatus";
            gbStatus.Size = new Size(1140, 230);
            gbStatus.TabIndex = 1;
            gbStatus.TabStop = false;
            gbStatus.Text = "Perubahan Status";
            // 
            // lblSelectedJadwal
            // 
            lblSelectedJadwal.AutoSize = true;
            lblSelectedJadwal.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblSelectedJadwal.ForeColor = Color.Navy;
            lblSelectedJadwal.Location = new Point(190, 50);
            lblSelectedJadwal.Name = "lblSelectedJadwal";
            lblSelectedJadwal.Size = new Size(17, 25);
            lblSelectedJadwal.TabIndex = 1;
            lblSelectedJadwal.Text = "-";
            // 
            // lblSelectedKode
            // 
            lblSelectedKode.AutoSize = true;
            lblSelectedKode.Location = new Point(30, 50);
            lblSelectedKode.Name = "lblSelectedKode";
            lblSelectedKode.Size = new Size(128, 25);
            lblSelectedKode.TabIndex = 0;
            lblSelectedKode.Text = "Jadwal Dipilih:";
            // 
            // numDurasiDelay
            // 
            numDurasiDelay.Location = new Point(190, 150);
            numDurasiDelay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numDurasiDelay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDurasiDelay.Name = "numDurasiDelay";
            numDurasiDelay.Size = new Size(120, 31);
            numDurasiDelay.TabIndex = 5;
            numDurasiDelay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDurasiDelay
            // 
            lblDurasiDelay.AutoSize = true;
            lblDurasiDelay.Location = new Point(30, 150);
            lblDurasiDelay.Name = "lblDurasiDelay";
            lblDurasiDelay.Size = new Size(154, 25);
            lblDurasiDelay.TabIndex = 4;
            lblDurasiDelay.Text = "Delay (menit):";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(190, 98);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(280, 33);
            cmbStatus.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(30, 100);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(68, 25);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status:";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Azure;
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.Gray;
            btnReset.Location = new Point(980, 160);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(110, 40);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.DodgerBlue;
            btnSimpan.Cursor = Cursors.Hand;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(850, 160);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(110, 40);
            btnSimpan.TabIndex = 6;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // lblDaftarJadwal
            // 
            lblDaftarJadwal.AutoSize = true;
            lblDaftarJadwal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblDaftarJadwal.ForeColor = Color.Navy;
            lblDaftarJadwal.Location = new Point(20, 340);
            lblDaftarJadwal.Name = "lblDaftarJadwal";
            lblDaftarJadwal.Size = new Size(306, 25);
            lblDaftarJadwal.TabIndex = 2;
            lblDaftarJadwal.Text = "Daftar Jadwal Penerbangan";
            // 
            // txtCariJadwal
            // 
            txtCariJadwal.BorderStyle = BorderStyle.FixedSingle;
            txtCariJadwal.Location = new Point(910, 335);
            txtCariJadwal.Name = "txtCariJadwal";
            txtCariJadwal.PlaceholderText = "Cari Jadwal.....";
            txtCariJadwal.Size = new Size(250, 31);
            txtCariJadwal.TabIndex = 3;
            // 
            // dgvJadwalStatus
            // 
            dgvJadwalStatus.AllowUserToAddRows = false;
            dgvJadwalStatus.AllowUserToDeleteRows = false;
            dgvJadwalStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJadwalStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJadwalStatus.Columns.AddRange(new DataGridViewColumn[] { JadwalPenerbanganID, KodePenerbangan, BandaraKeberangkatan, BandaraTujuan, Maskapai, TanggalWaktuKeberangkatan, StatusPenerbanganID, StatusPenerbangan, WaktuPerubahanTerjadi, PerkiraanDurasiDelay });
            dgvJadwalStatus.Location = new Point(20, 380);
            dgvJadwalStatus.Name = "dgvJadwalStatus";
            dgvJadwalStatus.ReadOnly = true;
            dgvJadwalStatus.RowHeadersVisible = false;
            dgvJadwalStatus.RowHeadersWidth = 51;
            dgvJadwalStatus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJadwalStatus.Size = new Size(1140, 305);
            dgvJadwalStatus.TabIndex = 4;
            // 
            // JadwalPenerbanganID
            // 
            JadwalPenerbanganID.HeaderText = "ID";
            JadwalPenerbanganID.MinimumWidth = 6;
            JadwalPenerbanganID.Name = "JadwalPenerbanganID";
            JadwalPenerbanganID.ReadOnly = true;
            // 
            // KodePenerbangan
            // 
            KodePenerbangan.HeaderText = "Kode";
            KodePenerbangan.MinimumWidth = 6;
            KodePenerbangan.Name = "KodePenerbangan";
            KodePenerbangan.ReadOnly = true;
            // 
            // BandaraKeberangkatan
            // 
            BandaraKeberangkatan.HeaderText = "Keberangkatan";
            BandaraKeberangkatan.MinimumWidth = 6;
            BandaraKeberangkatan.Name = "BandaraKeberangkatan";
            BandaraKeberangkatan.ReadOnly = true;
            // 
            // BandaraTujuan
            // 
            BandaraTujuan.HeaderText = "Tujuan";
            BandaraTujuan.MinimumWidth = 6;
            BandaraTujuan.Name = "BandaraTujuan";
            BandaraTujuan.ReadOnly = true;
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
            // StatusPenerbanganID
            // 
            StatusPenerbanganID.HeaderText = "StatusPenerbanganID";
            StatusPenerbanganID.MinimumWidth = 6;
            StatusPenerbanganID.Name = "StatusPenerbanganID";
            StatusPenerbanganID.ReadOnly = true;
            StatusPenerbanganID.Visible = false;
            // 
            // StatusPenerbangan
            // 
            StatusPenerbangan.HeaderText = "Status";
            StatusPenerbangan.MinimumWidth = 6;
            StatusPenerbangan.Name = "StatusPenerbangan";
            StatusPenerbangan.ReadOnly = true;
            // 
            // WaktuPerubahanTerjadi
            // 
            WaktuPerubahanTerjadi.HeaderText = "Waktu Perubahan";
            WaktuPerubahanTerjadi.MinimumWidth = 6;
            WaktuPerubahanTerjadi.Name = "WaktuPerubahanTerjadi";
            WaktuPerubahanTerjadi.ReadOnly = true;
            // 
            // PerkiraanDurasiDelay
            // 
            PerkiraanDurasiDelay.HeaderText = "Delay";
            PerkiraanDurasiDelay.MinimumWidth = 6;
            PerkiraanDurasiDelay.Name = "PerkiraanDurasiDelay";
            PerkiraanDurasiDelay.ReadOnly = true;
            // 
            // StatusPenerbanganForm
            // 
            AutoScroll = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1182, 715);
            Controls.Add(dgvJadwalStatus);
            Controls.Add(txtCariJadwal);
            Controls.Add(lblDaftarJadwal);
            Controls.Add(gbStatus);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.8F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StatusPenerbanganForm";
            Text = "StatusPenerbanganForm";
            gbStatus.ResumeLayout(false);
            gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDurasiDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvJadwalStatus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private GroupBox gbStatus;
        private Label lblSelectedJadwal;
        private Label lblSelectedKode;
        private NumericUpDown numDurasiDelay;
        private Label lblDurasiDelay;
        private ComboBox cmbStatus;
        private Label lblStatus;
        private Button btnReset;
        private Button btnSimpan;
        private Label lblDaftarJadwal;
        private TextBox txtCariJadwal;
        private DataGridView dgvJadwalStatus;
        private DataGridViewTextBoxColumn JadwalPenerbanganID;
        private DataGridViewTextBoxColumn KodePenerbangan;
        private DataGridViewTextBoxColumn BandaraKeberangkatan;
        private DataGridViewTextBoxColumn BandaraTujuan;
        private DataGridViewTextBoxColumn Maskapai;
        private DataGridViewTextBoxColumn TanggalWaktuKeberangkatan;
        private DataGridViewTextBoxColumn StatusPenerbanganID;
        private DataGridViewTextBoxColumn StatusPenerbangan;
        private DataGridViewTextBoxColumn WaktuPerubahanTerjadi;
        private DataGridViewTextBoxColumn PerkiraanDurasiDelay;
    }
}
