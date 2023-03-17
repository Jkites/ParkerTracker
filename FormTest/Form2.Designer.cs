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
            HomePanel = new Panel();
            AiringScheduleText = new TextBox();
            StarButton = new Button();
            EntryButton = new Button();
            HomeButton = new Button();
            EntryPanel = new Panel();
            ValidTitlesBox = new ComboBox();
            NewEntryTitleText = new TextBox();
            LatestEntryText = new TextBox();
            textBox1 = new TextBox();
            StarButton2 = new Button();
            FilledInEntryButton = new Button();
            HomeButton2 = new Button();
            BackButton = new Button();
            SearchIntBox = new NumericUpDown();
            SearchButton = new Button();
            HomePanel.SuspendLayout();
            EntryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchIntBox).BeginInit();
            SuspendLayout();
            // 
            // HomePanel
            // 
            HomePanel.Controls.Add(AiringScheduleText);
            HomePanel.Controls.Add(StarButton);
            HomePanel.Controls.Add(EntryButton);
            HomePanel.Controls.Add(HomeButton);
            HomePanel.Location = new Point(15, 60);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new Size(776, 375);
            HomePanel.TabIndex = 0;
            HomePanel.Paint += panel1_Paint;
            // 
            // AiringScheduleText
            // 
            AiringScheduleText.BackColor = SystemColors.ActiveCaptionText;
            AiringScheduleText.ForeColor = SystemColors.ActiveCaption;
            AiringScheduleText.Location = new Point(122, 3);
            AiringScheduleText.Multiline = true;
            AiringScheduleText.Name = "AiringScheduleText";
            AiringScheduleText.ReadOnly = true;
            AiringScheduleText.ScrollBars = ScrollBars.Vertical;
            AiringScheduleText.Size = new Size(651, 369);
            AiringScheduleText.TabIndex = 3;
            AiringScheduleText.Text = "Airing Schedule";
            AiringScheduleText.TextAlign = HorizontalAlignment.Center;
            // 
            // StarButton
            // 
            StarButton.FlatAppearance.BorderColor = Color.Black;
            StarButton.FlatStyle = FlatStyle.Flat;
            StarButton.ForeColor = SystemColors.Desktop;
            StarButton.Image = (Image)resources.GetObject("StarButton.Image");
            StarButton.Location = new Point(3, 181);
            StarButton.Name = "StarButton";
            StarButton.Size = new Size(83, 83);
            StarButton.TabIndex = 2;
            StarButton.UseVisualStyleBackColor = true;
            StarButton.Click += StarButton_Click;
            // 
            // EntryButton
            // 
            EntryButton.FlatAppearance.BorderColor = Color.Black;
            EntryButton.FlatStyle = FlatStyle.Flat;
            EntryButton.ForeColor = SystemColors.Desktop;
            EntryButton.Image = (Image)resources.GetObject("EntryButton.Image");
            EntryButton.Location = new Point(0, 92);
            EntryButton.Name = "EntryButton";
            EntryButton.Size = new Size(83, 83);
            EntryButton.TabIndex = 1;
            EntryButton.Text = "Home";
            EntryButton.UseVisualStyleBackColor = true;
            EntryButton.Click += EntryButton_Click;
            // 
            // HomeButton
            // 
            HomeButton.FlatAppearance.BorderColor = Color.Black;
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.ForeColor = SystemColors.Desktop;
            HomeButton.Image = (Image)resources.GetObject("HomeButton.Image");
            HomeButton.Location = new Point(0, 3);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(83, 83);
            HomeButton.TabIndex = 0;
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += button1_Click;
            // 
            // EntryPanel
            // 
            EntryPanel.Controls.Add(ValidTitlesBox);
            EntryPanel.Controls.Add(NewEntryTitleText);
            EntryPanel.Controls.Add(LatestEntryText);
            EntryPanel.Controls.Add(textBox1);
            EntryPanel.Controls.Add(StarButton2);
            EntryPanel.Controls.Add(FilledInEntryButton);
            EntryPanel.Controls.Add(HomeButton2);
            EntryPanel.Location = new Point(15, 60);
            EntryPanel.Name = "EntryPanel";
            EntryPanel.Size = new Size(776, 375);
            EntryPanel.TabIndex = 4;
            // 
            // ValidTitlesBox
            // 
            ValidTitlesBox.BackColor = SystemColors.InactiveCaptionText;
            ValidTitlesBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ValidTitlesBox.FlatStyle = FlatStyle.Popup;
            ValidTitlesBox.ForeColor = SystemColors.Highlight;
            ValidTitlesBox.FormattingEnabled = true;
            ValidTitlesBox.Location = new Point(426, 36);
            ValidTitlesBox.Name = "ValidTitlesBox";
            ValidTitlesBox.Size = new Size(350, 28);
            ValidTitlesBox.TabIndex = 6;
            ValidTitlesBox.SelectedIndexChanged += ValidTitlesBox_SelectedIndexChanged;
            // 
            // NewEntryTitleText
            // 
            NewEntryTitleText.BackColor = SystemColors.ActiveCaptionText;
            NewEntryTitleText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            NewEntryTitleText.ForeColor = SystemColors.HotTrack;
            NewEntryTitleText.Location = new Point(426, 3);
            NewEntryTitleText.Name = "NewEntryTitleText";
            NewEntryTitleText.ReadOnly = true;
            NewEntryTitleText.Size = new Size(350, 32);
            NewEntryTitleText.TabIndex = 5;
            NewEntryTitleText.Text = "New Entry";
            NewEntryTitleText.TextAlign = HorizontalAlignment.Center;
            // 
            // LatestEntryText
            // 
            LatestEntryText.BackColor = SystemColors.InactiveCaptionText;
            LatestEntryText.BorderStyle = BorderStyle.None;
            LatestEntryText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LatestEntryText.ForeColor = SystemColors.HotTrack;
            LatestEntryText.Location = new Point(122, 3);
            LatestEntryText.Multiline = true;
            LatestEntryText.Name = "LatestEntryText";
            LatestEntryText.ReadOnly = true;
            LatestEntryText.ScrollBars = ScrollBars.Vertical;
            LatestEntryText.Size = new Size(306, 369);
            LatestEntryText.TabIndex = 4;
            LatestEntryText.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaptionText;
            textBox1.ForeColor = SystemColors.ActiveCaption;
            textBox1.Location = new Point(426, 65);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(347, 307);
            textBox1.TabIndex = 3;
            textBox1.Text = "Enter text here";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // StarButton2
            // 
            StarButton2.FlatAppearance.BorderColor = Color.Black;
            StarButton2.FlatStyle = FlatStyle.Flat;
            StarButton2.ForeColor = SystemColors.Desktop;
            StarButton2.Image = (Image)resources.GetObject("StarButton2.Image");
            StarButton2.Location = new Point(3, 181);
            StarButton2.Name = "StarButton2";
            StarButton2.Size = new Size(83, 83);
            StarButton2.TabIndex = 2;
            StarButton2.UseVisualStyleBackColor = true;
            // 
            // FilledInEntryButton
            // 
            FilledInEntryButton.FlatAppearance.BorderColor = Color.Black;
            FilledInEntryButton.FlatStyle = FlatStyle.Flat;
            FilledInEntryButton.ForeColor = SystemColors.Desktop;
            FilledInEntryButton.Image = (Image)resources.GetObject("FilledInEntryButton.Image");
            FilledInEntryButton.Location = new Point(0, 92);
            FilledInEntryButton.Name = "FilledInEntryButton";
            FilledInEntryButton.Size = new Size(83, 83);
            FilledInEntryButton.TabIndex = 1;
            FilledInEntryButton.UseVisualStyleBackColor = true;
            // 
            // HomeButton2
            // 
            HomeButton2.FlatAppearance.BorderColor = Color.Black;
            HomeButton2.FlatStyle = FlatStyle.Flat;
            HomeButton2.ForeColor = SystemColors.Desktop;
            HomeButton2.Image = (Image)resources.GetObject("HomeButton2.Image");
            HomeButton2.Location = new Point(0, 3);
            HomeButton2.Name = "HomeButton2";
            HomeButton2.Size = new Size(83, 83);
            HomeButton2.TabIndex = 0;
            HomeButton2.UseVisualStyleBackColor = true;
            HomeButton2.Click += button3_Click;
            // 
            // BackButton
            // 
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.ForeColor = SystemColors.Highlight;
            BackButton.Location = new Point(20, 18);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(42, 29);
            BackButton.TabIndex = 1;
            BackButton.Text = "◀";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // SearchIntBox
            // 
            SearchIntBox.BackColor = SystemColors.InactiveCaptionText;
            SearchIntBox.BorderStyle = BorderStyle.None;
            SearchIntBox.ForeColor = SystemColors.MenuHighlight;
            SearchIntBox.Location = new Point(556, 18);
            SearchIntBox.Name = "SearchIntBox";
            SearchIntBox.Size = new Size(150, 23);
            SearchIntBox.TabIndex = 5;
            // 
            // SearchButton
            // 
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.ForeColor = SystemColors.Highlight;
            SearchButton.Location = new Point(721, 13);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(42, 29);
            SearchButton.TabIndex = 6;
            SearchButton.Text = "🔍";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchButton);
            Controls.Add(SearchIntBox);
            Controls.Add(EntryPanel);
            Controls.Add(HomePanel);
            Controls.Add(BackButton);
            Name = "Form2";
            Text = "Form2";
            HomePanel.ResumeLayout(false);
            HomePanel.PerformLayout();
            EntryPanel.ResumeLayout(false);
            EntryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchIntBox).EndInit();
            ResumeLayout(false);
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
        private Button SearchButton;
        private TextBox LatestEntryText;
        private ComboBox ValidTitlesBox;
        private TextBox NewEntryTitleText;
    }
}