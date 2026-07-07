namespace BromoAirlines.Forms
{
    partial class LaporanForm
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
            gbFilter = new GroupBox();
            btnTampilkan = new Button();
            dtpSampai = new DateTimePicker();
            lblSampai = new Label();
            dtpMulai = new DateTimePicker();
            lblMulai = new Label();
            lblTotalTransaksiTitle = new Label();
            lblTotalTransaksi = new Label();
            lblTotalPenumpangTitle = new Label();
            lblTotalPenumpang = new Label();
            lblTotalPendapatanTitle = new Label();
            lblTotalPendapatan = new Label();
            lblDetailTransaksi = new Label();
            dgvTransaksi = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TanggalTransaksi = new DataGridViewTextBoxColumn();
            NamaAkun = new DataGridViewTextBoxColumn();
            KodePenerbangan = new DataGridViewTextBoxColumn();
            Rute = new DataGridViewTextBoxColumn();
            Maskapai = new DataGridViewTextBoxColumn();
            JumlahPenumpang = new DataGridViewTextBoxColumn();
            TotalHarga = new DataGridViewTextBoxColumn();
            KodePromo = new DataGridViewTextBoxColumn();
            lblRekapMaskapai = new Label();
            dgvMaskapai = new DataGridView();
            MaskapaiRekap = new DataGridViewTextBoxColumn();
            TotalTransaksi = new DataGridViewTextBoxColumn();
            TotalPenumpang = new DataGridViewTextBoxColumn();
            TotalPendapatan = new DataGridViewTextBoxColumn();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMaskapai).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(312, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "LAPORAN - ADMIN";
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(btnTampilkan);
            gbFilter.Controls.Add(dtpSampai);
            gbFilter.Controls.Add(lblSampai);
            gbFilter.Controls.Add(dtpMulai);
            gbFilter.Controls.Add(lblMulai);
            gbFilter.Location = new Point(20, 80);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(1140, 90);
            gbFilter.TabIndex = 1;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter Periode";
            // 
            // btnTampilkan
            // 
            btnTampilkan.BackColor = Color.DodgerBlue;
            btnTampilkan.Cursor = Cursors.Hand;
            btnTampilkan.FlatStyle = FlatStyle.Flat;
            btnTampilkan.ForeColor = Color.White;
            btnTampilkan.Location = new Point(620, 35);
            btnTampilkan.Name = "btnTampilkan";
            btnTampilkan.Size = new Size(120, 35);
            btnTampilkan.TabIndex = 4;
            btnTampilkan.Text = "Tampilkan";
            btnTampilkan.UseVisualStyleBackColor = false;
            // 
            // dtpSampai
            // 
            dtpSampai.CustomFormat = "dd/MM/yyyy";
            dtpSampai.Format = DateTimePickerFormat.Custom;
            dtpSampai.Location = new Point(410, 37);
            dtpSampai.Name = "dtpSampai";
            dtpSampai.Size = new Size(150, 31);
            dtpSampai.TabIndex = 3;
            // 
            // lblSampai
            // 
            lblSampai.AutoSize = true;
            lblSampai.Location = new Point(315, 40);
            lblSampai.Name = "lblSampai";
            lblSampai.Size = new Size(74, 25);
            lblSampai.TabIndex = 2;
            lblSampai.Text = "Sampai:";
            // 
            // dtpMulai
            // 
            dtpMulai.CustomFormat = "dd/MM/yyyy";
            dtpMulai.Format = DateTimePickerFormat.Custom;
            dtpMulai.Location = new Point(120, 37);
            dtpMulai.Name = "dtpMulai";
            dtpMulai.Size = new Size(150, 31);
            dtpMulai.TabIndex = 1;
            // 
            // lblMulai
            // 
            lblMulai.AutoSize = true;
            lblMulai.Location = new Point(30, 40);
            lblMulai.Name = "lblMulai";
            lblMulai.Size = new Size(61, 25);
            lblMulai.TabIndex = 0;
            lblMulai.Text = "Mulai:";
            // 
            // lblTotalTransaksiTitle
            // 
            lblTotalTransaksiTitle.AutoSize = true;
            lblTotalTransaksiTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblTotalTransaksiTitle.ForeColor = Color.Navy;
            lblTotalTransaksiTitle.Location = new Point(20, 190);
            lblTotalTransaksiTitle.Name = "lblTotalTransaksiTitle";
            lblTotalTransaksiTitle.Size = new Size(136, 25);
            lblTotalTransaksiTitle.TabIndex = 2;
            lblTotalTransaksiTitle.Text = "Total Transaksi";
            // 
            // lblTotalTransaksi
            // 
            lblTotalTransaksi.AutoSize = true;
            lblTotalTransaksi.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotalTransaksi.Location = new Point(20, 215);
            lblTotalTransaksi.Name = "lblTotalTransaksi";
            lblTotalTransaksi.Size = new Size(33, 37);
            lblTotalTransaksi.TabIndex = 3;
            lblTotalTransaksi.Text = "0";
            // 
            // lblTotalPenumpangTitle
            // 
            lblTotalPenumpangTitle.AutoSize = true;
            lblTotalPenumpangTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblTotalPenumpangTitle.ForeColor = Color.Navy;
            lblTotalPenumpangTitle.Location = new Point(300, 190);
            lblTotalPenumpangTitle.Name = "lblTotalPenumpangTitle";
            lblTotalPenumpangTitle.Size = new Size(162, 25);
            lblTotalPenumpangTitle.TabIndex = 4;
            lblTotalPenumpangTitle.Text = "Total Penumpang";
            // 
            // lblTotalPenumpang
            // 
            lblTotalPenumpang.AutoSize = true;
            lblTotalPenumpang.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotalPenumpang.Location = new Point(300, 215);
            lblTotalPenumpang.Name = "lblTotalPenumpang";
            lblTotalPenumpang.Size = new Size(33, 37);
            lblTotalPenumpang.TabIndex = 5;
            lblTotalPenumpang.Text = "0";
            // 
            // lblTotalPendapatanTitle
            // 
            lblTotalPendapatanTitle.AutoSize = true;
            lblTotalPendapatanTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblTotalPendapatanTitle.ForeColor = Color.Navy;
            lblTotalPendapatanTitle.Location = new Point(580, 190);
            lblTotalPendapatanTitle.Name = "lblTotalPendapatanTitle";
            lblTotalPendapatanTitle.Size = new Size(163, 25);
            lblTotalPendapatanTitle.TabIndex = 6;
            lblTotalPendapatanTitle.Text = "Total Pendapatan";
            // 
            // lblTotalPendapatan
            // 
            lblTotalPendapatan.AutoSize = true;
            lblTotalPendapatan.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotalPendapatan.Location = new Point(580, 215);
            lblTotalPendapatan.Name = "lblTotalPendapatan";
            lblTotalPendapatan.Size = new Size(68, 37);
            lblTotalPendapatan.TabIndex = 7;
            lblTotalPendapatan.Text = "Rp 0";
            // 
            // lblDetailTransaksi
            // 
            lblDetailTransaksi.AutoSize = true;
            lblDetailTransaksi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblDetailTransaksi.ForeColor = Color.Navy;
            lblDetailTransaksi.Location = new Point(20, 270);
            lblDetailTransaksi.Name = "lblDetailTransaksi";
            lblDetailTransaksi.Size = new Size(172, 25);
            lblDetailTransaksi.TabIndex = 8;
            lblDetailTransaksi.Text = "Detail Transaksi";
            // 
            // dgvTransaksi
            // 
            dgvTransaksi.AllowUserToAddRows = false;
            dgvTransaksi.AllowUserToDeleteRows = false;
            dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaksi.Columns.AddRange(new DataGridViewColumn[] { ID, TanggalTransaksi, NamaAkun, KodePenerbangan, Rute, Maskapai, JumlahPenumpang, TotalHarga, KodePromo });
            dgvTransaksi.Location = new Point(20, 305);
            dgvTransaksi.Name = "dgvTransaksi";
            dgvTransaksi.ReadOnly = true;
            dgvTransaksi.RowHeadersVisible = false;
            dgvTransaksi.RowHeadersWidth = 51;
            dgvTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransaksi.Size = new Size(1140, 210);
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
            NamaAkun.HeaderText = "Akun";
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
            // Maskapai
            // 
            Maskapai.HeaderText = "Maskapai";
            Maskapai.MinimumWidth = 6;
            Maskapai.Name = "Maskapai";
            Maskapai.ReadOnly = true;
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
            TotalHarga.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            // 
            // KodePromo
            // 
            KodePromo.HeaderText = "Promo";
            KodePromo.MinimumWidth = 6;
            KodePromo.Name = "KodePromo";
            KodePromo.ReadOnly = true;
            // 
            // lblRekapMaskapai
            // 
            lblRekapMaskapai.AutoSize = true;
            lblRekapMaskapai.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblRekapMaskapai.ForeColor = Color.Navy;
            lblRekapMaskapai.Location = new Point(20, 535);
            lblRekapMaskapai.Name = "lblRekapMaskapai";
            lblRekapMaskapai.Size = new Size(181, 25);
            lblRekapMaskapai.TabIndex = 10;
            lblRekapMaskapai.Text = "Rekap Maskapai";
            // 
            // dgvMaskapai
            // 
            dgvMaskapai.AllowUserToAddRows = false;
            dgvMaskapai.AllowUserToDeleteRows = false;
            dgvMaskapai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaskapai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaskapai.Columns.AddRange(new DataGridViewColumn[] { MaskapaiRekap, TotalTransaksi, TotalPenumpang, TotalPendapatan });
            dgvMaskapai.Location = new Point(20, 570);
            dgvMaskapai.Name = "dgvMaskapai";
            dgvMaskapai.ReadOnly = true;
            dgvMaskapai.RowHeadersVisible = false;
            dgvMaskapai.RowHeadersWidth = 51;
            dgvMaskapai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaskapai.Size = new Size(1140, 115);
            dgvMaskapai.TabIndex = 11;
            // 
            // MaskapaiRekap
            // 
            MaskapaiRekap.HeaderText = "Maskapai";
            MaskapaiRekap.MinimumWidth = 6;
            MaskapaiRekap.Name = "MaskapaiRekap";
            MaskapaiRekap.ReadOnly = true;
            // 
            // TotalTransaksi
            // 
            TotalTransaksi.HeaderText = "Transaksi";
            TotalTransaksi.MinimumWidth = 6;
            TotalTransaksi.Name = "TotalTransaksi";
            TotalTransaksi.ReadOnly = true;
            // 
            // TotalPenumpang
            // 
            TotalPenumpang.HeaderText = "Penumpang";
            TotalPenumpang.MinimumWidth = 6;
            TotalPenumpang.Name = "TotalPenumpang";
            TotalPenumpang.ReadOnly = true;
            // 
            // TotalPendapatan
            // 
            TotalPendapatan.HeaderText = "Pendapatan";
            TotalPendapatan.MinimumWidth = 6;
            TotalPendapatan.Name = "TotalPendapatan";
            TotalPendapatan.ReadOnly = true;
            TotalPendapatan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            // 
            // LaporanForm
            // 
            AutoScroll = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1182, 715);
            Controls.Add(dgvMaskapai);
            Controls.Add(lblRekapMaskapai);
            Controls.Add(dgvTransaksi);
            Controls.Add(lblDetailTransaksi);
            Controls.Add(lblTotalPendapatan);
            Controls.Add(lblTotalPendapatanTitle);
            Controls.Add(lblTotalPenumpang);
            Controls.Add(lblTotalPenumpangTitle);
            Controls.Add(lblTotalTransaksi);
            Controls.Add(lblTotalTransaksiTitle);
            Controls.Add(gbFilter);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.8F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LaporanForm";
            Text = "LaporanForm";
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMaskapai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private GroupBox gbFilter;
        private Button btnTampilkan;
        private DateTimePicker dtpSampai;
        private Label lblSampai;
        private DateTimePicker dtpMulai;
        private Label lblMulai;
        private Label lblTotalTransaksiTitle;
        private Label lblTotalTransaksi;
        private Label lblTotalPenumpangTitle;
        private Label lblTotalPenumpang;
        private Label lblTotalPendapatanTitle;
        private Label lblTotalPendapatan;
        private Label lblDetailTransaksi;
        private DataGridView dgvTransaksi;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TanggalTransaksi;
        private DataGridViewTextBoxColumn NamaAkun;
        private DataGridViewTextBoxColumn KodePenerbangan;
        private DataGridViewTextBoxColumn Rute;
        private DataGridViewTextBoxColumn Maskapai;
        private DataGridViewTextBoxColumn JumlahPenumpang;
        private DataGridViewTextBoxColumn TotalHarga;
        private DataGridViewTextBoxColumn KodePromo;
        private Label lblRekapMaskapai;
        private DataGridView dgvMaskapai;
        private DataGridViewTextBoxColumn MaskapaiRekap;
        private DataGridViewTextBoxColumn TotalTransaksi;
        private DataGridViewTextBoxColumn TotalPenumpang;
        private DataGridViewTextBoxColumn TotalPendapatan;
    }
}
