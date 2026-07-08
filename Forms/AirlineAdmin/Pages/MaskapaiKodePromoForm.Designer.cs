namespace BromoAirlines.Forms.AirlineAdmin.Pages;

partial class MaskapaiKodePromoForm
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
        gbPromo = new GroupBox();
        txtDeskripsi = new TextBox();
        lblDeskripsi = new Label();
        dtpBerlakuSampai = new DateTimePicker();
        lblBerlakuSampai = new Label();
        lblRupiahPrefix = new Label();
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
        dgvPromo = new DataGridView();
        ID = new DataGridViewTextBoxColumn();
        Kode = new DataGridViewTextBoxColumn();
        PersentaseDiskon = new DataGridViewTextBoxColumn();
        MaksimumDiskon = new DataGridViewTextBoxColumn();
        BerlakuSampai = new DataGridViewTextBoxColumn();
        StatusPromo = new DataGridViewTextBoxColumn();
        Deskripsi = new DataGridViewTextBoxColumn();
        gbPromo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numMaksimumDiskon).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numPersentaseDiskon).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvPromo).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblTitle.ForeColor = Color.Navy;
        lblTitle.Location = new Point(28, 24);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(387, 50);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Kode Promo";
        // 
        // gbPromo
        // 
        gbPromo.Controls.Add(txtDeskripsi);
        gbPromo.Controls.Add(lblDeskripsi);
        gbPromo.Controls.Add(dtpBerlakuSampai);
        gbPromo.Controls.Add(lblBerlakuSampai);
        gbPromo.Controls.Add(lblRupiahPrefix);
        gbPromo.Controls.Add(numMaksimumDiskon);
        gbPromo.Controls.Add(lblMaksimumDiskon);
        gbPromo.Controls.Add(numPersentaseDiskon);
        gbPromo.Controls.Add(lblPersentaseDiskon);
        gbPromo.Controls.Add(btnReset);
        gbPromo.Controls.Add(btnHapus);
        gbPromo.Controls.Add(btnEdit);
        gbPromo.Controls.Add(btnTambah);
        gbPromo.Controls.Add(txtKode);
        gbPromo.Controls.Add(lblKode);
        gbPromo.Location = new Point(28, 94);
        gbPromo.Name = "gbPromo";
        gbPromo.Size = new Size(1240, 300);
        gbPromo.TabIndex = 1;
        gbPromo.TabStop = false;
        gbPromo.Text = "Data Promo";
        // 
        // txtDeskripsi
        // 
        txtDeskripsi.BorderStyle = BorderStyle.FixedSingle;
        txtDeskripsi.Location = new Point(785, 104);
        txtDeskripsi.Multiline = true;
        txtDeskripsi.Name = "txtDeskripsi";
        txtDeskripsi.Size = new Size(360, 78);
        txtDeskripsi.TabIndex = 11;
        // 
        // lblDeskripsi
        // 
        lblDeskripsi.AutoSize = true;
        lblDeskripsi.Location = new Point(600, 108);
        lblDeskripsi.Name = "lblDeskripsi";
        lblDeskripsi.Size = new Size(69, 20);
        lblDeskripsi.TabIndex = 10;
        lblDeskripsi.Text = "Deskripsi";
        // 
        // dtpBerlakuSampai
        // 
        dtpBerlakuSampai.CustomFormat = "dd/MM/yyyy";
        dtpBerlakuSampai.Format = DateTimePickerFormat.Custom;
        dtpBerlakuSampai.Location = new Point(785, 54);
        dtpBerlakuSampai.Name = "dtpBerlakuSampai";
        dtpBerlakuSampai.Size = new Size(180, 27);
        dtpBerlakuSampai.TabIndex = 9;
        // 
        // lblBerlakuSampai
        // 
        lblBerlakuSampai.AutoSize = true;
        lblBerlakuSampai.Location = new Point(600, 58);
        lblBerlakuSampai.Name = "lblBerlakuSampai";
        lblBerlakuSampai.Size = new Size(115, 20);
        lblBerlakuSampai.TabIndex = 8;
        lblBerlakuSampai.Text = "Berlaku Sampai";
        // 
        // lblRupiahPrefix
        // 
        lblRupiahPrefix.AutoSize = true;
        lblRupiahPrefix.Location = new Point(230, 158);
        lblRupiahPrefix.Name = "lblRupiahPrefix";
        lblRupiahPrefix.Size = new Size(29, 20);
        lblRupiahPrefix.TabIndex = 6;
        lblRupiahPrefix.Text = "Rp";
        // 
        // numMaksimumDiskon
        // 
        numMaksimumDiskon.Location = new Point(270, 154);
        numMaksimumDiskon.Maximum = new decimal(new int[] { 2000000000, 0, 0, 0 });
        numMaksimumDiskon.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numMaksimumDiskon.Name = "numMaksimumDiskon";
        numMaksimumDiskon.Size = new Size(180, 27);
        numMaksimumDiskon.TabIndex = 7;
        numMaksimumDiskon.ThousandsSeparator = true;
        numMaksimumDiskon.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblMaksimumDiskon
        // 
        lblMaksimumDiskon.AutoSize = true;
        lblMaksimumDiskon.Location = new Point(30, 158);
        lblMaksimumDiskon.Name = "lblMaksimumDiskon";
        lblMaksimumDiskon.Size = new Size(132, 20);
        lblMaksimumDiskon.TabIndex = 5;
        lblMaksimumDiskon.Text = "Maksimum Diskon";
        // 
        // numPersentaseDiskon
        // 
        numPersentaseDiskon.DecimalPlaces = 2;
        numPersentaseDiskon.Location = new Point(230, 104);
        numPersentaseDiskon.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
        numPersentaseDiskon.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numPersentaseDiskon.Name = "numPersentaseDiskon";
        numPersentaseDiskon.Size = new Size(120, 27);
        numPersentaseDiskon.TabIndex = 4;
        numPersentaseDiskon.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblPersentaseDiskon
        // 
        lblPersentaseDiskon.AutoSize = true;
        lblPersentaseDiskon.Location = new Point(30, 108);
        lblPersentaseDiskon.Name = "lblPersentaseDiskon";
        lblPersentaseDiskon.Size = new Size(137, 20);
        lblPersentaseDiskon.TabIndex = 3;
        lblPersentaseDiskon.Text = "Persentase Diskon";
        // 
        // btnReset
        // 
        btnReset.BackColor = Color.Azure;
        btnReset.FlatStyle = FlatStyle.Flat;
        btnReset.ForeColor = Color.Gray;
        btnReset.Location = new Point(1095, 236);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(110, 40);
        btnReset.TabIndex = 15;
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
        btnHapus.TabIndex = 14;
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
        btnEdit.TabIndex = 13;
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
        btnTambah.TabIndex = 12;
        btnTambah.Text = "Tambah";
        btnTambah.UseVisualStyleBackColor = false;
        // 
        // txtKode
        // 
        txtKode.BorderStyle = BorderStyle.FixedSingle;
        txtKode.Location = new Point(230, 54);
        txtKode.MaxLength = 50;
        txtKode.Name = "txtKode";
        txtKode.Size = new Size(180, 27);
        txtKode.TabIndex = 2;
        // 
        // lblKode
        // 
        lblKode.AutoSize = true;
        lblKode.Location = new Point(30, 58);
        lblKode.Name = "lblKode";
        lblKode.Size = new Size(91, 20);
        lblKode.TabIndex = 1;
        lblKode.Text = "Kode Promo";
        // 
        // lblDaftarPromo
        // 
        lblDaftarPromo.AutoSize = true;
        lblDaftarPromo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblDaftarPromo.ForeColor = Color.Navy;
        lblDaftarPromo.Location = new Point(28, 426);
        lblDaftarPromo.Name = "lblDaftarPromo";
        lblDaftarPromo.Size = new Size(253, 32);
        lblDaftarPromo.TabIndex = 2;
        lblDaftarPromo.Text = "Daftar Promo Maskapai";
        // 
        // txtCariPromo
        // 
        txtCariPromo.BorderStyle = BorderStyle.FixedSingle;
        txtCariPromo.Location = new Point(1018, 431);
        txtCariPromo.Name = "txtCariPromo";
        txtCariPromo.PlaceholderText = "Cari promo...";
        txtCariPromo.Size = new Size(250, 27);
        txtCariPromo.TabIndex = 3;
        // 
        // dgvPromo
        // 
        dgvPromo.AllowUserToAddRows = false;
        dgvPromo.AllowUserToDeleteRows = false;
        dgvPromo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvPromo.BackgroundColor = Color.White;
        dgvPromo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPromo.Columns.AddRange(new DataGridViewColumn[] { ID, Kode, PersentaseDiskon, MaksimumDiskon, BerlakuSampai, StatusPromo, Deskripsi });
        dgvPromo.Location = new Point(28, 476);
        dgvPromo.Name = "dgvPromo";
        dgvPromo.ReadOnly = true;
        dgvPromo.RowHeadersVisible = false;
        dgvPromo.RowHeadersWidth = 51;
        dgvPromo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPromo.Size = new Size(1240, 320);
        dgvPromo.TabIndex = 4;
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
        PersentaseDiskon.HeaderText = "Diskon (%)";
        PersentaseDiskon.MinimumWidth = 6;
        PersentaseDiskon.Name = "PersentaseDiskon";
        PersentaseDiskon.ReadOnly = true;
        // 
        // MaksimumDiskon
        // 
        MaksimumDiskon.HeaderText = "Maksimum";
        MaksimumDiskon.MinimumWidth = 6;
        MaksimumDiskon.Name = "MaksimumDiskon";
        MaksimumDiskon.ReadOnly = true;
        // 
        // BerlakuSampai
        // 
        BerlakuSampai.HeaderText = "Berlaku Sampai";
        BerlakuSampai.MinimumWidth = 6;
        BerlakuSampai.Name = "BerlakuSampai";
        BerlakuSampai.ReadOnly = true;
        // 
        // StatusPromo
        // 
        StatusPromo.HeaderText = "Status";
        StatusPromo.MinimumWidth = 6;
        StatusPromo.Name = "StatusPromo";
        StatusPromo.ReadOnly = true;
        // 
        // Deskripsi
        // 
        Deskripsi.HeaderText = "Deskripsi";
        Deskripsi.MinimumWidth = 6;
        Deskripsi.Name = "Deskripsi";
        Deskripsi.ReadOnly = true;
        // 
        // MaskapaiKodePromoForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(1375, 1050);
        Controls.Add(dgvPromo);
        Controls.Add(txtCariPromo);
        Controls.Add(lblDaftarPromo);
        Controls.Add(gbPromo);
        Controls.Add(lblTitle);
        FormBorderStyle = FormBorderStyle.None;
        Name = "MaskapaiKodePromoForm";
        Text = "MaskapaiKodePromoForm";
        gbPromo.ResumeLayout(false);
        gbPromo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numMaksimumDiskon).EndInit();
        ((System.ComponentModel.ISupportInitialize)numPersentaseDiskon).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvPromo).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitle;
    private GroupBox gbPromo;
    private TextBox txtKode;
    private Label lblKode;
    private NumericUpDown numPersentaseDiskon;
    private Label lblPersentaseDiskon;
    private Label lblRupiahPrefix;
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
    private DataGridView dgvPromo;
    private DataGridViewTextBoxColumn ID;
    private DataGridViewTextBoxColumn Kode;
    private DataGridViewTextBoxColumn PersentaseDiskon;
    private DataGridViewTextBoxColumn MaksimumDiskon;
    private DataGridViewTextBoxColumn BerlakuSampai;
    private DataGridViewTextBoxColumn StatusPromo;
    private DataGridViewTextBoxColumn Deskripsi;
}
