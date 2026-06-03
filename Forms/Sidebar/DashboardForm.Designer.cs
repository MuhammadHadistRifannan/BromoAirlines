
namespace BromoAirlines.Forms;

partial class DashboardForm
{
    private System.ComponentModel.IContainer components = null!;
    private Panel sidebarPanel = null!;
    private PictureBox logoPictureBox = null!;
    private Button dashboardButton = null!;
    private Button masterBandaraButton = null!;
    private Button masterMaskapaiButton = null!;
    private Button masterJadwalButton = null!;
    private Button masterPromoButton = null!;
    private Button masterStatusButton = null!;
    private Panel contentPanel = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            components?.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
        sidebarPanel = new Panel();
        contentPanel = new Panel();
        pictureBox1 = new PictureBox();
        pictureBox2 = new PictureBox();
        label1 = new Label();
        label2 = new Label();
        button1 = new Button();
        label3 = new Label();
        button2 = new Button();
        label4 = new Label();
        button3 = new Button();
        label5 = new Label();
        button4 = new Button();
        label6 = new Label();
        button5 = new Button();
        button6 = new Button();
        label7 = new Label();
        sidebarPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        SuspendLayout();
        // 
        // sidebarPanel
        // 
        sidebarPanel.BackColor = SystemColors.Control;
        sidebarPanel.Controls.Add(label7);
        sidebarPanel.Controls.Add(button6);
        sidebarPanel.Controls.Add(label6);
        sidebarPanel.Controls.Add(button5);
        sidebarPanel.Controls.Add(label5);
        sidebarPanel.Controls.Add(button4);
        sidebarPanel.Controls.Add(label4);
        sidebarPanel.Controls.Add(button3);
        sidebarPanel.Controls.Add(label3);
        sidebarPanel.Controls.Add(button2);
        sidebarPanel.Controls.Add(label2);
        sidebarPanel.Controls.Add(label1);
        sidebarPanel.Controls.Add(pictureBox2);
        sidebarPanel.Controls.Add(pictureBox1);
        sidebarPanel.Controls.Add(button1);
        sidebarPanel.Dock = DockStyle.Left;
        sidebarPanel.Location = new Point(0, 0);
        sidebarPanel.Margin = new Padding(4, 5, 4, 5);
        sidebarPanel.Name = "sidebarPanel";
        sidebarPanel.Size = new Size(371, 1267);
        sidebarPanel.TabIndex = 0;
        // 
        // contentPanel
        // 
        contentPanel.Dock = DockStyle.Fill;
        contentPanel.Location = new Point(371, 0);
        contentPanel.Margin = new Padding(4, 5, 4, 5);
        contentPanel.Name = "contentPanel";
        contentPanel.Size = new Size(1343, 1267);
        contentPanel.TabIndex = 2;
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = Color.Transparent;
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(32, 26);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(306, 295);
        pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // pictureBox2
        // 
        pictureBox2.BackColor = Color.Transparent;
        pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
        pictureBox2.Location = new Point(32, 286);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(306, 127);
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox2.TabIndex = 1;
        pictureBox2.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F);
        label1.Location = new Point(32, 447);
        label1.Name = "label1";
        label1.Size = new Size(82, 32);
        label1.TabIndex = 2;
        label1.Text = "MENU";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.BackColor = Color.Transparent;
        label2.Font = new Font("Segoe UI", 12F);
        label2.Location = new Point(131, 531);
        label2.Name = "label2";
        label2.Size = new Size(129, 32);
        label2.TabIndex = 3;
        label2.Text = "Dashboard";
        // 
        // button1
        // 
        button1.BackColor = Color.Transparent;
        button1.Location = new Point(32, 506);
        button1.Name = "button1";
        button1.Size = new Size(317, 87);
        button1.TabIndex = 4;
        button1.UseVisualStyleBackColor = false;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.BackColor = Color.Transparent;
        label3.Font = new Font("Segoe UI", 12F);
        label3.Location = new Point(131, 638);
        label3.Name = "label3";
        label3.Size = new Size(154, 32);
        label3.TabIndex = 5;
        label3.Text = "Penerbangan";
        // 
        // button2
        // 
        button2.BackColor = Color.Transparent;
        button2.Location = new Point(32, 613);
        button2.Name = "button2";
        button2.Size = new Size(317, 87);
        button2.TabIndex = 6;
        button2.UseVisualStyleBackColor = false;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.BackColor = Color.Transparent;
        label4.Font = new Font("Segoe UI", 12F);
        label4.Location = new Point(131, 747);
        label4.Name = "label4";
        label4.Size = new Size(135, 32);
        label4.TabIndex = 7;
        label4.Text = "Pemesanan";
        // 
        // button3
        // 
        button3.BackColor = Color.Transparent;
        button3.Location = new Point(32, 722);
        button3.Name = "button3";
        button3.Size = new Size(317, 87);
        button3.TabIndex = 8;
        button3.UseVisualStyleBackColor = false;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.BackColor = Color.Transparent;
        label5.Font = new Font("Segoe UI", 12F);
        label5.Location = new Point(131, 858);
        label5.Name = "label5";
        label5.Size = new Size(95, 32);
        label5.TabIndex = 9;
        label5.Text = "Riwayat";
        // 
        // button4
        // 
        button4.BackColor = Color.Transparent;
        button4.Location = new Point(32, 833);
        button4.Name = "button4";
        button4.Size = new Size(317, 87);
        button4.TabIndex = 10;
        button4.UseVisualStyleBackColor = false;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.BackColor = Color.Transparent;
        label6.Font = new Font("Segoe UI", 12F);
        label6.Location = new Point(131, 970);
        label6.Name = "label6";
        label6.Size = new Size(69, 32);
        label6.TabIndex = 11;
        label6.Text = "Profil";
        // 
        // button5
        // 
        button5.BackColor = Color.Transparent;
        button5.Location = new Point(32, 945);
        button5.Name = "button5";
        button5.Size = new Size(317, 87);
        button5.TabIndex = 12;
        button5.UseVisualStyleBackColor = false;
        // 
        // button6
        // 
        button6.BackColor = Color.Transparent;
        button6.Location = new Point(32, 1106);
        button6.Name = "button6";
        button6.Size = new Size(317, 87);
        button6.TabIndex = 13;
        button6.UseVisualStyleBackColor = false;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.BackColor = Color.Transparent;
        label7.Font = new Font("Segoe UI", 12F);
        label7.Location = new Point(131, 1131);
        label7.Name = "label7";
        label7.Size = new Size(89, 32);
        label7.TabIndex = 14;
        label7.Text = "Logout";
        // 
        // DashboardForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1714, 1267);
        Controls.Add(contentPanel);
        Controls.Add(sidebarPanel);
        Margin = new Padding(4, 5, 4, 5);
        MinimumSize = new Size(1562, 1129);
        Name = "DashboardForm";
        Text = "Dashboard - Bromo Airlines";
        WindowState = FormWindowState.Maximized;
        sidebarPanel.ResumeLayout(false);
        sidebarPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
    }

    private static Button CreateSidebarButton(string text, int top)
    {
        var button = new Button
        {
            Cursor = Cursors.Hand,
            FlatStyle = FlatStyle.Flat,
            ForeColor = Color.White,
            Location = new Point(18, top),
            Size = new Size(224, 40),
            Text = text,
            TextAlign = ContentAlignment.MiddleLeft,
            UseVisualStyleBackColor = false
        };
        button.FlatAppearance.BorderSize = 0;
        return button;
    }

    private PictureBox pictureBox2;
    private PictureBox pictureBox1;
    private Label label1;
    private Label label2;
    private Button button1;
    private Label label4;
    private Button button3;
    private Label label3;
    private Button button2;
    private Label label7;
    private Button button6;
    private Label label6;
    private Button button5;
    private Label label5;
    private Button button4;
}
