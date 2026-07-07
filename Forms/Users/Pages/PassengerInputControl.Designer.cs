namespace BromoAirlines.Forms.Users.Pages;

partial class PassengerInputControl
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
        lblPassengerTitle = new Label();
        lblNamaLengkap = new Label();
        txtNamaLengkap = new TextBox();
        lblNomorIdentitas = new Label();
        txtNomorIdentitas = new TextBox();
        lblJenisKelamin = new Label();
        cmbJenisKelamin = new ComboBox();
        lblTanggalLahir = new Label();
        dtpTanggalLahir = new DateTimePicker();
        lblKewarganegaraan = new Label();
        txtKewarganegaraan = new TextBox();
        SuspendLayout();
        // 
        // lblPassengerTitle
        // 
        lblPassengerTitle.AutoSize = true;
        lblPassengerTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblPassengerTitle.ForeColor = Color.Navy;
        lblPassengerTitle.Location = new Point(24, 20);
        lblPassengerTitle.Name = "lblPassengerTitle";
        lblPassengerTitle.Size = new Size(172, 32);
        lblPassengerTitle.TabIndex = 0;
        lblPassengerTitle.Text = "Penumpang 1";
        // 
        // lblNamaLengkap
        // 
        lblNamaLengkap.AutoSize = true;
        lblNamaLengkap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblNamaLengkap.ForeColor = Color.Navy;
        lblNamaLengkap.Location = new Point(24, 78);
        lblNamaLengkap.Name = "lblNamaLengkap";
        lblNamaLengkap.Size = new Size(131, 23);
        lblNamaLengkap.TabIndex = 1;
        lblNamaLengkap.Text = "Nama Lengkap";
        // 
        // txtNamaLengkap
        // 
        txtNamaLengkap.Location = new Point(24, 108);
        txtNamaLengkap.Name = "txtNamaLengkap";
        txtNamaLengkap.Size = new Size(500, 27);
        txtNamaLengkap.TabIndex = 2;
        // 
        // lblNomorIdentitas
        // 
        lblNomorIdentitas.AutoSize = true;
        lblNomorIdentitas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblNomorIdentitas.ForeColor = Color.Navy;
        lblNomorIdentitas.Location = new Point(584, 78);
        lblNomorIdentitas.Name = "lblNomorIdentitas";
        lblNomorIdentitas.Size = new Size(141, 23);
        lblNomorIdentitas.TabIndex = 3;
        lblNomorIdentitas.Text = "Nomor Identitas";
        // 
        // txtNomorIdentitas
        // 
        txtNomorIdentitas.Location = new Point(584, 108);
        txtNomorIdentitas.Name = "txtNomorIdentitas";
        txtNomorIdentitas.Size = new Size(500, 27);
        txtNomorIdentitas.TabIndex = 4;
        // 
        // lblJenisKelamin
        // 
        lblJenisKelamin.AutoSize = true;
        lblJenisKelamin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblJenisKelamin.ForeColor = Color.Navy;
        lblJenisKelamin.Location = new Point(24, 166);
        lblJenisKelamin.Name = "lblJenisKelamin";
        lblJenisKelamin.Size = new Size(119, 23);
        lblJenisKelamin.TabIndex = 5;
        lblJenisKelamin.Text = "Jenis Kelamin";
        // 
        // cmbJenisKelamin
        // 
        cmbJenisKelamin.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbJenisKelamin.FormattingEnabled = true;
        cmbJenisKelamin.Items.AddRange(new object[] { "Laki-laki", "Perempuan" });
        cmbJenisKelamin.Location = new Point(24, 196);
        cmbJenisKelamin.Name = "cmbJenisKelamin";
        cmbJenisKelamin.Size = new Size(280, 28);
        cmbJenisKelamin.TabIndex = 6;
        // 
        // lblTanggalLahir
        // 
        lblTanggalLahir.AutoSize = true;
        lblTanggalLahir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblTanggalLahir.ForeColor = Color.Navy;
        lblTanggalLahir.Location = new Point(364, 166);
        lblTanggalLahir.Name = "lblTanggalLahir";
        lblTanggalLahir.Size = new Size(119, 23);
        lblTanggalLahir.TabIndex = 7;
        lblTanggalLahir.Text = "Tanggal Lahir";
        // 
        // dtpTanggalLahir
        // 
        dtpTanggalLahir.Format = DateTimePickerFormat.Short;
        dtpTanggalLahir.Location = new Point(364, 196);
        dtpTanggalLahir.Name = "dtpTanggalLahir";
        dtpTanggalLahir.Size = new Size(260, 27);
        dtpTanggalLahir.TabIndex = 8;
        // 
        // lblKewarganegaraan
        // 
        lblKewarganegaraan.AutoSize = true;
        lblKewarganegaraan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblKewarganegaraan.ForeColor = Color.Navy;
        lblKewarganegaraan.Location = new Point(684, 166);
        lblKewarganegaraan.Name = "lblKewarganegaraan";
        lblKewarganegaraan.Size = new Size(154, 23);
        lblKewarganegaraan.TabIndex = 9;
        lblKewarganegaraan.Text = "Kewarganegaraan";
        // 
        // txtKewarganegaraan
        // 
        txtKewarganegaraan.Location = new Point(684, 196);
        txtKewarganegaraan.Name = "txtKewarganegaraan";
        txtKewarganegaraan.Size = new Size(400, 27);
        txtKewarganegaraan.TabIndex = 10;
        // 
        // PassengerInputControl
        // 
        BackColor = Color.White;
        Controls.Add(txtKewarganegaraan);
        Controls.Add(lblKewarganegaraan);
        Controls.Add(dtpTanggalLahir);
        Controls.Add(lblTanggalLahir);
        Controls.Add(cmbJenisKelamin);
        Controls.Add(lblJenisKelamin);
        Controls.Add(txtNomorIdentitas);
        Controls.Add(lblNomorIdentitas);
        Controls.Add(txtNamaLengkap);
        Controls.Add(lblNamaLengkap);
        Controls.Add(lblPassengerTitle);
        Name = "PassengerInputControl";
        Size = new Size(1140, 260);
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblPassengerTitle;
    private Label lblNamaLengkap;
    private TextBox txtNamaLengkap;
    private Label lblNomorIdentitas;
    private TextBox txtNomorIdentitas;
    private Label lblJenisKelamin;
    private ComboBox cmbJenisKelamin;
    private Label lblTanggalLahir;
    private DateTimePicker dtpTanggalLahir;
    private Label lblKewarganegaraan;
    private TextBox txtKewarganegaraan;
}
