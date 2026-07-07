namespace BromoAirlines.Forms.Users.Pages;

partial class UserPlaceholderPage
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
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        lblTitle.ForeColor = Color.Navy;
        lblTitle.Location = new Point(48, 48);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(148, 54);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Home";
        // 
        // UserPlaceholderPage
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1375, 1050);
        Controls.Add(lblTitle);
        FormBorderStyle = FormBorderStyle.None;
        Name = "UserPlaceholderPage";
        Padding = new Padding(48);
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitle;
}
