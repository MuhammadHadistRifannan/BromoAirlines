namespace BromoAirlines.Forms.AirlineAdmin.Pages;

partial class MaskapaiPlaceholderPage
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
        lblMessage = new Label();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        lblTitle.ForeColor = Color.Navy;
        lblTitle.Location = new Point(54, 44);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(202, 54);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Halaman";
        // 
        // lblMessage
        // 
        lblMessage.AutoSize = true;
        lblMessage.Font = new Font("Segoe UI", 12F);
        lblMessage.ForeColor = Color.DimGray;
        lblMessage.Location = new Point(60, 118);
        lblMessage.Name = "lblMessage";
        lblMessage.Size = new Size(596, 28);
        lblMessage.TabIndex = 1;
        lblMessage.Text = "Halaman ini akan diimplementasikan pada phase berikutnya.";
        // 
        // MaskapaiPlaceholderPage
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(1375, 1050);
        Controls.Add(lblMessage);
        Controls.Add(lblTitle);
        FormBorderStyle = FormBorderStyle.None;
        Name = "MaskapaiPlaceholderPage";
        Text = "MaskapaiPlaceholderPage";
        Load += MaskapaiPlaceholderPageLoad;
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitle;
    private Label lblMessage;
}
