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
            textBox1 = new TextBox();
            AiringScheduleText = new TextBox();
            StarButton = new Button();
            EntryButton = new Button();
            HomeButton = new Button();
            EntryPanel = new Panel();
            ShowImage = new PictureBox();
            SelectButton = new Button();
            ValidTitlesBox = new ComboBox();
            NewEntryTitleText = new TextBox();
            Synopsis = new TextBox();
            StarButton2 = new Button();
            FilledInEntryButton = new Button();
            HomeButton2 = new Button();
            BackButton = new Button();
            SearchIntBox = new NumericUpDown();
            SearchButton = new Button();
            StarPanel = new Panel();
            StarTitle = new TextBox();
            SaveButtonStar = new Button();
            ShowInformationBox = new TextBox();
            StarButtonFilled = new Button();
            EntryButtonEmpty2 = new Button();
            HomeButtonEmpty2 = new Button();
            SaveWarningText = new TextBox();
            label1 = new Label();
            HomePanel.SuspendLayout();
            EntryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ShowImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchIntBox).BeginInit();
            StarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // HomePanel
            // 
            HomePanel.Controls.Add(textBox1);
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
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaptionText;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.RoyalBlue;
            textBox1.Location = new Point(122, 5);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(654, 25);
            textBox1.TabIndex = 11;
            textBox1.Text = "Airing Schedule";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // AiringScheduleText
            // 
            AiringScheduleText.BackColor = SystemColors.ActiveCaptionText;
            AiringScheduleText.BorderStyle = BorderStyle.FixedSingle;
            AiringScheduleText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AiringScheduleText.ForeColor = SystemColors.ButtonShadow;
            AiringScheduleText.Location = new Point(122, 36);
            AiringScheduleText.Multiline = true;
            AiringScheduleText.Name = "AiringScheduleText";
            AiringScheduleText.ReadOnly = true;
            AiringScheduleText.ScrollBars = ScrollBars.Vertical;
            AiringScheduleText.Size = new Size(651, 336);
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
            EntryPanel.Controls.Add(ShowImage);
            EntryPanel.Controls.Add(SelectButton);
            EntryPanel.Controls.Add(ValidTitlesBox);
            EntryPanel.Controls.Add(NewEntryTitleText);
            EntryPanel.Controls.Add(Synopsis);
            EntryPanel.Controls.Add(StarButton2);
            EntryPanel.Controls.Add(FilledInEntryButton);
            EntryPanel.Controls.Add(HomeButton2);
            EntryPanel.Location = new Point(15, 60);
            EntryPanel.Name = "EntryPanel";
            EntryPanel.Size = new Size(776, 375);
            EntryPanel.TabIndex = 4;
            // 
            // ShowImage
            // 
            ShowImage.Image = ParkerTracker.Properties.Resources.baer;
            ShowImage.Location = new Point(105, 3);
            ShowImage.Name = "ShowImage";
            ShowImage.Size = new Size(315, 372);
            ShowImage.TabIndex = 8;
            ShowImage.TabStop = false;
            // 
            // SelectButton
            // 
            SelectButton.BackColor = Color.FromArgb(64, 0, 64);
            SelectButton.Cursor = Cursors.Hand;
            SelectButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            SelectButton.FlatAppearance.BorderSize = 0;
            SelectButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            SelectButton.FlatAppearance.MouseOverBackColor = Color.Silver;
            SelectButton.FlatStyle = FlatStyle.Flat;
            SelectButton.ForeColor = SystemColors.Highlight;
            SelectButton.Location = new Point(541, 343);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(94, 29);
            SelectButton.TabIndex = 7;
            SelectButton.Text = "Select";
            SelectButton.UseVisualStyleBackColor = false;
            SelectButton.Click += SelectButton_Click;
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
            NewEntryTitleText.ForeColor = Color.SandyBrown;
            NewEntryTitleText.Location = new Point(426, 3);
            NewEntryTitleText.Name = "NewEntryTitleText";
            NewEntryTitleText.ReadOnly = true;
            NewEntryTitleText.Size = new Size(350, 27);
            NewEntryTitleText.TabIndex = 5;
            NewEntryTitleText.Text = "Select Show";
            NewEntryTitleText.TextAlign = HorizontalAlignment.Center;
            // 
            // Synopsis
            // 
            Synopsis.BackColor = SystemColors.ActiveCaptionText;
            Synopsis.ForeColor = SystemColors.ControlDark;
            Synopsis.Location = new Point(426, 65);
            Synopsis.Multiline = true;
            Synopsis.Name = "Synopsis";
            Synopsis.ReadOnly = true;
            Synopsis.ScrollBars = ScrollBars.Vertical;
            Synopsis.Size = new Size(350, 277);
            Synopsis.TabIndex = 3;
            Synopsis.TextAlign = HorizontalAlignment.Center;
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
            StarPanel.Controls.Add(StarTitle);
            StarPanel.Controls.Add(SaveButtonStar);
            StarPanel.Controls.Add(ShowInformationBox);
            StarPanel.Controls.Add(StarButtonFilled);
            StarPanel.Controls.Add(EntryButtonEmpty2);
            StarPanel.Controls.Add(HomeButtonEmpty2);
            StarPanel.Controls.Add(SaveWarningText);
            StarPanel.Location = new Point(15, 60);
            StarPanel.Name = "StarPanel";
            StarPanel.Size = new Size(776, 375);
            StarPanel.TabIndex = 4;
            // 
            // StarTitle
            // 
            StarTitle.BackColor = SystemColors.InactiveCaptionText;
            StarTitle.BorderStyle = BorderStyle.None;
            StarTitle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StarTitle.ForeColor = Color.RoyalBlue;
            StarTitle.Location = new Point(122, 3);
            StarTitle.Name = "StarTitle";
            StarTitle.ReadOnly = true;
            StarTitle.Size = new Size(654, 25);
            StarTitle.TabIndex = 10;
            StarTitle.TextAlign = HorizontalAlignment.Center;
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
            // ShowInformationBox
            // 
            ShowInformationBox.BackColor = SystemColors.ActiveCaptionText;
            ShowInformationBox.ForeColor = SystemColors.ButtonShadow;
            ShowInformationBox.Location = new Point(122, 36);
            ShowInformationBox.Multiline = true;
            ShowInformationBox.Name = "ShowInformationBox";
            ShowInformationBox.ReadOnly = true;
            ShowInformationBox.ScrollBars = ScrollBars.Vertical;
            ShowInformationBox.Size = new Size(651, 306);
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
            // SaveWarningText
            // 
            SaveWarningText.BackColor = SystemColors.InactiveCaptionText;
            SaveWarningText.BorderStyle = BorderStyle.None;
            SaveWarningText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SaveWarningText.ForeColor = Color.Purple;
            SaveWarningText.Location = new Point(510, 341);
            SaveWarningText.Name = "SaveWarningText";
            SaveWarningText.ReadOnly = true;
            SaveWarningText.Size = new Size(263, 27);
            SaveWarningText.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.SlateBlue;
            label1.Location = new Point(137, 18);
            label1.Name = "label1";
            label1.Size = new Size(227, 37);
            label1.TabIndex = 7;
            label1.Text = "Parker Tracker";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(SearchButton);
            Controls.Add(SearchIntBox);
            Controls.Add(EntryPanel);
            Controls.Add(HomePanel);
            Controls.Add(StarPanel);
            Controls.Add(BackButton);
            Name = "Form2";
            Text = "Form2";
            HomePanel.ResumeLayout(false);
            HomePanel.PerformLayout();
            EntryPanel.ResumeLayout(false);
            EntryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ShowImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchIntBox).EndInit();
            StarPanel.ResumeLayout(false);
            StarPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel HomePanel;
        private Button HomeButton;
        private Button StarButton;
        private Button EntryButton;
        private TextBox AiringScheduleText;
        private Panel EntryPanel;
        private TextBox Synopsis;
        private Button StarButton2;
        private Button FilledInEntryButton;
        private Button HomeButton2;
        private Button BackButton;
        private NumericUpDown SearchIntBox;
        private Button SearchButton;
        private ComboBox ValidTitlesBox;
        private TextBox NewEntryTitleText;
        private Panel StarPanel;
        private TextBox ShowInformationBox;
        private Button StarButtonFilled;
        private Button EntryButtonEmpty2;
        private Button HomeButtonEmpty2;
        private Button SelectButton;
        private Button SaveButtonStar;
        private TextBox SaveWarningText;
        private PictureBox ShowImage;
        private TextBox StarTitle;
        private TextBox textBox1;
        private Label label1;
    }
}