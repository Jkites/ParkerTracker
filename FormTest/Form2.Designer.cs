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
            HomePanel = new Panel();
            AiringScheduleText = new TextBox();
            StarButton = new Button();
            EntryButton = new Button();
            HomeButton = new Button();
            EntryPanel = new Panel();
            SaveButtonEntry = new Button();
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
            StarPanel = new Panel();
            SaveButtonStar = new Button();
            SearchValidShowBox = new ComboBox();
            ShowInformationBox = new TextBox();
            StarButtonFilled = new Button();
            EntryButtonEmpty2 = new Button();
            HomeButtonEmpty2 = new Button();
            HomePanel.SuspendLayout();
            EntryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchIntBox).BeginInit();
            StarPanel.SuspendLayout();
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
            AiringScheduleText.BorderStyle = BorderStyle.FixedSingle;
            AiringScheduleText.ForeColor = SystemColors.ButtonShadow;
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
            StarButton.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            StarButton.ForeColor = SystemColors.Highlight;
            StarButton.Location = new Point(3, 181);
            StarButton.Name = "StarButton";
            StarButton.Size = new Size(83, 83);
            StarButton.TabIndex = 2;
            StarButton.Text = "☆";
            StarButton.UseVisualStyleBackColor = true;
            StarButton.Click += StarButton_Click;
            // 
            // EntryButton
            // 
            EntryButton.FlatAppearance.BorderColor = Color.Black;
            EntryButton.FlatStyle = FlatStyle.Flat;
            EntryButton.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            EntryButton.ForeColor = SystemColors.Highlight;
            EntryButton.Location = new Point(0, 92);
            EntryButton.Name = "EntryButton";
            EntryButton.Size = new Size(83, 83);
            EntryButton.TabIndex = 1;
            EntryButton.Text = "💬︎";
            EntryButton.UseVisualStyleBackColor = true;
            EntryButton.Click += EntryButton_Click;
            // 
            // HomeButton
            // 
            HomeButton.FlatAppearance.BorderColor = Color.Black;
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            HomeButton.ForeColor = SystemColors.ActiveBorder;
            HomeButton.Location = new Point(0, 3);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(83, 83);
            HomeButton.TabIndex = 0;
            HomeButton.Text = "🏠";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += button1_Click;
            // 
            // EntryPanel
            // 
            EntryPanel.Controls.Add(SaveButtonEntry);
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
            // SaveButtonEntry
            // 
            SaveButtonEntry.BackColor = Color.FromArgb(64, 0, 64);
            SaveButtonEntry.Cursor = Cursors.Hand;
            SaveButtonEntry.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            SaveButtonEntry.FlatAppearance.BorderSize = 0;
            SaveButtonEntry.FlatAppearance.MouseDownBackColor = Color.Silver;
            SaveButtonEntry.FlatAppearance.MouseOverBackColor = Color.Silver;
            SaveButtonEntry.FlatStyle = FlatStyle.Flat;
            SaveButtonEntry.ForeColor = SystemColors.Highlight;
            SaveButtonEntry.Location = new Point(541, 343);
            SaveButtonEntry.Name = "SaveButtonEntry";
            SaveButtonEntry.Size = new Size(94, 29);
            SaveButtonEntry.TabIndex = 7;
            SaveButtonEntry.Text = "Save";
            SaveButtonEntry.UseVisualStyleBackColor = false;
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
            NewEntryTitleText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NewEntryTitleText.ForeColor = SystemColors.ControlDark;
            NewEntryTitleText.Location = new Point(426, 3);
            NewEntryTitleText.Name = "NewEntryTitleText";
            NewEntryTitleText.ReadOnly = true;
            NewEntryTitleText.Size = new Size(350, 27);
            NewEntryTitleText.TabIndex = 5;
            NewEntryTitleText.Text = "New Entry";
            NewEntryTitleText.TextAlign = HorizontalAlignment.Center;
            // 
            // LatestEntryText
            // 
            LatestEntryText.BackColor = SystemColors.InactiveCaptionText;
            LatestEntryText.BorderStyle = BorderStyle.FixedSingle;
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
            textBox1.ForeColor = SystemColors.ControlDark;
            textBox1.Location = new Point(426, 65);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(350, 277);
            textBox1.TabIndex = 3;
            textBox1.Text = "Enter text here";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // StarButton2
            // 
            StarButton2.FlatAppearance.BorderColor = Color.Black;
            StarButton2.FlatStyle = FlatStyle.Flat;
            StarButton2.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            StarButton2.ForeColor = SystemColors.Highlight;
            StarButton2.Location = new Point(3, 181);
            StarButton2.Name = "StarButton2";
            StarButton2.Size = new Size(83, 83);
            StarButton2.TabIndex = 2;
            StarButton2.Text = "☆";
            StarButton2.UseVisualStyleBackColor = true;
            StarButton2.Click += StarButton2_Click;
            // 
            // FilledInEntryButton
            // 
            FilledInEntryButton.FlatAppearance.BorderColor = Color.Black;
            FilledInEntryButton.FlatStyle = FlatStyle.Flat;
            FilledInEntryButton.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            FilledInEntryButton.ForeColor = SystemColors.ActiveBorder;
            FilledInEntryButton.Location = new Point(0, 92);
            FilledInEntryButton.Name = "FilledInEntryButton";
            FilledInEntryButton.Size = new Size(83, 83);
            FilledInEntryButton.TabIndex = 1;
            FilledInEntryButton.Text = "💬︎";
            FilledInEntryButton.UseVisualStyleBackColor = true;
            // 
            // HomeButton2
            // 
            HomeButton2.FlatAppearance.BorderColor = Color.Black;
            HomeButton2.FlatStyle = FlatStyle.Flat;
            HomeButton2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            HomeButton2.ForeColor = SystemColors.Highlight;
            HomeButton2.Location = new Point(0, 3);
            HomeButton2.Name = "HomeButton2";
            HomeButton2.Size = new Size(83, 83);
            HomeButton2.TabIndex = 0;
            HomeButton2.Text = "🏠";
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
            SearchIntBox.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            SearchIntBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            SearchIntBox.Name = "SearchIntBox";
            SearchIntBox.Size = new Size(150, 23);
            SearchIntBox.TabIndex = 5;
            SearchIntBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
            // StarPanel
            // 
            StarPanel.Controls.Add(SaveButtonStar);
            StarPanel.Controls.Add(SearchValidShowBox);
            StarPanel.Controls.Add(ShowInformationBox);
            StarPanel.Controls.Add(StarButtonFilled);
            StarPanel.Controls.Add(EntryButtonEmpty2);
            StarPanel.Controls.Add(HomeButtonEmpty2);
            StarPanel.Location = new Point(15, 60);
            StarPanel.Name = "StarPanel";
            StarPanel.Size = new Size(776, 375);
            StarPanel.TabIndex = 4;
            // 
            // SaveButtonStar
            // 
            SaveButtonStar.BackColor = Color.FromArgb(64, 0, 64);
            SaveButtonStar.Cursor = Cursors.Hand;
            SaveButtonStar.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            SaveButtonStar.FlatAppearance.BorderSize = 0;
            SaveButtonStar.FlatAppearance.MouseDownBackColor = Color.Silver;
            SaveButtonStar.FlatAppearance.MouseOverBackColor = Color.Silver;
            SaveButtonStar.FlatStyle = FlatStyle.Flat;
            SaveButtonStar.ForeColor = SystemColors.Highlight;
            SaveButtonStar.Location = new Point(398, 343);
            SaveButtonStar.Name = "SaveButtonStar";
            SaveButtonStar.Size = new Size(94, 29);
            SaveButtonStar.TabIndex = 8;
            SaveButtonStar.Text = "Save";
            SaveButtonStar.UseVisualStyleBackColor = false;
            SaveButtonStar.Click += SaveButtonStar_Click;
            // 
            // SearchValidShowBox
            // 
            SearchValidShowBox.BackColor = SystemColors.InactiveCaptionText;
            SearchValidShowBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SearchValidShowBox.FlatStyle = FlatStyle.Popup;
            SearchValidShowBox.ForeColor = SystemColors.Highlight;
            SearchValidShowBox.FormattingEnabled = true;
            SearchValidShowBox.Location = new Point(122, 7);
            SearchValidShowBox.Name = "SearchValidShowBox";
            SearchValidShowBox.Size = new Size(651, 28);
            SearchValidShowBox.TabIndex = 7;
            // 
            // ShowInformationBox
            // 
            ShowInformationBox.BackColor = SystemColors.ActiveCaptionText;
            ShowInformationBox.ForeColor = SystemColors.ButtonShadow;
            ShowInformationBox.Location = new Point(122, 41);
            ShowInformationBox.Multiline = true;
            ShowInformationBox.Name = "ShowInformationBox";
            ShowInformationBox.ReadOnly = true;
            ShowInformationBox.ScrollBars = ScrollBars.Vertical;
            ShowInformationBox.Size = new Size(651, 301);
            ShowInformationBox.TabIndex = 3;
            ShowInformationBox.Text = "Show Name - ID";
            ShowInformationBox.TextAlign = HorizontalAlignment.Center;
            // 
            // StarButtonFilled
            // 
            StarButtonFilled.FlatAppearance.BorderColor = Color.Black;
            StarButtonFilled.FlatStyle = FlatStyle.Flat;
            StarButtonFilled.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            StarButtonFilled.ForeColor = SystemColors.ActiveBorder;
            StarButtonFilled.Location = new Point(3, 181);
            StarButtonFilled.Name = "StarButtonFilled";
            StarButtonFilled.Size = new Size(83, 83);
            StarButtonFilled.TabIndex = 2;
            StarButtonFilled.Text = "☆";
            StarButtonFilled.UseVisualStyleBackColor = true;
            // 
            // EntryButtonEmpty2
            // 
            EntryButtonEmpty2.FlatAppearance.BorderColor = Color.Black;
            EntryButtonEmpty2.FlatStyle = FlatStyle.Flat;
            EntryButtonEmpty2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            EntryButtonEmpty2.ForeColor = SystemColors.Highlight;
            EntryButtonEmpty2.Location = new Point(0, 92);
            EntryButtonEmpty2.Name = "EntryButtonEmpty2";
            EntryButtonEmpty2.Size = new Size(83, 83);
            EntryButtonEmpty2.TabIndex = 1;
            EntryButtonEmpty2.Text = "💬︎";
            EntryButtonEmpty2.UseVisualStyleBackColor = true;
            EntryButtonEmpty2.Click += EntryButtonEmpty2_Click;
            // 
            // HomeButtonEmpty2
            // 
            HomeButtonEmpty2.FlatAppearance.BorderColor = Color.Black;
            HomeButtonEmpty2.FlatStyle = FlatStyle.Flat;
            HomeButtonEmpty2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            HomeButtonEmpty2.ForeColor = SystemColors.Highlight;
            HomeButtonEmpty2.Location = new Point(0, 3);
            HomeButtonEmpty2.Name = "HomeButtonEmpty2";
            HomeButtonEmpty2.Size = new Size(83, 83);
            HomeButtonEmpty2.TabIndex = 0;
            HomeButtonEmpty2.Text = "🏠";
            HomeButtonEmpty2.UseVisualStyleBackColor = true;
            HomeButtonEmpty2.Click += HomeButtonEmpty2_Click;
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
            Controls.Add(StarPanel);
            Controls.Add(HomePanel);
            Controls.Add(BackButton);
            Name = "Form2";
            Text = "Form2";
            HomePanel.ResumeLayout(false);
            HomePanel.PerformLayout();
            EntryPanel.ResumeLayout(false);
            EntryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchIntBox).EndInit();
            StarPanel.ResumeLayout(false);
            StarPanel.PerformLayout();
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
        private Panel StarPanel;
        private ComboBox SearchValidShowBox;
        private TextBox ShowInformationBox;
        private Button StarButtonFilled;
        private Button EntryButtonEmpty2;
        private Button HomeButtonEmpty2;
        private Button SaveButtonEntry;
        private Button SaveButtonStar;
    }
}