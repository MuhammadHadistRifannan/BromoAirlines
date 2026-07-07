namespace BromoAirlines.Forms.Users.Pages;

partial class BookingForm
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
        panelBooking = new Panel();
        lblPromoHint = new Label();
        cmbPromo = new ComboBox();
        lblPromo = new Label();
        numJumlahPenumpang = new NumericUpDown();
        lblJumlahPenumpang = new Label();
        txtJadwal = new TextBox();
        lblJadwal = new Label();
        btnLanjut = new Button();
        panelSummary = new Panel();
        lblSummaryDescription = new Label();
        lblSummaryTitle = new Label();
        panelBooking.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numJumlahPenumpang).BeginInit();
        panelSummary.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        lblTitle.ForeColor = Color.Navy;
        lblTitle.Location = new Point(48, 42);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(169, 54);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Booking";
        // 
        // panelBooking
        // 
        panelBooking.BackColor = Color.White;
        panelBooking.Controls.Add(lblPromoHint);
        panelBooking.Controls.Add(cmbPromo);
        panelBooking.Controls.Add(lblPromo);
        panelBooking.Controls.Add(numJumlahPenumpang);
        panelBooking.Controls.Add(lblJumlahPenumpang);
        panelBooking.Controls.Add(txtJadwal);
        panelBooking.Controls.Add(lblJadwal);
        panelBooking.Location = new Point(48, 318);
        panelBooking.Name = "panelBooking";
        panelBooking.Padding = new Padding(32);
        panelBooking.Size = new Size(1220, 340);
        panelBooking.TabIndex = 2;
        // 
        // lblPromoHint
        // 
        lblPromoHint.Font = new Font("Segoe UI", 10F);
        lblPromoHint.ForeColor = Color.DimGray;
        lblPromoHint.Location = new Point(326, 249);
        lblPromoHint.Name = "lblPromoHint";
        lblPromoHint.Size = new Size(650, 34);
        lblPromoHint.TabIndex = 6;
        lblPromoHint.Text = "Promo bersifat opsional dan akan dihitung pada tahap pembayaran.";
        // 
        // cmbPromo
        // 
        cmbPromo.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbPromo.FormattingEnabled = true;
        cmbPromo.Location = new Point(326, 210);
        cmbPromo.Name = "cmbPromo";
        cmbPromo.Size = new Size(520, 28);
        cmbPromo.TabIndex = 5;
        // 
        // lblPromo
        // 
        lblPromo.AutoSize = true;
        lblPromo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblPromo.ForeColor = Color.Navy;
        lblPromo.Location = new Point(32, 207);
        lblPromo.Name = "lblPromo";
        lblPromo.Size = new Size(75, 28);
        lblPromo.TabIndex = 4;
        lblPromo.Text = "Promo";
        // 
        // numJumlahPenumpang
        // 
        numJumlahPenumpang.Location = new Point(326, 136);
        numJumlahPenumpang.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
        numJumlahPenumpang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numJumlahPenumpang.Name = "numJumlahPenumpang";
        numJumlahPenumpang.Size = new Size(150, 27);
        numJumlahPenumpang.TabIndex = 3;
        numJumlahPenumpang.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblJumlahPenumpang
        // 
        lblJumlahPenumpang.AutoSize = true;
        lblJumlahPenumpang.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblJumlahPenumpang.ForeColor = Color.Navy;
        lblJumlahPenumpang.Location = new Point(32, 132);
        lblJumlahPenumpang.Name = "lblJumlahPenumpang";
        lblJumlahPenumpang.Size = new Size(195, 28);
        lblJumlahPenumpang.TabIndex = 2;
        lblJumlahPenumpang.Text = "Jumlah Penumpang";
        // 
        // txtJadwal
        // 
        txtJadwal.Location = new Point(326, 62);
        txtJadwal.Name = "txtJadwal";
        txtJadwal.ReadOnly = true;
        txtJadwal.Size = new Size(720, 27);
        txtJadwal.TabIndex = 1;
        txtJadwal.Text = "Jadwal dipilih dari halaman Detail Penerbangan";
        // 
        // lblJadwal
        // 
        lblJadwal.AutoSize = true;
        lblJadwal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblJadwal.ForeColor = Color.Navy;
        lblJadwal.Location = new Point(32, 58);
        lblJadwal.Name = "lblJadwal";
        lblJadwal.Size = new Size(76, 28);
        lblJadwal.TabIndex = 0;
        lblJadwal.Text = "Jadwal";
        // 
        // btnLanjut
        // 
        btnLanjut.BackColor = Color.RoyalBlue;
        btnLanjut.Cursor = Cursors.Hand;
        btnLanjut.FlatAppearance.BorderSize = 0;
        btnLanjut.FlatStyle = FlatStyle.Flat;
        btnLanjut.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnLanjut.ForeColor = Color.White;
        btnLanjut.Location = new Point(1048, 694);
        btnLanjut.Name = "btnLanjut";
        btnLanjut.Size = new Size(220, 58);
        btnLanjut.TabIndex = 3;
        btnLanjut.Text = "Lanjut";
        btnLanjut.UseVisualStyleBackColor = false;
        btnLanjut.Click += BtnLanjutClick;
        // 
        // panelSummary
        // 
        panelSummary.BackColor = Color.RoyalBlue;
        panelSummary.Controls.Add(lblSummaryDescription);
        panelSummary.Controls.Add(lblSummaryTitle);
        panelSummary.Location = new Point(48, 124);
        panelSummary.Name = "panelSummary";
        panelSummary.Padding = new Padding(32);
        panelSummary.Size = new Size(1220, 150);
        panelSummary.TabIndex = 1;
        // 
        // lblSummaryDescription
        // 
        lblSummaryDescription.Font = new Font("Segoe UI", 14F);
        lblSummaryDescription.ForeColor = Color.White;
        lblSummaryDescription.Location = new Point(32, 82);
        lblSummaryDescription.Name = "lblSummaryDescription";
        lblSummaryDescription.Size = new Size(850, 38);
        lblSummaryDescription.TabIndex = 1;
        lblSummaryDescription.Text = "Konfirmasi jadwal, jumlah penumpang, dan promo sebelum lanjut ke data penumpang.";
        // 
        // lblSummaryTitle
        // 
        lblSummaryTitle.AutoSize = true;
        lblSummaryTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblSummaryTitle.ForeColor = Color.White;
        lblSummaryTitle.Location = new Point(32, 24);
        lblSummaryTitle.Name = "lblSummaryTitle";
        lblSummaryTitle.Size = new Size(352, 50);
        lblSummaryTitle.TabIndex = 0;
        lblSummaryTitle.Text = "Ringkasan Booking";
        // 
        // BookingForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1375, 1050);
        Controls.Add(btnLanjut);
        Controls.Add(panelBooking);
        Controls.Add(panelSummary);
        Controls.Add(lblTitle);
        FormBorderStyle = FormBorderStyle.None;
        Name = "BookingForm";
        Text = "Booking";
        panelBooking.ResumeLayout(false);
        panelBooking.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numJumlahPenumpang).EndInit();
        panelSummary.ResumeLayout(false);
        panelSummary.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitle;
    private Panel panelBooking;
    private Label lblJadwal;
    private TextBox txtJadwal;
    private Label lblJumlahPenumpang;
    private NumericUpDown numJumlahPenumpang;
    private Label lblPromo;
    private ComboBox cmbPromo;
    private Label lblPromoHint;
    private Button btnLanjut;
    private Panel panelSummary;
    private Label lblSummaryTitle;
    private Label lblSummaryDescription;
}
