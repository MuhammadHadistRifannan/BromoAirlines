
namespace BromoAirlines.Forms;

partial class SplashForm
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Timer splashTimer = null!;
    private PictureBox logoPictureBox = null!;
    private Label titleLabel = null!;

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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
        splashTimer = new System.Windows.Forms.Timer(components);
        titleLabel = new Label();
        pictureBox1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // splashTimer
        // 
        splashTimer.Interval = 1000;
        splashTimer.Tick += SplashTimer_Tick;
        // 
        // titleLabel
        // 
        titleLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        titleLabel.ForeColor = Color.FromArgb(21, 101, 192);
        titleLabel.Location = new Point(13, 353);
        titleLabel.Margin = new Padding(4, 0, 4, 0);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(743, 73);
        titleLabel.TabIndex = 1;
        titleLabel.Text = "Bromo Airlines";
        titleLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
        pictureBox1.BackgroundImageLayout = ImageLayout.None;
        pictureBox1.Location = new Point(84, -1);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(573, 439);
        pictureBox1.TabIndex = 2;
        pictureBox1.TabStop = false;
        // 
        // SplashForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(743, 533);
        Controls.Add(titleLabel);
        Controls.Add(pictureBox1);
        DoubleBuffered = true;
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(4, 5, 4, 5);
        Name = "SplashForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bromo Airlines";
        Shown += SplashForm_Shown;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private PictureBox pictureBox1;
}
