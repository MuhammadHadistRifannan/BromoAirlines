namespace BromoAirlines.Forms.Users.Pages;

partial class HomeUserForm
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
        panelMain = new Panel();
        panelShortcut = new Panel();
        lblShortcutDescription = new Label();
        btnSearchFlight = new Button();
        lblShortcutTitle = new Label();
        panelPromoContainer = new Panel();
        panelPromoThree = new Panel();
        lblPromoThreeDescription = new Label();
        lblPromoThreeTitle = new Label();
        panelPromoTwo = new Panel();
        lblPromoTwoDescription = new Label();
        lblPromoTwoTitle = new Label();
        panelPromoOne = new Panel();
        lblPromoOneDescription = new Label();
        lblPromoOneTitle = new Label();
        lblPromoSection = new Label();
        panelBanner = new Panel();
        pbBannerLogo = new PictureBox();
        lblBannerSubtitle = new Label();
        lblBannerTitle = new Label();
        panelMain.SuspendLayout();
        panelShortcut.SuspendLayout();
        panelPromoContainer.SuspendLayout();
        panelPromoThree.SuspendLayout();
        panelPromoTwo.SuspendLayout();
        panelPromoOne.SuspendLayout();
        panelBanner.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pbBannerLogo).BeginInit();
        SuspendLayout();
        // 
        // panelMain
        // 
        panelMain.AutoScroll = true;
        panelMain.BackColor = SystemColors.Control;
        panelMain.Controls.Add(panelShortcut);
        panelMain.Controls.Add(panelPromoContainer);
        panelMain.Controls.Add(lblPromoSection);
        panelMain.Controls.Add(panelBanner);
        panelMain.Dock = DockStyle.Fill;
        panelMain.Location = new Point(0, 0);
        panelMain.Name = "panelMain";
        panelMain.Padding = new Padding(48);
        panelMain.Size = new Size(1375, 1050);
        panelMain.TabIndex = 0;
        // 
        // panelShortcut
        // 
        panelShortcut.BackColor = Color.White;
        panelShortcut.Controls.Add(lblShortcutDescription);
        panelShortcut.Controls.Add(btnSearchFlight);
        panelShortcut.Controls.Add(lblShortcutTitle);
        panelShortcut.Location = new Point(48, 626);
        panelShortcut.Name = "panelShortcut";
        panelShortcut.Padding = new Padding(32, 28, 32, 28);
        panelShortcut.Size = new Size(1220, 180);
        panelShortcut.TabIndex = 3;
        // 
        // lblShortcutDescription
        // 
        lblShortcutDescription.Font = new Font("Segoe UI", 11F);
        lblShortcutDescription.ForeColor = Color.DimGray;
        lblShortcutDescription.Location = new Point(32, 78);
        lblShortcutDescription.Name = "lblShortcutDescription";
        lblShortcutDescription.Size = new Size(720, 58);
        lblShortcutDescription.TabIndex = 2;
        lblShortcutDescription.Text = "Mulai pencarian rute, tanggal keberangkatan, dan jumlah penumpang dari satu halaman.";
        // 
        // btnSearchFlight
        // 
        btnSearchFlight.BackColor = Color.RoyalBlue;
        btnSearchFlight.Cursor = Cursors.Hand;
        btnSearchFlight.FlatAppearance.BorderSize = 0;
        btnSearchFlight.FlatStyle = FlatStyle.Flat;
        btnSearchFlight.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnSearchFlight.ForeColor = Color.White;
        btnSearchFlight.Location = new Point(910, 62);
        btnSearchFlight.Name = "btnSearchFlight";
        btnSearchFlight.Size = new Size(240, 58);
        btnSearchFlight.TabIndex = 1;
        btnSearchFlight.Text = "Cari Penerbangan";
        btnSearchFlight.UseVisualStyleBackColor = false;
        btnSearchFlight.Click += BtnSearchFlightClick;
        // 
        // lblShortcutTitle
        // 
        lblShortcutTitle.AutoSize = true;
        lblShortcutTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblShortcutTitle.ForeColor = Color.Navy;
        lblShortcutTitle.Location = new Point(32, 28);
        lblShortcutTitle.Name = "lblShortcutTitle";
        lblShortcutTitle.Size = new Size(361, 41);
        lblShortcutTitle.TabIndex = 0;
        lblShortcutTitle.Text = "Mau terbang ke mana?";
        // 
        // panelPromoContainer
        // 
        panelPromoContainer.Controls.Add(panelPromoThree);
        panelPromoContainer.Controls.Add(panelPromoTwo);
        panelPromoContainer.Controls.Add(panelPromoOne);
        panelPromoContainer.Location = new Point(48, 412);
        panelPromoContainer.Name = "panelPromoContainer";
        panelPromoContainer.Size = new Size(1220, 170);
        panelPromoContainer.TabIndex = 2;
        // 
        // panelPromoThree
        // 
        panelPromoThree.BackColor = Color.White;
        panelPromoThree.Controls.Add(lblPromoThreeDescription);
        panelPromoThree.Controls.Add(lblPromoThreeTitle);
        panelPromoThree.Location = new Point(828, 0);
        panelPromoThree.Name = "panelPromoThree";
        panelPromoThree.Padding = new Padding(24);
        panelPromoThree.Size = new Size(392, 170);
        panelPromoThree.TabIndex = 2;
        // 
        // lblPromoThreeDescription
        // 
        lblPromoThreeDescription.Font = new Font("Segoe UI", 10F);
        lblPromoThreeDescription.ForeColor = Color.DimGray;
        lblPromoThreeDescription.Location = new Point(24, 74);
        lblPromoThreeDescription.Name = "lblPromoThreeDescription";
        lblPromoThreeDescription.Size = new Size(330, 58);
        lblPromoThreeDescription.TabIndex = 1;
        lblPromoThreeDescription.Text = "Dapatkan harga hemat untuk pemesanan pulang-pergi.";
        // 
        // lblPromoThreeTitle
        // 
        lblPromoThreeTitle.AutoSize = true;
        lblPromoThreeTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblPromoThreeTitle.ForeColor = Color.Navy;
        lblPromoThreeTitle.Location = new Point(24, 24);
        lblPromoThreeTitle.Name = "lblPromoThreeTitle";
        lblPromoThreeTitle.Size = new Size(234, 32);
        lblPromoThreeTitle.TabIndex = 0;
        lblPromoThreeTitle.Text = "Pulang Pergi Hemat";
        // 
        // panelPromoTwo
        // 
        panelPromoTwo.BackColor = Color.White;
        panelPromoTwo.Controls.Add(lblPromoTwoDescription);
        panelPromoTwo.Controls.Add(lblPromoTwoTitle);
        panelPromoTwo.Location = new Point(414, 0);
        panelPromoTwo.Name = "panelPromoTwo";
        panelPromoTwo.Padding = new Padding(24);
        panelPromoTwo.Size = new Size(392, 170);
        panelPromoTwo.TabIndex = 1;
        // 
        // lblPromoTwoDescription
        // 
        lblPromoTwoDescription.Font = new Font("Segoe UI", 10F);
        lblPromoTwoDescription.ForeColor = Color.DimGray;
        lblPromoTwoDescription.Location = new Point(24, 74);
        lblPromoTwoDescription.Name = "lblPromoTwoDescription";
        lblPromoTwoDescription.Size = new Size(330, 58);
        lblPromoTwoDescription.TabIndex = 1;
        lblPromoTwoDescription.Text = "Nikmati pilihan jadwal pagi untuk perjalanan bisnis.";
        // 
        // lblPromoTwoTitle
        // 
        lblPromoTwoTitle.AutoSize = true;
        lblPromoTwoTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblPromoTwoTitle.ForeColor = Color.Navy;
        lblPromoTwoTitle.Location = new Point(24, 24);
        lblPromoTwoTitle.Name = "lblPromoTwoTitle";
        lblPromoTwoTitle.Size = new Size(216, 32);
        lblPromoTwoTitle.TabIndex = 0;
        lblPromoTwoTitle.Text = "Terbang Pagi";
        // 
        // panelPromoOne
        // 
        panelPromoOne.BackColor = Color.White;
        panelPromoOne.Controls.Add(lblPromoOneDescription);
        panelPromoOne.Controls.Add(lblPromoOneTitle);
        panelPromoOne.Location = new Point(0, 0);
        panelPromoOne.Name = "panelPromoOne";
        panelPromoOne.Padding = new Padding(24);
        panelPromoOne.Size = new Size(392, 170);
        panelPromoOne.TabIndex = 0;
        // 
        // lblPromoOneDescription
        // 
        lblPromoOneDescription.Font = new Font("Segoe UI", 10F);
        lblPromoOneDescription.ForeColor = Color.DimGray;
        lblPromoOneDescription.Location = new Point(24, 74);
        lblPromoOneDescription.Name = "lblPromoOneDescription";
        lblPromoOneDescription.Size = new Size(330, 58);
        lblPromoOneDescription.TabIndex = 1;
        lblPromoOneDescription.Text = "Temukan pilihan rute populer untuk liburan berikutnya.";
        // 
        // lblPromoOneTitle
        // 
        lblPromoOneTitle.AutoSize = true;
        lblPromoOneTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblPromoOneTitle.ForeColor = Color.Navy;
        lblPromoOneTitle.Location = new Point(24, 24);
        lblPromoOneTitle.Name = "lblPromoOneTitle";
        lblPromoOneTitle.Size = new Size(186, 32);
        lblPromoOneTitle.TabIndex = 0;
        lblPromoOneTitle.Text = "Promo Liburan";
        // 
        // lblPromoSection
        // 
        lblPromoSection.AutoSize = true;
        lblPromoSection.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblPromoSection.ForeColor = Color.Navy;
        lblPromoSection.Location = new Point(48, 340);
        lblPromoSection.Name = "lblPromoSection";
        lblPromoSection.Size = new Size(252, 46);
        lblPromoSection.TabIndex = 1;
        lblPromoSection.Text = "Promo Pilihan";
        // 
        // panelBanner
        // 
        panelBanner.BackColor = Color.RoyalBlue;
        panelBanner.Controls.Add(pbBannerLogo);
        panelBanner.Controls.Add(lblBannerSubtitle);
        panelBanner.Controls.Add(lblBannerTitle);
        panelBanner.Location = new Point(48, 48);
        panelBanner.Name = "panelBanner";
        panelBanner.Size = new Size(1220, 250);
        panelBanner.TabIndex = 0;
        // 
        // pbBannerLogo
        // 
        pbBannerLogo.ImageLocation = "Assets\\white-logo.png";
        pbBannerLogo.Location = new Point(900, 36);
        pbBannerLogo.Name = "pbBannerLogo";
        pbBannerLogo.Size = new Size(220, 170);
        pbBannerLogo.SizeMode = PictureBoxSizeMode.Zoom;
        pbBannerLogo.TabIndex = 2;
        pbBannerLogo.TabStop = false;
        // 
        // lblBannerSubtitle
        // 
        lblBannerSubtitle.Font = new Font("Segoe UI", 14F);
        lblBannerSubtitle.ForeColor = Color.White;
        lblBannerSubtitle.Location = new Point(48, 128);
        lblBannerSubtitle.Name = "lblBannerSubtitle";
        lblBannerSubtitle.Size = new Size(640, 72);
        lblBannerSubtitle.TabIndex = 1;
        lblBannerSubtitle.Text = "Pesan tiket, cek perjalanan, dan nikmati pengalaman terbang yang lebih mudah.";
        // 
        // lblBannerTitle
        // 
        lblBannerTitle.AutoSize = true;
        lblBannerTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
        lblBannerTitle.ForeColor = Color.White;
        lblBannerTitle.Location = new Point(48, 52);
        lblBannerTitle.Name = "lblBannerTitle";
        lblBannerTitle.Size = new Size(563, 62);
        lblBannerTitle.TabIndex = 0;
        lblBannerTitle.Text = "Selamat datang kembali";
        // 
        // HomeUserForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1375, 1050);
        Controls.Add(panelMain);
        FormBorderStyle = FormBorderStyle.None;
        Name = "HomeUserForm";
        Text = "Home";
        panelMain.ResumeLayout(false);
        panelMain.PerformLayout();
        panelShortcut.ResumeLayout(false);
        panelShortcut.PerformLayout();
        panelPromoContainer.ResumeLayout(false);
        panelPromoThree.ResumeLayout(false);
        panelPromoThree.PerformLayout();
        panelPromoTwo.ResumeLayout(false);
        panelPromoTwo.PerformLayout();
        panelPromoOne.ResumeLayout(false);
        panelPromoOne.PerformLayout();
        panelBanner.ResumeLayout(false);
        panelBanner.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pbBannerLogo).EndInit();
        ResumeLayout(false);
    }

    private Panel panelMain;
    private Panel panelBanner;
    private Label lblBannerTitle;
    private Label lblBannerSubtitle;
    private PictureBox pbBannerLogo;
    private Label lblPromoSection;
    private Panel panelPromoContainer;
    private Panel panelPromoOne;
    private Label lblPromoOneTitle;
    private Label lblPromoOneDescription;
    private Panel panelPromoTwo;
    private Label lblPromoTwoDescription;
    private Label lblPromoTwoTitle;
    private Panel panelPromoThree;
    private Label lblPromoThreeDescription;
    private Label lblPromoThreeTitle;
    private Panel panelShortcut;
    private Label lblShortcutTitle;
    private Button btnSearchFlight;
    private Label lblShortcutDescription;
}
