namespace BromoAirlines.Forms
{
    partial class MasterKodePromoForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
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
            lblTitle.Location = new Point(60, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(380, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Master Kode Promo";
            // 
            // MasterKodePromoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1182, 715);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MasterKodePromoForm";
            Text = "MasterKodePromoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
    }
}
