namespace BromoAirlines.Forms
{
    partial class AdminDashboardForm
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
            lblWelcome = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(60, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(224, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dashboard";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F);
            lblWelcome.ForeColor = Color.Black;
            lblWelcome.Location = new Point(65, 110);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(491, 28);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Selamat Datang di Portal Administrator Bromo Airlines!";
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1182, 715);
            Controls.Add(lblWelcome);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblWelcome;
    }
}
