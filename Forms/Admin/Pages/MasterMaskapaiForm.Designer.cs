namespace BromoAirlines.Forms
{
    partial class MasterMaskapaiForm
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
            gbMaskapai = new GroupBox();
            txtDeskripsi = new TextBox();
            lblDeskripsi = new Label();
            btnReset = new Button();
            btnHapus = new Button();
            btnEdit = new Button();
            btnTambah = new Button();
            numJumlahKru = new NumericUpDown();
            lblJumlahKru = new Label();
            txtPerusahaan = new TextBox();
            lblPerusahaan = new Label();
            txtNamaMaskapai = new TextBox();
            lblNamaMaskapai = new Label();
            lblDaftarMaskapai = new Label();
            txtCariMaskapai = new TextBox();
            dgvMaskapai = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NamaMaskapai = new DataGridViewTextBoxColumn();
            Perusahaan = new DataGridViewTextBoxColumn();
            JumlahKru = new DataGridViewTextBoxColumn();
            Deskripsi = new DataGridViewTextBoxColumn();
            gbMaskapai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlahKru).BeginInit();
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
            lblTitle.Size = new Size(605, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "MASTER MASKAPAI - ADMIN";
            // 
            // gbMaskapai
            // 
            gbMaskapai.Controls.Add(txtDeskripsi);
            gbMaskapai.Controls.Add(lblDeskripsi);
            gbMaskapai.Controls.Add(btnReset);
            gbMaskapai.Controls.Add(btnHapus);
            gbMaskapai.Controls.Add(btnEdit);
            gbMaskapai.Controls.Add(btnTambah);
            gbMaskapai.Controls.Add(numJumlahKru);
            gbMaskapai.Controls.Add(lblJumlahKru);
            gbMaskapai.Controls.Add(txtPerusahaan);
            gbMaskapai.Controls.Add(lblPerusahaan);
            gbMaskapai.Controls.Add(txtNamaMaskapai);
            gbMaskapai.Controls.Add(lblNamaMaskapai);
            gbMaskapai.Location = new Point(20, 90);
            gbMaskapai.Name = "gbMaskapai";
            gbMaskapai.Size = new Size(1140, 290);
            gbMaskapai.TabIndex = 1;
            gbMaskapai.TabStop = false;
            gbMaskapai.Text = "Data Maskapai";
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.BorderStyle = BorderStyle.FixedSingle;
            txtDeskripsi.Location = new Point(670, 48);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(420, 125);
            txtDeskripsi.TabIndex = 7;
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.Location = new Point(560, 50);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(90, 25);
            lblDeskripsi.TabIndex = 6;
            lblDeskripsi.Text = "Deskripsi:";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Azure;
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.Gray;
            btnReset.Location = new Point(980, 225);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(110, 40);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Crimson;
            btnHapus.Cursor = Cursors.Hand;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(850, 225);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(110, 40);
            btnHapus.TabIndex = 10;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.ForestGreen;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(720, 225);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 40);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.DodgerBlue;
            btnTambah.Cursor = Cursors.Hand;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(590, 225);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(110, 40);
            btnTambah.TabIndex = 8;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // numJumlahKru
            // 
            numJumlahKru.Location = new Point(200, 150);
            numJumlahKru.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numJumlahKru.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numJumlahKru.Name = "numJumlahKru";
            numJumlahKru.Size = new Size(120, 31);
            numJumlahKru.TabIndex = 5;
            numJumlahKru.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblJumlahKru
            // 
            lblJumlahKru.AutoSize = true;
            lblJumlahKru.Location = new Point(30, 150);
            lblJumlahKru.Name = "lblJumlahKru";
            lblJumlahKru.Size = new Size(108, 25);
            lblJumlahKru.TabIndex = 4;
            lblJumlahKru.Text = "Jumlah Kru:";
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.BorderStyle = BorderStyle.FixedSingle;
            txtPerusahaan.Location = new Point(200, 100);
            txtPerusahaan.MaxLength = 200;
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(320, 31);
            txtPerusahaan.TabIndex = 3;
            // 
            // lblPerusahaan
            // 
            lblPerusahaan.AutoSize = true;
            lblPerusahaan.Location = new Point(30, 100);
            lblPerusahaan.Name = "lblPerusahaan";
            lblPerusahaan.Size = new Size(107, 25);
            lblPerusahaan.TabIndex = 2;
            lblPerusahaan.Text = "Perusahaan:";
            // 
            // txtNamaMaskapai
            // 
            txtNamaMaskapai.BorderStyle = BorderStyle.FixedSingle;
            txtNamaMaskapai.Location = new Point(200, 50);
            txtNamaMaskapai.MaxLength = 200;
            txtNamaMaskapai.Name = "txtNamaMaskapai";
            txtNamaMaskapai.Size = new Size(320, 31);
            txtNamaMaskapai.TabIndex = 1;
            // 
            // lblNamaMaskapai
            // 
            lblNamaMaskapai.AutoSize = true;
            lblNamaMaskapai.Location = new Point(30, 50);
            lblNamaMaskapai.Name = "lblNamaMaskapai";
            lblNamaMaskapai.Size = new Size(144, 25);
            lblNamaMaskapai.TabIndex = 0;
            lblNamaMaskapai.Text = "Nama Maskapai:";
            // 
            // lblDaftarMaskapai
            // 
            lblDaftarMaskapai.AutoSize = true;
            lblDaftarMaskapai.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblDaftarMaskapai.ForeColor = Color.Navy;
            lblDaftarMaskapai.Location = new Point(20, 398);
            lblDaftarMaskapai.Name = "lblDaftarMaskapai";
            lblDaftarMaskapai.Size = new Size(206, 25);
            lblDaftarMaskapai.TabIndex = 2;
            lblDaftarMaskapai.Text = "Daftar Maskapai";
            // 
            // txtCariMaskapai
            // 
            txtCariMaskapai.BorderStyle = BorderStyle.FixedSingle;
            txtCariMaskapai.Location = new Point(910, 392);
            txtCariMaskapai.Name = "txtCariMaskapai";
            txtCariMaskapai.PlaceholderText = "Cari Maskapai.....";
            txtCariMaskapai.Size = new Size(250, 31);
            txtCariMaskapai.TabIndex = 3;
            // 
            // dgvMaskapai
            // 
            dgvMaskapai.AllowUserToAddRows = false;
            dgvMaskapai.AllowUserToDeleteRows = false;
            dgvMaskapai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaskapai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaskapai.Columns.AddRange(new DataGridViewColumn[] { ID, NamaMaskapai, Perusahaan, JumlahKru, Deskripsi });
            dgvMaskapai.Location = new Point(20, 435);
            dgvMaskapai.Name = "dgvMaskapai";
            dgvMaskapai.ReadOnly = true;
            dgvMaskapai.RowHeadersVisible = false;
            dgvMaskapai.RowHeadersWidth = 51;
            dgvMaskapai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaskapai.Size = new Size(1140, 250);
            dgvMaskapai.TabIndex = 4;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // NamaMaskapai
            // 
            NamaMaskapai.HeaderText = "Nama Maskapai";
            NamaMaskapai.MinimumWidth = 6;
            NamaMaskapai.Name = "NamaMaskapai";
            NamaMaskapai.ReadOnly = true;
            // 
            // Perusahaan
            // 
            Perusahaan.HeaderText = "Perusahaan";
            Perusahaan.MinimumWidth = 6;
            Perusahaan.Name = "Perusahaan";
            Perusahaan.ReadOnly = true;
            // 
            // JumlahKru
            // 
            JumlahKru.HeaderText = "Jumlah Kru";
            JumlahKru.MinimumWidth = 6;
            JumlahKru.Name = "JumlahKru";
            JumlahKru.ReadOnly = true;
            // 
            // Deskripsi
            // 
            Deskripsi.HeaderText = "Deskripsi";
            Deskripsi.MinimumWidth = 6;
            Deskripsi.Name = "Deskripsi";
            Deskripsi.ReadOnly = true;
            // 
            // MasterMaskapaiForm
            // 
            AutoScroll = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1182, 715);
            Controls.Add(dgvMaskapai);
            Controls.Add(txtCariMaskapai);
            Controls.Add(lblDaftarMaskapai);
            Controls.Add(gbMaskapai);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.8F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MasterMaskapaiForm";
            Text = "MasterMaskapaiForm";
            gbMaskapai.ResumeLayout(false);
            gbMaskapai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlahKru).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMaskapai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private GroupBox gbMaskapai;
        private TextBox txtNamaMaskapai;
        private Label lblNamaMaskapai;
        private TextBox txtPerusahaan;
        private Label lblPerusahaan;
        private NumericUpDown numJumlahKru;
        private Label lblJumlahKru;
        private TextBox txtDeskripsi;
        private Label lblDeskripsi;
        private Button btnReset;
        private Button btnHapus;
        private Button btnEdit;
        private Button btnTambah;
        private Label lblDaftarMaskapai;
        private TextBox txtCariMaskapai;
        private DataGridView dgvMaskapai;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NamaMaskapai;
        private DataGridViewTextBoxColumn Perusahaan;
        private DataGridViewTextBoxColumn JumlahKru;
        private DataGridViewTextBoxColumn Deskripsi;
    }
}
