namespace BromoAirlines.Forms
{
    partial class TransaksiForm
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
            lblDaftarTransaksi = new Label();
            txtCariTransaksi = new TextBox();
            btnRefresh = new Button();
            btnHapus = new Button();
            dgvTransaksi = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            AkunID = new DataGridViewTextBoxColumn();
            NamaAkun = new DataGridViewTextBoxColumn();
            TanggalTransaksi = new DataGridViewTextBoxColumn();
            JadwalPenerbanganID = new DataGridViewTextBoxColumn();
            KodePenerbangan = new DataGridViewTextBoxColumn();
            Rute = new DataGridViewTextBoxColumn();
            Maskapai = new DataGridViewTextBoxColumn();
            JumlahPenumpang = new DataGridViewTextBoxColumn();
            TotalHarga = new DataGridViewTextBoxColumn();
            KodePromoID = new DataGridViewTextBoxColumn();
            KodePromo = new DataGridViewTextBoxColumn();
            lblDetailPenumpang = new Label();
            lblSelectedTransaksi = new Label();
            dgvDetailPenumpang = new DataGridView();
            DetailID = new DataGridViewTextBoxColumn();
            TransaksiHeaderID = new DataGridViewTextBoxColumn();
            TitelPenumpang = new DataGridViewTextBoxColumn();
            NamaLengkapPenumpang = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetailPenumpang).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(393, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TRANSAKSI - ADMIN";
            // 
            // lblDaftarTransaksi
            // 
            lblDaftarTransaksi.AutoSize = true;
            lblDaftarTransaksi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblDaftarTransaksi.ForeColor = Color.Navy;
            lblDaftarTransaksi.Location = new Point(20, 86);
            lblDaftarTransaksi.Name = "lblDaftarTransaksi";
            lblDaftarTransaksi.Size = new Size(177, 25);
            lblDaftarTransaksi.TabIndex = 1;
            lblDaftarTransaksi.Text = "Daftar Transaksi";
            // 
            // txtCariTransaksi
            // 
            txtCariTransaksi.BorderStyle = BorderStyle.FixedSingle;
            txtCariTransaksi.Location = new Point(670, 82);
            txtCariTransaksi.Name = "txtCariTransaksi";
            txtCariTransaksi.PlaceholderText = "Cari Transaksi.....";
            txtCariTransaksi.Size = new Size(250, 31);
            txtCariTransaksi.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Azure;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.Gray;
            btnRefresh.Location = new Point(930, 80);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 35);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Crimson;
            btnHapus.Cursor = Cursors.Hand;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(1050, 80);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(110, 35);
            btnHapus.TabIndex = 4;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // dgvTransaksi
            // 
            dgvTransaksi.AllowUserToAddRows = false;
            dgvTransaksi.AllowUserToDeleteRows = false;
            dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaksi.Columns.AddRange(new DataGridViewColumn[] { ID, AkunID, NamaAkun, TanggalTransaksi, JadwalPenerbanganID, KodePenerbangan, Rute, Maskapai, JumlahPenumpang, TotalHarga, KodePromoID, KodePromo });
            dgvTransaksi.Location = new Point(20, 125);
            dgvTransaksi.Name = "dgvTransaksi";
            dgvTransaksi.ReadOnly = true;
            dgvTransaksi.RowHeadersVisible = false;
            dgvTransaksi.RowHeadersWidth = 51;
            dgvTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransaksi.Size = new Size(1140, 320);
            dgvTransaksi.TabIndex = 5;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // AkunID
            // 
            AkunID.HeaderText = "AkunID";
            AkunID.MinimumWidth = 6;
            AkunID.Name = "AkunID";
            AkunID.ReadOnly = true;
            AkunID.Visible = false;
            // 
            // NamaAkun
            // 
            NamaAkun.HeaderText = "Akun";
            NamaAkun.MinimumWidth = 6;
            NamaAkun.Name = "NamaAkun";
            NamaAkun.ReadOnly = true;
            // 
            // TanggalTransaksi
            // 
            TanggalTransaksi.HeaderText = "Tanggal";
            TanggalTransaksi.MinimumWidth = 6;
            TanggalTransaksi.Name = "TanggalTransaksi";
            TanggalTransaksi.ReadOnly = true;
            // 
            // JadwalPenerbanganID
            // 
            JadwalPenerbanganID.HeaderText = "JadwalPenerbanganID";
            JadwalPenerbanganID.MinimumWidth = 6;
            JadwalPenerbanganID.Name = "JadwalPenerbanganID";
            JadwalPenerbanganID.ReadOnly = true;
            JadwalPenerbanganID.Visible = false;
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
            // KodePromoID
            // 
            KodePromoID.HeaderText = "KodePromoID";
            KodePromoID.MinimumWidth = 6;
            KodePromoID.Name = "KodePromoID";
            KodePromoID.ReadOnly = true;
            KodePromoID.Visible = false;
            // 
            // KodePromo
            // 
            KodePromo.HeaderText = "Promo";
            KodePromo.MinimumWidth = 6;
            KodePromo.Name = "KodePromo";
            KodePromo.ReadOnly = true;
            // 
            // lblDetailPenumpang
            // 
            lblDetailPenumpang.AutoSize = true;
            lblDetailPenumpang.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblDetailPenumpang.ForeColor = Color.Navy;
            lblDetailPenumpang.Location = new Point(20, 465);
            lblDetailPenumpang.Name = "lblDetailPenumpang";
            lblDetailPenumpang.Size = new Size(198, 25);
            lblDetailPenumpang.TabIndex = 6;
            lblDetailPenumpang.Text = "Detail Penumpang";
            // 
            // lblSelectedTransaksi
            // 
            lblSelectedTransaksi.AutoSize = true;
            lblSelectedTransaksi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblSelectedTransaksi.ForeColor = Color.Navy;
            lblSelectedTransaksi.Location = new Point(235, 465);
            lblSelectedTransaksi.Name = "lblSelectedTransaksi";
            lblSelectedTransaksi.Size = new Size(17, 25);
            lblSelectedTransaksi.TabIndex = 7;
            lblSelectedTransaksi.Text = "-";
            // 
            // dgvDetailPenumpang
            // 
            dgvDetailPenumpang.AllowUserToAddRows = false;
            dgvDetailPenumpang.AllowUserToDeleteRows = false;
            dgvDetailPenumpang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetailPenumpang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetailPenumpang.Columns.AddRange(new DataGridViewColumn[] { DetailID, TransaksiHeaderID, TitelPenumpang, NamaLengkapPenumpang });
            dgvDetailPenumpang.Location = new Point(20, 500);
            dgvDetailPenumpang.Name = "dgvDetailPenumpang";
            dgvDetailPenumpang.ReadOnly = true;
            dgvDetailPenumpang.RowHeadersVisible = false;
            dgvDetailPenumpang.RowHeadersWidth = 51;
            dgvDetailPenumpang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetailPenumpang.Size = new Size(1140, 185);
            dgvDetailPenumpang.TabIndex = 8;
            // 
            // DetailID
            // 
            DetailID.HeaderText = "ID";
            DetailID.MinimumWidth = 6;
            DetailID.Name = "DetailID";
            DetailID.ReadOnly = true;
            // 
            // TransaksiHeaderID
            // 
            TransaksiHeaderID.HeaderText = "TransaksiHeaderID";
            TransaksiHeaderID.MinimumWidth = 6;
            TransaksiHeaderID.Name = "TransaksiHeaderID";
            TransaksiHeaderID.ReadOnly = true;
            TransaksiHeaderID.Visible = false;
            // 
            // TitelPenumpang
            // 
            TitelPenumpang.HeaderText = "Titel";
            TitelPenumpang.MinimumWidth = 6;
            TitelPenumpang.Name = "TitelPenumpang";
            TitelPenumpang.ReadOnly = true;
            // 
            // NamaLengkapPenumpang
            // 
            NamaLengkapPenumpang.HeaderText = "Nama Lengkap";
            NamaLengkapPenumpang.MinimumWidth = 6;
            NamaLengkapPenumpang.Name = "NamaLengkapPenumpang";
            NamaLengkapPenumpang.ReadOnly = true;
            // 
            // TransaksiForm
            // 
            AutoScroll = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1182, 715);
            Controls.Add(dgvDetailPenumpang);
            Controls.Add(lblSelectedTransaksi);
            Controls.Add(lblDetailPenumpang);
            Controls.Add(dgvTransaksi);
            Controls.Add(btnHapus);
            Controls.Add(btnRefresh);
            Controls.Add(txtCariTransaksi);
            Controls.Add(lblDaftarTransaksi);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.8F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransaksiForm";
            Text = "TransaksiForm";
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetailPenumpang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblDaftarTransaksi;
        private TextBox txtCariTransaksi;
        private Button btnRefresh;
        private Button btnHapus;
        private DataGridView dgvTransaksi;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn AkunID;
        private DataGridViewTextBoxColumn NamaAkun;
        private DataGridViewTextBoxColumn TanggalTransaksi;
        private DataGridViewTextBoxColumn JadwalPenerbanganID;
        private DataGridViewTextBoxColumn KodePenerbangan;
        private DataGridViewTextBoxColumn Rute;
        private DataGridViewTextBoxColumn Maskapai;
        private DataGridViewTextBoxColumn JumlahPenumpang;
        private DataGridViewTextBoxColumn TotalHarga;
        private DataGridViewTextBoxColumn KodePromoID;
        private DataGridViewTextBoxColumn KodePromo;
        private Label lblDetailPenumpang;
        private Label lblSelectedTransaksi;
        private DataGridView dgvDetailPenumpang;
        private DataGridViewTextBoxColumn DetailID;
        private DataGridViewTextBoxColumn TransaksiHeaderID;
        private DataGridViewTextBoxColumn TitelPenumpang;
        private DataGridViewTextBoxColumn NamaLengkapPenumpang;
    }
}
