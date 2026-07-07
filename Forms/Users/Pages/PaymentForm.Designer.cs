namespace BromoAirlines.Forms.Users.Pages;

partial class PaymentForm
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
        panelSummary = new Panel();
        lblSummaryDescription = new Label();
        lblSummaryTitle = new Label();
        panelContent = new Panel();
        panelPayment = new Panel();
        lblTotalBayarValue = new Label();
        lblTotalBayar = new Label();
        lblPromoValue = new Label();
        lblPromo = new Label();
        lblPajakValue = new Label();
        lblPajak = new Label();
        lblHargaValue = new Label();
        lblHarga = new Label();
        panelMethod = new Panel();
        cmbMetodePembayaran = new ComboBox();
        lblMetodePembayaran = new Label();
        panelAction = new Panel();
        lblStatusPembayaran = new Label();
        btnBayar = new Button();
        btnLihatTiket = new Button();
        panelSummary.SuspendLayout();
        panelPayment.SuspendLayout();
        panelMethod.SuspendLayout();
        panelAction.SuspendLayout();
        panelContent.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        lblTitle.ForeColor = Color.Navy;
        lblTitle.Location = new Point(48, 42);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(237, 54);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Pembayaran";
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
        lblSummaryDescription.Size = new Size(900, 38);
        lblSummaryDescription.TabIndex = 1;
        lblSummaryDescription.Text = "Periksa total pembayaran dan lakukan simulasi pembayaran tiket.";
        // 
        // lblSummaryTitle
        // 
        lblSummaryTitle.AutoSize = true;
        lblSummaryTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblSummaryTitle.ForeColor = Color.White;
        lblSummaryTitle.Location = new Point(32, 24);
        lblSummaryTitle.Name = "lblSummaryTitle";
        lblSummaryTitle.Size = new Size(359, 50);
        lblSummaryTitle.TabIndex = 0;
        lblSummaryTitle.Text = "Ringkasan Pembayaran";
        // 
        // panelPayment
        // 
        panelPayment.BackColor = Color.White;
        panelPayment.Controls.Add(lblTotalBayarValue);
        panelPayment.Controls.Add(lblTotalBayar);
        panelPayment.Controls.Add(lblPromoValue);
        panelPayment.Controls.Add(lblPromo);
        panelPayment.Controls.Add(lblPajakValue);
        panelPayment.Controls.Add(lblPajak);
        panelPayment.Controls.Add(lblHargaValue);
        panelPayment.Controls.Add(lblHarga);
        panelPayment.Location = new Point(48, 318);
        panelPayment.Name = "panelPayment";
        panelPayment.Padding = new Padding(32);
        panelPayment.Size = new Size(1220, 310);
        panelPayment.TabIndex = 2;
        // 
        // lblTotalBayarValue
        // 
        lblTotalBayarValue.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTotalBayarValue.ForeColor = Color.Navy;
        lblTotalBayarValue.Location = new Point(326, 235);
        lblTotalBayarValue.Name = "lblTotalBayarValue";
        lblTotalBayarValue.Size = new Size(650, 42);
        lblTotalBayarValue.TabIndex = 7;
        lblTotalBayarValue.Text = "Rp 0";
        // 
        // lblTotalBayar
        // 
        lblTotalBayar.AutoSize = true;
        lblTotalBayar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTotalBayar.ForeColor = Color.Navy;
        lblTotalBayar.Location = new Point(32, 235);
        lblTotalBayar.Name = "lblTotalBayar";
        lblTotalBayar.Size = new Size(164, 37);
        lblTotalBayar.TabIndex = 6;
        lblTotalBayar.Text = "Total Bayar";
        // 
        // lblPromoValue
        // 
        lblPromoValue.Font = new Font("Segoe UI", 12F);
        lblPromoValue.ForeColor = Color.Black;
        lblPromoValue.Location = new Point(326, 159);
        lblPromoValue.Name = "lblPromoValue";
        lblPromoValue.Size = new Size(650, 34);
        lblPromoValue.TabIndex = 5;
        lblPromoValue.Text = "Rp 0";
        // 
        // lblPromo
        // 
        lblPromo.AutoSize = true;
        lblPromo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblPromo.ForeColor = Color.Navy;
        lblPromo.Location = new Point(32, 159);
        lblPromo.Name = "lblPromo";
        lblPromo.Size = new Size(75, 28);
        lblPromo.TabIndex = 4;
        lblPromo.Text = "Promo";
        // 
        // lblPajakValue
        // 
        lblPajakValue.Font = new Font("Segoe UI", 12F);
        lblPajakValue.ForeColor = Color.Black;
        lblPajakValue.Location = new Point(326, 96);
        lblPajakValue.Name = "lblPajakValue";
        lblPajakValue.Size = new Size(650, 34);
        lblPajakValue.TabIndex = 3;
        lblPajakValue.Text = "Rp 0";
        // 
        // lblPajak
        // 
        lblPajak.AutoSize = true;
        lblPajak.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblPajak.ForeColor = Color.Navy;
        lblPajak.Location = new Point(32, 96);
        lblPajak.Name = "lblPajak";
        lblPajak.Size = new Size(62, 28);
        lblPajak.TabIndex = 2;
        lblPajak.Text = "Pajak";
        // 
        // lblHargaValue
        // 
        lblHargaValue.Font = new Font("Segoe UI", 12F);
        lblHargaValue.ForeColor = Color.Black;
        lblHargaValue.Location = new Point(326, 33);
        lblHargaValue.Name = "lblHargaValue";
        lblHargaValue.Size = new Size(650, 34);
        lblHargaValue.TabIndex = 1;
        lblHargaValue.Text = "Rp 0";
        // 
        // lblHarga
        // 
        lblHarga.AutoSize = true;
        lblHarga.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblHarga.ForeColor = Color.Navy;
        lblHarga.Location = new Point(32, 33);
        lblHarga.Name = "lblHarga";
        lblHarga.Size = new Size(70, 28);
        lblHarga.TabIndex = 0;
        lblHarga.Text = "Harga";
        // 
        // panelMethod
        // 
        panelMethod.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        panelMethod.BackColor = Color.White;
        panelMethod.Controls.Add(cmbMetodePembayaran);
        panelMethod.Controls.Add(lblMetodePembayaran);
        panelMethod.Location = new Point(48, 666);
        panelMethod.Name = "panelMethod";
        panelMethod.Padding = new Padding(32);
        panelMethod.Size = new Size(1220, 120);
        panelMethod.TabIndex = 3;
        // 
        // panelAction
        // 
        panelAction.BackColor = SystemColors.Control;
        panelAction.Controls.Add(btnLihatTiket);
        panelAction.Controls.Add(btnBayar);
        panelAction.Controls.Add(lblStatusPembayaran);
        panelAction.Dock = DockStyle.Bottom;
        panelAction.Location = new Point(0, 950);
        panelAction.Name = "panelAction";
        panelAction.Padding = new Padding(48, 14, 48, 18);
        panelAction.Size = new Size(1375, 100);
        panelAction.TabIndex = 4;
        // 
        // cmbMetodePembayaran
        // 
        cmbMetodePembayaran.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbMetodePembayaran.FormattingEnabled = true;
        cmbMetodePembayaran.Items.AddRange(new object[] { "Transfer Bank", "Kartu Kredit", "E-Wallet" });
        cmbMetodePembayaran.Location = new Point(326, 46);
        cmbMetodePembayaran.Name = "cmbMetodePembayaran";
        cmbMetodePembayaran.Size = new Size(360, 28);
        cmbMetodePembayaran.TabIndex = 1;
        // 
        // lblMetodePembayaran
        // 
        lblMetodePembayaran.AutoSize = true;
        lblMetodePembayaran.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblMetodePembayaran.ForeColor = Color.Navy;
        lblMetodePembayaran.Location = new Point(32, 42);
        lblMetodePembayaran.Name = "lblMetodePembayaran";
        lblMetodePembayaran.Size = new Size(215, 28);
        lblMetodePembayaran.TabIndex = 0;
        lblMetodePembayaran.Text = "Metode Pembayaran";
        // 
        // lblStatusPembayaran
        // 
        lblStatusPembayaran.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblStatusPembayaran.ForeColor = Color.DimGray;
        lblStatusPembayaran.Location = new Point(0, 23);
        lblStatusPembayaran.Name = "lblStatusPembayaran";
        lblStatusPembayaran.Size = new Size(700, 42);
        lblStatusPembayaran.TabIndex = 4;
        lblStatusPembayaran.Text = "Pembayaran belum dilakukan.";
        lblStatusPembayaran.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // btnBayar
        // 
        btnBayar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnBayar.BackColor = Color.RoyalBlue;
        btnBayar.Cursor = Cursors.Hand;
        btnBayar.FlatAppearance.BorderSize = 0;
        btnBayar.FlatStyle = FlatStyle.Flat;
        btnBayar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnBayar.ForeColor = Color.White;
        btnBayar.Location = new Point(1107, 18);
        btnBayar.Name = "btnBayar";
        btnBayar.Size = new Size(220, 58);
        btnBayar.TabIndex = 5;
        btnBayar.Text = "Bayar";
        btnBayar.UseVisualStyleBackColor = false;
        btnBayar.Click += BtnBayarClick;
        // 
        // btnLihatTiket
        // 
        btnLihatTiket.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLihatTiket.BackColor = Color.White;
        btnLihatTiket.Cursor = Cursors.Hand;
        btnLihatTiket.FlatAppearance.BorderColor = Color.RoyalBlue;
        btnLihatTiket.FlatStyle = FlatStyle.Flat;
        btnLihatTiket.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnLihatTiket.ForeColor = Color.RoyalBlue;
        btnLihatTiket.Location = new Point(863, 18);
        btnLihatTiket.Name = "btnLihatTiket";
        btnLihatTiket.Size = new Size(220, 58);
        btnLihatTiket.TabIndex = 6;
        btnLihatTiket.Text = "Lihat Tiket";
        btnLihatTiket.UseVisualStyleBackColor = false;
        btnLihatTiket.Visible = false;
        btnLihatTiket.Click += BtnLihatTiketClick;
        // 
        // 
        // panelContent
        // 
        panelContent.AutoScroll = true;
        panelContent.Controls.Add(panelMethod);
        panelContent.Controls.Add(panelPayment);
        panelContent.Controls.Add(panelSummary);
        panelContent.Controls.Add(lblTitle);
        panelContent.Dock = DockStyle.Fill;
        panelContent.Location = new Point(0, 0);
        panelContent.Name = "panelContent";
        panelContent.Size = new Size(1375, 950);
        panelContent.TabIndex = 5;
        // 
        // PaymentForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1375, 1050);
        Controls.Add(panelContent);
        Controls.Add(panelAction);
        FormBorderStyle = FormBorderStyle.None;
        Name = "PaymentForm";
        Text = "Pembayaran";
        panelSummary.ResumeLayout(false);
        panelSummary.PerformLayout();
        panelPayment.ResumeLayout(false);
        panelPayment.PerformLayout();
        panelMethod.ResumeLayout(false);
        panelMethod.PerformLayout();
        panelAction.ResumeLayout(false);
        panelContent.ResumeLayout(false);
        panelContent.PerformLayout();
        ResumeLayout(false);
    }

    private Label lblTitle;
    private Panel panelSummary;
    private Label lblSummaryTitle;
    private Label lblSummaryDescription;
    private Panel panelContent;
    private Panel panelPayment;
    private Label lblHarga;
    private Label lblHargaValue;
    private Label lblPajakValue;
    private Label lblPajak;
    private Label lblPromoValue;
    private Label lblPromo;
    private Label lblTotalBayarValue;
    private Label lblTotalBayar;
    private Panel panelMethod;
    private Label lblMetodePembayaran;
    private ComboBox cmbMetodePembayaran;
    private Panel panelAction;
    private Label lblStatusPembayaran;
    private Button btnBayar;
    private Button btnLihatTiket;
}
