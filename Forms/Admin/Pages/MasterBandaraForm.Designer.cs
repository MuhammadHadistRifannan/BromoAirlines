namespace BromoAirlines.Forms;

partial class MasterBandaraForm
{
    private void InitializeComponent()
    {
        lblTitle = new Label();
        pictureBox1 = new PictureBox();
        gbBandara = new GroupBox();
        btnReset = new Button();
        btnHapus = new Button();
        btnEdit = new Button();
        btnTambah = new Button();
        txtAlamat = new TextBox();
        lblAlamat = new Label();
        numTerminal = new NumericUpDown();
        lblTerminal = new Label();
        cmbNegara = new ComboBox();
        lblNegara = new Label();
        txtKota = new TextBox();
        lblKota = new Label();
        txtKodeIATA = new TextBox();
        lblKodeIATA = new Label();
        txtNamaBandara = new TextBox();
        lblNamaBandara = new Label();
        lblDaftarBandara = new Label();
        txtCariBandara = new TextBox();
        dgvBandara = new DataGridView();
        ID = new DataGridViewTextBoxColumn();
        NamaBandara = new DataGridViewTextBoxColumn();
        KodeIATA = new DataGridViewTextBoxColumn();
        kota = new DataGridViewTextBoxColumn();
        Negara = new DataGridViewTextBoxColumn();
        JumlahTerminal = new DataGridViewTextBoxColumn();
        Alamat = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        gbBandara.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numTerminal).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvBandara).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitle.ForeColor = Color.Navy;
        lblTitle.Location = new Point(90, 20);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(498, 39);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "MASTER BANDARA - ADMIN";
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new Point(20, 15);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(60, 60);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // gbBandara
        // 
        gbBandara.Controls.Add(btnReset);
        gbBandara.Controls.Add(btnHapus);
        gbBandara.Controls.Add(btnEdit);
        gbBandara.Controls.Add(btnTambah);
        gbBandara.Controls.Add(txtAlamat);
        gbBandara.Controls.Add(lblAlamat);
        gbBandara.Controls.Add(numTerminal);
        gbBandara.Controls.Add(lblTerminal);
        gbBandara.Controls.Add(cmbNegara);
        gbBandara.Controls.Add(lblNegara);
        gbBandara.Controls.Add(txtKota);
        gbBandara.Controls.Add(lblKota);
        gbBandara.Controls.Add(txtKodeIATA);
        gbBandara.Controls.Add(lblKodeIATA);
        gbBandara.Controls.Add(txtNamaBandara);
        gbBandara.Controls.Add(lblNamaBandara);
        gbBandara.Location = new Point(20, 90);
        gbBandara.Name = "gbBandara";
        gbBandara.Size = new Size(1140, 298);
        gbBandara.TabIndex = 2;
        gbBandara.TabStop = false;
        gbBandara.Text = "Data Bandara";
        // 
        // btnReset
        // 
        btnReset.BackColor = Color.Azure;
        btnReset.Cursor = Cursors.Hand;
        btnReset.FlatStyle = FlatStyle.Flat;
        btnReset.ForeColor = Color.Gray;
        btnReset.Location = new Point(990, 220);
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
        btnHapus.Location = new Point(860, 220);
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
        btnEdit.Location = new Point(730, 220);
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
        btnTambah.Location = new Point(600, 220);
        btnTambah.Name = "btnTambah";
        btnTambah.Size = new Size(110, 40);
        btnTambah.TabIndex = 12;
        btnTambah.Text = "Tambah";
        btnTambah.UseVisualStyleBackColor = false;
        // 
        // txtAlamat
        // 
        txtAlamat.BorderStyle = BorderStyle.FixedSingle;
        txtAlamat.Location = new Point(709, 50);
        txtAlamat.Multiline = true;
        txtAlamat.Name = "txtAlamat";
        txtAlamat.Size = new Size(320, 100);
        txtAlamat.TabIndex = 11;
        // 
        // lblAlamat
        // 
        lblAlamat.AutoSize = true;
        lblAlamat.Location = new Point(630, 50);
        lblAlamat.Name = "lblAlamat";
        lblAlamat.Size = new Size(64, 20);
        lblAlamat.TabIndex = 10;
        lblAlamat.Text = "Alamat :";
        // 
        // numTerminal
        // 
        numTerminal.Location = new Point(221, 246);
        numTerminal.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
        numTerminal.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numTerminal.Name = "numTerminal";
        numTerminal.Size = new Size(120, 27);
        numTerminal.TabIndex = 9;
        numTerminal.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblTerminal
        // 
        lblTerminal.AutoSize = true;
        lblTerminal.Location = new Point(31, 243);
        lblTerminal.Name = "lblTerminal";
        lblTerminal.Size = new Size(123, 20);
        lblTerminal.TabIndex = 8;
        lblTerminal.Text = "Jumlah Terminal :";
        // 
        // cmbNegara
        // 
        cmbNegara.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbNegara.FormattingEnabled = true;
        cmbNegara.Location = new Point(220, 195);
        cmbNegara.Name = "cmbNegara";
        cmbNegara.Size = new Size(350, 28);
        cmbNegara.TabIndex = 7;
        // 
        // lblNegara
        // 
        lblNegara.AutoSize = true;
        lblNegara.Location = new Point(31, 191);
        lblNegara.Name = "lblNegara";
        lblNegara.Size = new Size(65, 20);
        lblNegara.TabIndex = 6;
        lblNegara.Text = "Negara :";
        // 
        // txtKota
        // 
        txtKota.BorderStyle = BorderStyle.FixedSingle;
        txtKota.Location = new Point(220, 145);
        txtKota.MaxLength = 200;
        txtKota.Name = "txtKota";
        txtKota.Size = new Size(350, 27);
        txtKota.TabIndex = 5;
        // 
        // lblKota
        // 
        lblKota.AutoSize = true;
        lblKota.Location = new Point(31, 143);
        lblKota.Name = "lblKota";
        lblKota.Size = new Size(51, 20);
        lblKota.TabIndex = 4;
        lblKota.Text = "Kota : ";
        // 
        // txtKodeIATA
        // 
        txtKodeIATA.BorderStyle = BorderStyle.FixedSingle;
        txtKodeIATA.Location = new Point(220, 95);
        txtKodeIATA.MaxLength = 3;
        txtKodeIATA.Name = "txtKodeIATA";
        txtKodeIATA.Size = new Size(100, 27);
        txtKodeIATA.TabIndex = 3;
        // 
        // lblKodeIATA
        // 
        lblKodeIATA.AutoSize = true;
        lblKodeIATA.Location = new Point(30, 95);
        lblKodeIATA.Name = "lblKodeIATA";
        lblKodeIATA.Size = new Size(85, 20);
        lblKodeIATA.TabIndex = 2;
        lblKodeIATA.Text = "Kode IATA :";
        // 
        // txtNamaBandara
        // 
        txtNamaBandara.BorderStyle = BorderStyle.FixedSingle;
        txtNamaBandara.Location = new Point(220, 45);
        txtNamaBandara.Name = "txtNamaBandara";
        txtNamaBandara.Size = new Size(350, 27);
        txtNamaBandara.TabIndex = 1;
        // 
        // lblNamaBandara
        // 
        lblNamaBandara.AutoSize = true;
        lblNamaBandara.Location = new Point(30, 50);
        lblNamaBandara.Name = "lblNamaBandara";
        lblNamaBandara.Size = new Size(115, 20);
        lblNamaBandara.TabIndex = 0;
        lblNamaBandara.Text = "Nama Bandara :";
        // 
        // lblDaftarBandara
        // 
        lblDaftarBandara.AutoSize = true;
        lblDaftarBandara.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblDaftarBandara.ForeColor = Color.Navy;
        lblDaftarBandara.Location = new Point(20, 390);
        lblDaftarBandara.Name = "lblDaftarBandara";
        lblDaftarBandara.Size = new Size(157, 25);
        lblDaftarBandara.TabIndex = 16;
        lblDaftarBandara.Text = "Daftar Bandara";
        // 
        // txtCariBandara
        // 
        txtCariBandara.BorderStyle = BorderStyle.FixedSingle;
        txtCariBandara.Location = new Point(910, 385);
        txtCariBandara.Name = "txtCariBandara";
        txtCariBandara.PlaceholderText = "Cari Bandara.....";
        txtCariBandara.Size = new Size(250, 27);
        txtCariBandara.TabIndex = 17;
        // 
        // dgvBandara
        // 
        dgvBandara.AccessibleRole = AccessibleRole.ButtonDropDownGrid;
        dgvBandara.AllowUserToAddRows = false;
        dgvBandara.AllowUserToDeleteRows = false;
        dgvBandara.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvBandara.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvBandara.Columns.AddRange(new DataGridViewColumn[] { ID, NamaBandara, KodeIATA, kota, Negara, JumlahTerminal, Alamat });
        dgvBandara.Location = new Point(20, 430);
        dgvBandara.Name = "dgvBandara";
        dgvBandara.ReadOnly = true;
        dgvBandara.RowHeadersVisible = false;
        dgvBandara.RowHeadersWidth = 51;
        dgvBandara.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvBandara.Size = new Size(1140, 250);
        dgvBandara.TabIndex = 18;
        // 
        // ID
        // 
        ID.HeaderText = "ID";
        ID.MinimumWidth = 6;
        ID.Name = "ID";
        ID.ReadOnly = true;
        // 
        // NamaBandara
        // 
        NamaBandara.HeaderText = "Nama Bandara";
        NamaBandara.MinimumWidth = 6;
        NamaBandara.Name = "NamaBandara";
        NamaBandara.ReadOnly = true;
        // 
        // KodeIATA
        // 
        KodeIATA.HeaderText = "Kode IATA";
        KodeIATA.MinimumWidth = 6;
        KodeIATA.Name = "KodeIATA";
        KodeIATA.ReadOnly = true;
        // 
        // kota
        // 
        kota.HeaderText = "Kota";
        kota.MinimumWidth = 6;
        kota.Name = "kota";
        kota.ReadOnly = true;
        // 
        // Negara
        // 
        Negara.HeaderText = "Negara";
        Negara.MinimumWidth = 6;
        Negara.Name = "Negara";
        Negara.ReadOnly = true;
        // 
        // JumlahTerminal
        // 
        JumlahTerminal.HeaderText = "Jumlah Terminal";
        JumlahTerminal.MinimumWidth = 6;
        JumlahTerminal.Name = "JumlahTerminal";
        JumlahTerminal.ReadOnly = true;
        // 
        // Alamat
        // 
        Alamat.HeaderText = "Alamat";
        Alamat.MinimumWidth = 6;
        Alamat.Name = "Alamat";
        Alamat.ReadOnly = true;
        // 
        // MasterBandaraForm
        // 
        AutoScaleMode = AutoScaleMode.Inherit;
        AutoScroll = true;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(1182, 715);
        Controls.Add(dgvBandara);
        Controls.Add(txtCariBandara);
        Controls.Add(lblDaftarBandara);
        Controls.Add(gbBandara);
        Controls.Add(pictureBox1);
        Controls.Add(lblTitle);
        FormBorderStyle = FormBorderStyle.None;
        Name = "MasterBandaraForm";
        StartPosition = FormStartPosition.CenterScreen;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        gbBandara.ResumeLayout(false);
        gbBandara.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numTerminal).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvBandara).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitle;
    private PictureBox pictureBox1;
    private GroupBox gbBandara;
    private Label lblKodeIATA;
    private TextBox txtNamaBandara;
    private Label lblNamaBandara;
    private Label lblNegara;
    private TextBox txtKota;
    private Label lblKota;
    private TextBox txtKodeIATA;
    private Label lblAlamat;
    private NumericUpDown numTerminal;
    private Label lblTerminal;
    private ComboBox cmbNegara;
    private TextBox txtAlamat;
    private Button btnEdit;
    private Button btnTambah;
    private Button btnReset;
    private Button btnHapus;
    private Label lblDaftarBandara;
    private TextBox txtCariBandara;
    private DataGridView dgvBandara;
    private DataGridViewTextBoxColumn ID;
    private DataGridViewTextBoxColumn NamaBandara;
    private DataGridViewTextBoxColumn KodeIATA;
    private DataGridViewTextBoxColumn kota;
    private DataGridViewTextBoxColumn Negara;
    private DataGridViewTextBoxColumn JumlahTerminal;
    private DataGridViewTextBoxColumn Alamat;
}
