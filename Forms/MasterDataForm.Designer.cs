
namespace BromoAirlines.Forms;

partial class MasterDataForm
{
    private System.ComponentModel.IContainer components = null!;
    protected Label titleLabel = null!;
    protected FlowLayoutPanel toolbarPanel = null!;
    protected Button addButton = null!;
    protected Button editButton = null!;
    protected Button deleteButton = null!;
    protected Panel gridPanel = null!;
    protected DataGridView dataGridView = null!;

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
        titleLabel = new Label();
        toolbarPanel = new FlowLayoutPanel();
        gridPanel = new Panel();
        toolbarPanel.SuspendLayout();
        gridPanel.SuspendLayout();
        SuspendLayout();

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Name = "MasterDataForm";
        Padding = new Padding(28);
        Size = new Size(900, 560);

        titleLabel.Dock = DockStyle.Top;
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(844, 46);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "Master Data";
        titleLabel.TextAlign = ContentAlignment.MiddleLeft;

        toolbarPanel.Controls.Add(addButton);
        toolbarPanel.Controls.Add(editButton);
        toolbarPanel.Controls.Add(deleteButton);
        toolbarPanel.Dock = DockStyle.Top;
        toolbarPanel.FlowDirection = FlowDirection.LeftToRight;
        toolbarPanel.Name = "toolbarPanel";
        toolbarPanel.Size = new Size(844, 54);
        toolbarPanel.TabIndex = 1;

        addButton.Name = "addButton";
        addButton.Size = new Size(96, 42);
        addButton.TabIndex = 0;

        editButton.Name = "editButton";
        editButton.Size = new Size(96, 42);
        editButton.TabIndex = 1;

        deleteButton.Name = "deleteButton";
        deleteButton.Size = new Size(96, 42);
        deleteButton.TabIndex = 2;

        gridPanel.BackColor = Color.White;
        gridPanel.Controls.Add(dataGridView);
        gridPanel.Dock = DockStyle.Fill;
        gridPanel.Name = "gridPanel";
        gridPanel.Padding = new Padding(12);
        gridPanel.Size = new Size(844, 404);
        gridPanel.TabIndex = 2;

        dataGridView.Name = "dataGridView";
        dataGridView.TabIndex = 0;

        Controls.Add(gridPanel);
        Controls.Add(toolbarPanel);
        Controls.Add(titleLabel);
        toolbarPanel.ResumeLayout(false);
        gridPanel.ResumeLayout(false);
        ResumeLayout(false);
    }
}
