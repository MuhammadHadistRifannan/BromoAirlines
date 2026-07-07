namespace BromoAirlines.Forms
{
    partial class MasterKodePromoForm
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
            gbKodePromo = new GroupBox();
            lblRupiahPrefix = new Label();
            txtDeskripsi = new TextBox();
            lblDeskripsi = new Label();
            dtpBerlakuSampai = new DateTimePicker();
            lblBerlakuSampai = new Label();
            numMaksimumDiskon = new NumericUpDown();
            lblMaksimumDiskon = new Label();
            numPersentaseDiskon = new NumericUpDown();
            lblPersentaseDiskon = new Label();
            btnReset = new Button();
            btnHapus = new Button();
            btnEdit = new Button();
            btnTambah = new Button();
            txtKode = new TextBox();
            lblKode = new Label();
            lblDaftarPromo = new Label();
            txtCariPromo = new TextBox();
            dgvKodePromo = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Kode = new DataGridViewTextBoxColumn();
            PersentaseDiskon = new DataGridViewTextBoxColumn();
            MaksimumDiskon = new DataGridViewTextBoxColumn();
            BerlakuSampai = new DataGridViewTextBoxColumn();
            Deskripsi = new DataGridViewTextBoxColumn();
            gbKodePromo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMaksimumDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPersentaseDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKodePromo).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(639, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "MASTER KODE PROMO - ADMIN";
            // 
            // gbKodePromo
            // 
            gbKodePromo.Controls.Add(lblRupiahPrefix);
            gbKodePromo.Controls.Add(txtDeskripsi);
            gbKodePromo.Controls.Add(lblDeskripsi);
            gbKodePromo.Controls.Add(dtpBerlakuSampai);
            gbKodePromo.Controls.Add(lblBerlakuSampai);
            gbKodePromo.Controls.Add(numMaksimumDiskon);
            gbKodePromo.Controls.Add(lblMaksimumDiskon);
            gbKodePromo.Controls.Add(numPersentaseDiskon);
            gbKodePromo.Controls.Add(lblPersentaseDiskon);
            gbKodePromo.Controls.Add(btnReset);
            gbKodePromo.Controls.Add(btnHapus);
            gbKodePromo.Controls.Add(btnEdit);
            gbKodePromo.Controls.Add(btnTambah);
            gbKodePromo.Controls.Add(txtKode);
            gbKodePromo.Controls.Add(lblKode);
            gbKodePromo.Location = new Point(20, 90);
            gbKodePromo.Name = "gbKodePromo";
            gbKodePromo.Size = new Size(1140, 290);
            gbKodePromo.TabIndex = 1;
            gbKodePromo.TabStop = false;
            gbKodePromo.Text = "Data Kode Promo";
            // 
            // lblRupiahPrefix
            // 
            lblRupiahPrefix.AutoSize = true;
            lblRupiahPrefix.Location = new Point(210, 153);
            lblRupiahPrefix.Name = "lblRupiahPrefix";
            lblRupiahPrefix.Size = new Size(33, 25);
            lblRupiahPrefix.TabIndex = 6;
            lblRupiahPrefix.Text = "Rp";
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.BorderStyle = BorderStyle.FixedSingle;
            txtDeskripsi.Location = new Point(680, 48);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(410, 125);
            txtDeskripsi.TabIndex = 11;
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.Location = new Point(560, 50);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(90, 25);
            lblDeskripsi.TabIndex = 10;
            lblDeskripsi.Text = "Deskripsi:";
            // 
            // dtpBerlakuSampai
            // 
            dtpBerlakuSampai.CustomFormat = "dd/MM/yyyy";
            dtpBerlakuSampai.Format = DateTimePickerFormat.Custom;
            dtpBerlakuSampai.Location = new Point(210, 200);
            dtpBerlakuSampai.Name = "dtpBerlakuSampai";
            dtpBerlakuSampai.Size = new Size(180, 31);
            dtpBerlakuSampai.TabIndex = 9;
            // 
            // lblBerlakuSampai
            // 
            lblBerlakuSampai.AutoSize = true;
            lblBerlakuSampai.Location = new Point(30, 200);
            lblBerlakuSampai.Name = "lblBerlakuSampai";
            lblBerlakuSampai.Size = new Size(144, 25);
            lblBerlakuSampai.TabIndex = 8;
            lblBerlakuSampai.Text = "Berlaku Sampai:";
            // 
            // numMaksimumDiskon
            // 
            numMaksimumDiskon.Location = new Point(250, 150);
            numMaksimumDiskon.Maximum = new decimal(new int[] { 2000000000, 0, 0, 0 });
            numMaksimumDiskon.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMaksimumDiskon.Name = "numMaksimumDiskon";
            numMaksimumDiskon.Size = new Size(220, 31);
            numMaksimumDiskon.TabIndex = 7;
            numMaksimumDiskon.ThousandsSeparator = true;
            numMaksimumDiskon.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblMaksimumDiskon
            // 
            lblMaksimumDiskon.AutoSize = true;
            lblMaksimumDiskon.Location = new Point(30, 150);
            lblMaksimumDiskon.Name = "lblMaksimumDiskon";
            lblMaksimumDiskon.Size = new Size(157, 25);
            lblMaksimumDiskon.TabIndex = 5;
            lblMaksimumDiskon.Text = "Maksimum Diskon:";
            // 
            // numPersentaseDiskon
            // 
            numPersentaseDiskon.Location = new Point(210, 100);
            numPersentaseDiskon.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numPersentaseDiskon.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPersentaseDiskon.Name = "numPersentaseDiskon";
            numPersentaseDiskon.Size = new Size(120, 31);
            numPersentaseDiskon.TabIndex = 4;
            numPersentaseDiskon.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblPersentaseDiskon
            // 
            lblPersentaseDiskon.AutoSize = true;
            lblPersentaseDiskon.Location = new Point(30, 100);
            lblPersentaseDiskon.Name = "lblPersentaseDiskon";
            lblPersentaseDiskon.Size = new Size(174, 25);
            lblPersentaseDiskon.TabIndex = 3;
            lblPersentaseDiskon.Text = "Persentase Diskon:";
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
            btnReset.TabIndex = 15;
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
            btnHapus.TabIndex = 14;
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
            btnEdit.TabIndex = 13;
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
            btnTambah.TabIndex = 12;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // txtKode
            // 
            txtKode.BorderStyle = BorderStyle.FixedSingle;
            txtKode.Location = new Point(210, 50);
            txtKode.MaxLength = 100;
            txtKode.Name = "txtKode";
            txtKode.Size = new Size(260, 31);
            txtKode.TabIndex = 2;
            // 
            // lblKode
            // 
            lblKode.AutoSize = true;
            lblKode.Location = new Point(30, 50);
            lblKode.Name = "lblKode";
            lblKode.Size = new Size(112, 25);
            lblKode.TabIndex = 1;
            lblKode.Text = "Kode Promo:";
            // 
            // lblDaftarPromo
            // 
            lblDaftarPromo.AutoSize = true;
            lblDaftarPromo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblDaftarPromo.ForeColor = Color.Navy;
            lblDaftarPromo.Location = new Point(20, 398);
            lblDaftarPromo.Name = "lblDaftarPromo";
            lblDaftarPromo.Size = new Size(211, 25);
            lblDaftarPromo.TabIndex = 2;
            lblDaftarPromo.Text = "Daftar Kode Promo";
            // 
            // txtCariPromo
            // 
            txtCariPromo.BorderStyle = BorderStyle.FixedSingle;
            txtCariPromo.Location = new Point(910, 392);
            txtCariPromo.Name = "txtCariPromo";
            txtCariPromo.PlaceholderText = "Cari Promo.....";
            txtCariPromo.Size = new Size(250, 31);
            txtCariPromo.TabIndex = 3;
            // 
            // dgvKodePromo
            // 
            dgvKodePromo.AllowUserToAddRows = false;
            dgvKodePromo.AllowUserToDeleteRows = false;
            dgvKodePromo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKodePromo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKodePromo.Columns.AddRange(new DataGridViewColumn[] { ID, Kode, PersentaseDiskon, MaksimumDiskon, BerlakuSampai, Deskripsi });
            dgvKodePromo.Location = new Point(20, 435);
            dgvKodePromo.Name = "dgvKodePromo";
            dgvKodePromo.ReadOnly = true;
            dgvKodePromo.RowHeadersVisible = false;
            dgvKodePromo.RowHeadersWidth = 51;
            dgvKodePromo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKodePromo.Size = new Size(1140, 250);
            dgvKodePromo.TabIndex = 4;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Kode
            // 
            Kode.HeaderText = "Kode";
            Kode.MinimumWidth = 6;
            Kode.Name = "Kode";
            Kode.ReadOnly = true;
            // 
            // PersentaseDiskon
            // 
            PersentaseDiskon.HeaderText = "Diskon";
            PersentaseDiskon.MinimumWidth = 6;
            PersentaseDiskon.Name = "PersentaseDiskon";
            PersentaseDiskon.ReadOnly = true;
            // 
            // MaksimumDiskon
            // 
            MaksimumDiskon.HeaderText = "Maksimum Diskon";
            MaksimumDiskon.MinimumWidth = 6;
            MaksimumDiskon.Name = "MaksimumDiskon";
            MaksimumDiskon.ReadOnly = true;
            MaksimumDiskon.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            // 
            // BerlakuSampai
            // 
            BerlakuSampai.HeaderText = "Berlaku Sampai";
            BerlakuSampai.MinimumWidth = 6;
            BerlakuSampai.Name = "BerlakuSampai";
            BerlakuSampai.ReadOnly = true;
            // 
            // Deskripsi
            // 
            Deskripsi.HeaderText = "Deskripsi";
            Deskripsi.MinimumWidth = 6;
            Deskripsi.Name = "Deskripsi";
            Deskripsi.ReadOnly = true;
            // 
            // MasterKodePromoForm
            // 
            AutoScroll = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1182, 715);
            Controls.Add(dgvKodePromo);
            Controls.Add(txtCariPromo);
            Controls.Add(lblDaftarPromo);
            Controls.Add(gbKodePromo);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.8F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MasterKodePromoForm";
            Text = "MasterKodePromoForm";
            gbKodePromo.ResumeLayout(false);
            gbKodePromo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMaksimumDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPersentaseDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKodePromo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private GroupBox gbKodePromo;
        private Label lblRupiahPrefix;
        private TextBox txtKode;
        private Label lblKode;
        private NumericUpDown numPersentaseDiskon;
        private Label lblPersentaseDiskon;
        private NumericUpDown numMaksimumDiskon;
        private Label lblMaksimumDiskon;
        private DateTimePicker dtpBerlakuSampai;
        private Label lblBerlakuSampai;
        private TextBox txtDeskripsi;
        private Label lblDeskripsi;
        private Button btnReset;
        private Button btnHapus;
        private Button btnEdit;
        private Button btnTambah;
        private Label lblDaftarPromo;
        private TextBox txtCariPromo;
        private DataGridView dgvKodePromo;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Kode;
        private DataGridViewTextBoxColumn PersentaseDiskon;
        private DataGridViewTextBoxColumn MaksimumDiskon;
        private DataGridViewTextBoxColumn BerlakuSampai;
        private DataGridViewTextBoxColumn Deskripsi;
    }
}
