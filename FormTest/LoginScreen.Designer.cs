namespace FormTest {
    partial class LoginScreen {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            loginbutton = new Button();
            UserText = new TextBox();
            PasswordText = new TextBox();
            StatusText = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(341, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Location = new Point(284, 215);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Location = new Point(284, 297);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 1);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(232, 198);
            label1.Name = "label1";
            label1.Size = new Size(42, 19);
            label1.TabIndex = 3;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(196, 279);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // loginbutton
            // 
            loginbutton.BackColor = Color.FromArgb(64, 0, 64);
            loginbutton.Cursor = Cursors.Hand;
            loginbutton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            loginbutton.FlatAppearance.BorderSize = 0;
            loginbutton.FlatAppearance.MouseDownBackColor = Color.Silver;
            loginbutton.FlatAppearance.MouseOverBackColor = Color.Silver;
            loginbutton.FlatStyle = FlatStyle.Flat;
            loginbutton.ForeColor = SystemColors.Highlight;
            loginbutton.Location = new Point(341, 346);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(94, 29);
            loginbutton.TabIndex = 5;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            // 
            // UserText
            // 
            UserText.BackColor = SystemColors.InfoText;
            UserText.BorderStyle = BorderStyle.None;
            UserText.ForeColor = SystemColors.MenuHighlight;
            UserText.Location = new Point(287, 193);
            UserText.Name = "UserText";
            UserText.Size = new Size(247, 20);
            UserText.TabIndex = 6;
            UserText.TextChanged += UserText_TextChanged;
            // 
            // PasswordText
            // 
            PasswordText.BackColor = SystemColors.InactiveCaptionText;
            PasswordText.BorderStyle = BorderStyle.None;
            PasswordText.ForeColor = SystemColors.MenuHighlight;
            PasswordText.Location = new Point(287, 275);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(247, 20);
            PasswordText.TabIndex = 7;
            PasswordText.UseSystemPasswordChar = true;
            // 
            // StatusText
            // 
            StatusText.BackColor = Color.Black;
            StatusText.BorderStyle = BorderStyle.None;
            StatusText.ForeColor = SystemColors.MenuHighlight;
            StatusText.Location = new Point(341, 146);
            StatusText.Name = "StatusText";
            StatusText.ReadOnly = true;
            StatusText.Size = new Size(125, 20);
            StatusText.TabIndex = 8;
            StatusText.TextChanged += StatusText_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(220, 65);
            label3.Name = "label3";
            label3.Size = new Size(104, 29);
            label3.TabIndex = 9;
            label3.Text = "Parker";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(487, 65);
            label4.Name = "label4";
            label4.Size = new Size(117, 29);
            label4.TabIndex = 10;
            label4.Text = "Tracker";
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(StatusText);
            Controls.Add(PasswordText);
            Controls.Add(UserText);
            Controls.Add(loginbutton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "LoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Button loginbutton;
        private TextBox UserText;
        private TextBox PasswordText;
        private TextBox StatusText;
        private Label label3;
        private Label label4;
    }
}