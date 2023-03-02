namespace FormTest {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.EntryButton = new System.Windows.Forms.Button();
            this.StarButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StarButton);
            this.panel1.Controls.Add(this.EntryButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 375);
            this.panel1.TabIndex = 0;
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.Location = new System.Drawing.Point(0, 3);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(83, 83);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EntryButton
            // 
            this.EntryButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntryButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.EntryButton.Image = ((System.Drawing.Image)(resources.GetObject("EntryButton.Image")));
            this.EntryButton.Location = new System.Drawing.Point(0, 92);
            this.EntryButton.Name = "EntryButton";
            this.EntryButton.Size = new System.Drawing.Size(83, 83);
            this.EntryButton.TabIndex = 1;
            this.EntryButton.Text = "Home";
            this.EntryButton.UseVisualStyleBackColor = true;
            this.EntryButton.Click += new System.EventHandler(this.EntryButton_Click);
            // 
            // StarButton
            // 
            this.StarButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.StarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StarButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.StarButton.Image = ((System.Drawing.Image)(resources.GetObject("StarButton.Image")));
            this.StarButton.Location = new System.Drawing.Point(3, 181);
            this.StarButton.Name = "StarButton";
            this.StarButton.Size = new System.Drawing.Size(83, 83);
            this.StarButton.TabIndex = 2;
            this.StarButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button HomeButton;
        private Button StarButton;
        private Button EntryButton;
    }
}