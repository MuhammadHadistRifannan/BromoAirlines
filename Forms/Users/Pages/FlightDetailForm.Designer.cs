namespace BromoAirlines.Forms.Users.Pages;

partial class FlightDetailForm
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
        panelDetail = new Panel();
        lblKursiTersediaValue = new Label();
        lblKursiTersedia = new Label();
        lblHargaValue = new Label();
        lblHarga = new Label();
        lblJadwalValue = new Label();
        lblJadwal = new Label();
        lblBandaraValue = new Label();
        lblBandara = new Label();
        lblMaskapaiValue = new Label();
        lblMaskapai = new Label();
        btnBooking = new Button();
        panelSummary = new Panel();
        lblSummaryRoute = new Label();
        lblSummaryTitle = new Label();
        panelDetail.SuspendLayout();
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
        lblTitle.Size = new Size(348, 54);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Detail Penerbangan";
        // 
        // panelDetail
        // 
        panelDetail.BackColor = Color.White;
        panelDetail.Controls.Add(lblKursiTersediaValue);
        panelDetail.Controls.Add(lblKursiTersedia);
        panelDetail.Controls.Add(lblHargaValue);
        panelDetail.Controls.Add(lblHarga);
        panelDetail.Controls.Add(lblJadwalValue);
        panelDetail.Controls.Add(lblJadwal);
        panelDetail.Controls.Add(lblBandaraValue);
        panelDetail.Controls.Add(lblBandara);
        panelDetail.Controls.Add(lblMaskapaiValue);
        panelDetail.Controls.Add(lblMaskapai);
        panelDetail.Location = new Point(48, 318);
        panelDetail.Name = "panelDetail";
        panelDetail.Padding = new Padding(32);
        panelDetail.Size = new Size(1220, 380);
        panelDetail.TabIndex = 2;
        // 
        // lblKursiTersediaValue
        // 
        lblKursiTersediaValue.Font = new Font("Segoe UI", 12F);
        lblKursiTersediaValue.ForeColor = Color.Black;
        lblKursiTersediaValue.Location = new Point(326, 285);
        lblKursiTersediaValue.Name = "lblKursiTersediaValue";
        lblKursiTersediaValue.Size = new Size(820, 34);
        lblKursiTersediaValue.TabIndex = 9;
        lblKursiTersediaValue.Text = "-";
        // 
        // lblKursiTersedia
        // 
        lblKursiTersedia.AutoSize = true;
        lblKursiTersedia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblKursiTersedia.ForeColor = Color.Navy;
        lblKursiTersedia.Location = new Point(32, 285);
        lblKursiTersedia.Name = "lblKursiTersedia";
        lblKursiTersedia.Size = new Size(154, 28);
        lblKursiTersedia.TabIndex = 8;
        lblKursiTersedia.Text = "Kursi Tersedia";
        // 
        // lblHargaValue
        // 
        lblHargaValue.Font = new Font("Segoe UI", 12F);
        lblHargaValue.ForeColor = Color.Black;
        lblHargaValue.Location = new Point(326, 222);
        lblHargaValue.Name = "lblHargaValue";
        lblHargaValue.Size = new Size(820, 34);
        lblHargaValue.TabIndex = 7;
        lblHargaValue.Text = "-";
        // 
        // lblHarga
        // 
        lblHarga.AutoSize = true;
        lblHarga.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblHarga.ForeColor = Color.Navy;
        lblHarga.Location = new Point(32, 222);
        lblHarga.Name = "lblHarga";
        lblHarga.Size = new Size(70, 28);
        lblHarga.TabIndex = 6;
        lblHarga.Text = "Harga";
        // 
        // lblJadwalValue
        // 
        lblJadwalValue.Font = new Font("Segoe UI", 12F);
        lblJadwalValue.ForeColor = Color.Black;
        lblJadwalValue.Location = new Point(326, 159);
        lblJadwalValue.Name = "lblJadwalValue";
        lblJadwalValue.Size = new Size(820, 34);
        lblJadwalValue.TabIndex = 5;
        lblJadwalValue.Text = "-";
        // 
        // lblJadwal
        // 
        lblJadwal.AutoSize = true;
        lblJadwal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblJadwal.ForeColor = Color.Navy;
        lblJadwal.Location = new Point(32, 159);
        lblJadwal.Name = "lblJadwal";
        lblJadwal.Size = new Size(76, 28);
        lblJadwal.TabIndex = 4;
        lblJadwal.Text = "Jadwal";
        // 
        // lblBandaraValue
        // 
        lblBandaraValue.Font = new Font("Segoe UI", 12F);
        lblBandaraValue.ForeColor = Color.Black;
        lblBandaraValue.Location = new Point(326, 96);
        lblBandaraValue.Name = "lblBandaraValue";
        lblBandaraValue.Size = new Size(820, 34);
        lblBandaraValue.TabIndex = 3;
        lblBandaraValue.Text = "-";
        // 
        // lblBandara
        // 
        lblBandara.AutoSize = true;
        lblBandara.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblBandara.ForeColor = Color.Navy;
        lblBandara.Location = new Point(32, 96);
        lblBandara.Name = "lblBandara";
        lblBandara.Size = new Size(91, 28);
        lblBandara.TabIndex = 2;
        lblBandara.Text = "Bandara";
        // 
        // lblMaskapaiValue
        // 
        lblMaskapaiValue.Font = new Font("Segoe UI", 12F);
        lblMaskapaiValue.ForeColor = Color.Black;
        lblMaskapaiValue.Location = new Point(326, 33);
        lblMaskapaiValue.Name = "lblMaskapaiValue";
        lblMaskapaiValue.Size = new Size(820, 34);
        lblMaskapaiValue.TabIndex = 1;
        lblMaskapaiValue.Text = "-";
        // 
        // lblMaskapai
        // 
        lblMaskapai.AutoSize = true;
        lblMaskapai.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblMaskapai.ForeColor = Color.Navy;
        lblMaskapai.Location = new Point(32, 33);
        lblMaskapai.Name = "lblMaskapai";
        lblMaskapai.Size = new Size(101, 28);
        lblMaskapai.TabIndex = 0;
        lblMaskapai.Text = "Maskapai";
        // 
        // btnBooking
        // 
        btnBooking.BackColor = Color.RoyalBlue;
        btnBooking.Cursor = Cursors.Hand;
        btnBooking.FlatAppearance.BorderSize = 0;
        btnBooking.FlatStyle = FlatStyle.Flat;
        btnBooking.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnBooking.ForeColor = Color.White;
        btnBooking.Location = new Point(1048, 730);
        btnBooking.Name = "btnBooking";
        btnBooking.Size = new Size(220, 58);
        btnBooking.TabIndex = 3;
        btnBooking.Text = "Booking";
        btnBooking.UseVisualStyleBackColor = false;
        btnBooking.Click += BtnBookingClick;
        // 
        // panelSummary
        // 
        panelSummary.BackColor = Color.RoyalBlue;
        panelSummary.Controls.Add(lblSummaryRoute);
        panelSummary.Controls.Add(lblSummaryTitle);
        panelSummary.Location = new Point(48, 124);
        panelSummary.Name = "panelSummary";
        panelSummary.Padding = new Padding(32);
        panelSummary.Size = new Size(1220, 150);
        panelSummary.TabIndex = 1;
        // 
        // lblSummaryRoute
        // 
        lblSummaryRoute.Font = new Font("Segoe UI", 14F);
        lblSummaryRoute.ForeColor = Color.White;
        lblSummaryRoute.Location = new Point(32, 82);
        lblSummaryRoute.Name = "lblSummaryRoute";
        lblSummaryRoute.Size = new Size(900, 38);
        lblSummaryRoute.TabIndex = 1;
        lblSummaryRoute.Text = "Pilih jadwal dari halaman Cari Penerbangan untuk melihat detail lengkap.";
        // 
        // lblSummaryTitle
        // 
        lblSummaryTitle.AutoSize = true;
        lblSummaryTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblSummaryTitle.ForeColor = Color.White;
        lblSummaryTitle.Location = new Point(32, 24);
        lblSummaryTitle.Name = "lblSummaryTitle";
        lblSummaryTitle.Size = new Size(273, 50);
        lblSummaryTitle.TabIndex = 0;
        lblSummaryTitle.Text = "Informasi Tiket";
        // 
        // FlightDetailForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1375, 1050);
        Controls.Add(btnBooking);
        Controls.Add(panelDetail);
        Controls.Add(panelSummary);
        Controls.Add(lblTitle);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FlightDetailForm";
        Text = "Detail Penerbangan";
        panelDetail.ResumeLayout(false);
        panelDetail.PerformLayout();
        panelSummary.ResumeLayout(false);
        panelSummary.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitle;
    private Panel panelDetail;
    private Label lblMaskapai;
    private Label lblMaskapaiValue;
    private Label lblBandaraValue;
    private Label lblBandara;
    private Label lblJadwalValue;
    private Label lblJadwal;
    private Label lblHargaValue;
    private Label lblHarga;
    private Label lblKursiTersediaValue;
    private Label lblKursiTersedia;
    private Button btnBooking;
    private Panel panelSummary;
    private Label lblSummaryTitle;
    private Label lblSummaryRoute;
}
