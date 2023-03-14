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
            this.HomePanel = new System.Windows.Forms.Panel();
            this.AiringScheduleText = new System.Windows.Forms.TextBox();
            this.StarButton = new System.Windows.Forms.Button();
            this.EntryButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.EntryPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StarButton2 = new System.Windows.Forms.Button();
            this.FilledInEntryButton = new System.Windows.Forms.Button();
            this.HomeButton2 = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SearchIntBox = new System.Windows.Forms.NumericUpDown();
            this.HomePanel.SuspendLayout();
            this.EntryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIntBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HomePanel
            // 
            this.HomePanel.Controls.Add(this.AiringScheduleText);
            this.HomePanel.Controls.Add(this.StarButton);
            this.HomePanel.Controls.Add(this.EntryButton);
            this.HomePanel.Controls.Add(this.HomeButton);
            this.HomePanel.Location = new System.Drawing.Point(15, 60);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(776, 375);
            this.HomePanel.TabIndex = 0;
            this.HomePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AiringScheduleText
            // 
            this.AiringScheduleText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AiringScheduleText.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.AiringScheduleText.Location = new System.Drawing.Point(122, 3);
            this.AiringScheduleText.Multiline = true;
            this.AiringScheduleText.Name = "AiringScheduleText";
            this.AiringScheduleText.ReadOnly = true;
            this.AiringScheduleText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AiringScheduleText.Size = new System.Drawing.Size(651, 369);
            this.AiringScheduleText.TabIndex = 3;
            this.AiringScheduleText.Text = "Airing Schedule";
            this.AiringScheduleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.StarButton.Click += new System.EventHandler(this.StarButton_Click);
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
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EntryPanel
            // 
            this.EntryPanel.Controls.Add(this.textBox1);
            this.EntryPanel.Controls.Add(this.StarButton2);
            this.EntryPanel.Controls.Add(this.FilledInEntryButton);
            this.EntryPanel.Controls.Add(this.HomeButton2);
            this.EntryPanel.Location = new System.Drawing.Point(15, 60);
            this.EntryPanel.Name = "EntryPanel";
            this.EntryPanel.Size = new System.Drawing.Size(776, 375);
            this.EntryPanel.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(122, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(651, 369);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Entry Information";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StarButton2
            // 
            this.StarButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.StarButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StarButton2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.StarButton2.Image = ((System.Drawing.Image)(resources.GetObject("StarButton2.Image")));
            this.StarButton2.Location = new System.Drawing.Point(3, 181);
            this.StarButton2.Name = "StarButton2";
            this.StarButton2.Size = new System.Drawing.Size(83, 83);
            this.StarButton2.TabIndex = 2;
            this.StarButton2.UseVisualStyleBackColor = true;
            // 
            // FilledInEntryButton
            // 
            this.FilledInEntryButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FilledInEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilledInEntryButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FilledInEntryButton.Image = ((System.Drawing.Image)(resources.GetObject("FilledInEntryButton.Image")));
            this.FilledInEntryButton.Location = new System.Drawing.Point(0, 92);
            this.FilledInEntryButton.Name = "FilledInEntryButton";
            this.FilledInEntryButton.Size = new System.Drawing.Size(83, 83);
            this.FilledInEntryButton.TabIndex = 1;
            this.FilledInEntryButton.UseVisualStyleBackColor = true;
            // 
            // HomeButton2
            // 
            this.HomeButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HomeButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.HomeButton2.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton2.Image")));
            this.HomeButton2.Location = new System.Drawing.Point(0, 3);
            this.HomeButton2.Name = "HomeButton2";
            this.HomeButton2.Size = new System.Drawing.Size(83, 83);
            this.HomeButton2.TabIndex = 0;
            this.HomeButton2.UseVisualStyleBackColor = true;
            this.HomeButton2.Click += new System.EventHandler(this.button3_Click);
            // 
            // BackButton
            // 
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BackButton.Location = new System.Drawing.Point(20, 18);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(42, 29);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "◀";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SearchIntBox
            // 
            this.SearchIntBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SearchIntBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchIntBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SearchIntBox.Location = new System.Drawing.Point(556, 18);
            this.SearchIntBox.Name = "SearchIntBox";
            this.SearchIntBox.Size = new System.Drawing.Size(150, 23);
            this.SearchIntBox.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchIntBox);
            this.Controls.Add(this.EntryPanel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.HomePanel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            this.EntryPanel.ResumeLayout(false);
            this.EntryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIntBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel HomePanel;
        private Button HomeButton;
        private Button StarButton;
        private Button EntryButton;
        private TextBox AiringScheduleText;
        private Panel EntryPanel;
        private TextBox textBox1;
        private Button StarButton2;
        private Button FilledInEntryButton;
        private Button HomeButton2;
        private Button BackButton;
        private NumericUpDown SearchIntBox;
    }
}