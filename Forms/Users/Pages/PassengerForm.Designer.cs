namespace BromoAirlines.Forms.Users.Pages;

partial class PassengerForm
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
        flowPassenger = new FlowLayoutPanel();
        panelAction = new Panel();
        btnLanjut = new Button();
        panelSummary.SuspendLayout();
        panelAction.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        lblTitle.ForeColor = Color.Navy;
        lblTitle.Location = new Point(48, 42);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(341, 54);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Data Penumpang";
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
        lblSummaryDescription.Text = "Lengkapi data setiap penumpang sesuai jumlah penumpang pada booking.";
        // 
        // lblSummaryTitle
        // 
        lblSummaryTitle.AutoSize = true;
        lblSummaryTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblSummaryTitle.ForeColor = Color.White;
        lblSummaryTitle.Location = new Point(32, 24);
        lblSummaryTitle.Name = "lblSummaryTitle";
        lblSummaryTitle.Size = new Size(374, 50);
        lblSummaryTitle.TabIndex = 0;
        lblSummaryTitle.Text = "Informasi Penumpang";
        // 
        // flowPassenger
        // 
        flowPassenger.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        flowPassenger.AutoScroll = true;
        flowPassenger.FlowDirection = FlowDirection.TopDown;
        flowPassenger.Location = new Point(48, 318);
        flowPassenger.Name = "flowPassenger";
        flowPassenger.Size = new Size(1220, 500);
        flowPassenger.TabIndex = 2;
        flowPassenger.WrapContents = false;
        // 
        // panelAction
        // 
        panelAction.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        panelAction.BackColor = SystemColors.Control;
        panelAction.Controls.Add(btnLanjut);
        panelAction.Location = new Point(48, 848);
        panelAction.Name = "panelAction";
        panelAction.Size = new Size(1220, 102);
        panelAction.TabIndex = 3;
        // 
        // btnLanjut
        // 
        btnLanjut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLanjut.BackColor = Color.RoyalBlue;
        btnLanjut.Cursor = Cursors.Hand;
        btnLanjut.FlatAppearance.BorderSize = 0;
        btnLanjut.FlatStyle = FlatStyle.Flat;
        btnLanjut.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnLanjut.ForeColor = Color.White;
        btnLanjut.Location = new Point(1000, 22);
        btnLanjut.Name = "btnLanjut";
        btnLanjut.Size = new Size(220, 58);
        btnLanjut.TabIndex = 0;
        btnLanjut.Text = "Lanjut";
        btnLanjut.UseVisualStyleBackColor = false;
        btnLanjut.Click += BtnLanjutClick;
        // 
        // PassengerForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1375, 1050);
        Controls.Add(panelAction);
        Controls.Add(flowPassenger);
        Controls.Add(panelSummary);
        Controls.Add(lblTitle);
        FormBorderStyle = FormBorderStyle.None;
        Name = "PassengerForm";
        Text = "Data Penumpang";
        panelSummary.ResumeLayout(false);
        panelSummary.PerformLayout();
        panelAction.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitle;
    private Panel panelSummary;
    private Label lblSummaryTitle;
    private Label lblSummaryDescription;
    private FlowLayoutPanel flowPassenger;
    private Panel panelAction;
    private Button btnLanjut;
}
