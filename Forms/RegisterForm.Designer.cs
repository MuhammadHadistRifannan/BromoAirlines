namespace BromoAirlines.Forms
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            loginCard = new Panel();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Telepon_Textbox = new TextBox();
            tanggalLahir_Textbox = new DateTimePicker();
            confirmPw_textBox = new TextBox();
            nama_lengkapTextbox = new TextBox();
            pictureBox3 = new PictureBox();
            masuk_link = new LinkLabel();
            label1 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            titleLabel = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginCard
            // 
            loginCard.BackColor = Color.White;
            loginCard.Controls.Add(label7);
            loginCard.Controls.Add(label6);
            loginCard.Controls.Add(label4);
            loginCard.Controls.Add(label3);
            loginCard.Controls.Add(label2);
            loginCard.Controls.Add(Telepon_Textbox);
            loginCard.Controls.Add(tanggalLahir_Textbox);
            loginCard.Controls.Add(confirmPw_textBox);
            loginCard.Controls.Add(nama_lengkapTextbox);
            loginCard.Controls.Add(pictureBox3);
            loginCard.Controls.Add(masuk_link);
            loginCard.Controls.Add(label1);
            loginCard.Controls.Add(button1);
            loginCard.Controls.Add(pictureBox2);
            loginCard.Controls.Add(pictureBox1);
            loginCard.Controls.Add(titleLabel);
            loginCard.Controls.Add(usernameTextBox);
            loginCard.Controls.Add(passwordTextBox);
            loginCard.Dock = DockStyle.Fill;
            loginCard.Location = new Point(0, 0);
            loginCard.Margin = new Padding(3, 4, 3, 4);
            loginCard.Name = "loginCard";
            loginCard.Size = new Size(1017, 672);
            loginCard.TabIndex = 1;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(31, 41, 55);
            label7.Location = new Point(214, 490);
            label7.Name = "label7";
            label7.Size = new Size(158, 41);
            label7.TabIndex = 21;
            label7.Text = "Telepon";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(31, 41, 55);
            label6.Location = new Point(214, 441);
            label6.Name = "label6";
            label6.Size = new Size(158, 41);
            label6.TabIndex = 20;
            label6.Text = "Tanggal Lahir";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(31, 41, 55);
            label4.Location = new Point(214, 338);
            label4.Name = "label4";
            label4.Size = new Size(148, 41);
            label4.TabIndex = 18;
            label4.Text = "Password";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(31, 41, 55);
            label3.Location = new Point(214, 286);
            label3.Name = "label3";
            label3.Size = new Size(148, 41);
            label3.TabIndex = 17;
            label3.Text = "Username";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(31, 41, 55);
            label2.Location = new Point(214, 235);
            label2.Name = "label2";
            label2.Size = new Size(148, 41);
            label2.TabIndex = 16;
            label2.Text = "Nama Lengkap";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Telepon_Textbox
            // 
            Telepon_Textbox.BorderStyle = BorderStyle.FixedSingle;
            Telepon_Textbox.Font = new Font("Segoe UI", 12F);
            Telepon_Textbox.Location = new Point(383, 495);
            Telepon_Textbox.Margin = new Padding(3, 4, 3, 4);
            Telepon_Textbox.Name = "Telepon_Textbox";
            Telepon_Textbox.PlaceholderText = "Nomor Telepon";
            Telepon_Textbox.Size = new Size(324, 34);
            Telepon_Textbox.TabIndex = 15;
            Telepon_Textbox.TextAlign = HorizontalAlignment.Center;
            Telepon_Textbox.UseSystemPasswordChar = true;
            // 
            // tanggalLahir_Textbox
            // 
            tanggalLahir_Textbox.Font = new Font("Segoe UI", 12F);
            tanggalLahir_Textbox.Location = new Point(388, 444);
            tanggalLahir_Textbox.Margin = new Padding(2);
            tanggalLahir_Textbox.Name = "tanggalLahir_Textbox";
            tanggalLahir_Textbox.Size = new Size(320, 34);
            tanggalLahir_Textbox.TabIndex = 14;
            // 
            // confirmPw_textBox
            // 
            confirmPw_textBox.BorderStyle = BorderStyle.FixedSingle;
            confirmPw_textBox.Font = new Font("Segoe UI", 12F);
            confirmPw_textBox.Location = new Point(383, 394);
            confirmPw_textBox.Margin = new Padding(3, 4, 3, 4);
            confirmPw_textBox.Name = "confirmPw_textBox";
            confirmPw_textBox.PlaceholderText = "Konfirmasi Password";
            confirmPw_textBox.Size = new Size(324, 34);
            confirmPw_textBox.TabIndex = 13;
            confirmPw_textBox.TextAlign = HorizontalAlignment.Center;
            confirmPw_textBox.UseSystemPasswordChar = true;
            // 
            // nama_lengkapTextbox
            // 
            nama_lengkapTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nama_lengkapTextbox.BorderStyle = BorderStyle.FixedSingle;
            nama_lengkapTextbox.Font = new Font("Segoe UI", 12F);
            nama_lengkapTextbox.Location = new Point(383, 241);
            nama_lengkapTextbox.Margin = new Padding(3, 4, 3, 4);
            nama_lengkapTextbox.Name = "nama_lengkapTextbox";
            nama_lengkapTextbox.PlaceholderText = "Nama Lengkap";
            nama_lengkapTextbox.Size = new Size(324, 34);
            nama_lengkapTextbox.TabIndex = 12;
            nama_lengkapTextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(214, 0);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(247, 202);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // masuk_link
            // 
            masuk_link.AutoSize = true;
            masuk_link.Font = new Font("Segoe UI", 10F);
            masuk_link.Location = new Point(536, 618);
            masuk_link.Margin = new Padding(2, 0, 2, 0);
            masuk_link.Name = "masuk_link";
            masuk_link.Size = new Size(107, 23);
            masuk_link.TabIndex = 10;
            masuk_link.TabStop = true;
            masuk_link.Text = "Masuk disini.";
            masuk_link.LinkClicked += masuk_link_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(382, 618);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(164, 23);
            label1.TabIndex = 9;
            label1.Text = "Sudah punya akun?.";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(469, 550);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(114, 46);
            button1.TabIndex = 8;
            button1.Text = "Daftar";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(445, 26);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(281, 146);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1017, 164);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(31, 41, 55);
            titleLabel.Location = new Point(398, 174);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(310, 41);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Daftar Akun";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Font = new Font("Segoe UI", 12F);
            usernameTextBox.Location = new Point(383, 291);
            usernameTextBox.Margin = new Padding(3, 4, 3, 4);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Username";
            usernameTextBox.Size = new Size(324, 34);
            usernameTextBox.TabIndex = 2;
            usernameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Segoe UI", 12F);
            passwordTextBox.Location = new Point(383, 344);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(324, 34);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.TextAlign = HorizontalAlignment.Center;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 672);
            Controls.Add(loginCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            loginCard.ResumeLayout(false);
            loginCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginCard;
        private LinkLabel masuk_link;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label titleLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private TextBox confirmPw_textBox;
        private TextBox nama_lengkapTextbox;
        private PictureBox pictureBox3;
        private TextBox Telepon_Textbox;
        private DateTimePicker tanggalLahir_Textbox;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
    }
}