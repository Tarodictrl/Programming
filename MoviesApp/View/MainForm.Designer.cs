namespace MoviesApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.MovieGroupBox = new System.Windows.Forms.GroupBox();
            this.MovieDurationTextBox = new System.Windows.Forms.TextBox();
            this.MovieDurationLabel = new System.Windows.Forms.Label();
            this.MovieGenreComboBox = new System.Windows.Forms.ComboBox();
            this.MovieRatingTextBox = new System.Windows.Forms.TextBox();
            this.MovieReleaseYearTextBox = new System.Windows.Forms.TextBox();
            this.MovieNameTextBox = new System.Windows.Forms.TextBox();
            this.MovieRatingLabel = new System.Windows.Forms.Label();
            this.MovieGenreLabel = new System.Windows.Forms.Label();
            this.MovieReleaseYearLabel = new System.Windows.Forms.Label();
            this.MovieNameLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.MovieGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 16;
            this.MoviesListBox.Location = new System.Drawing.Point(9, 58);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(230, 404);
            this.MoviesListBox.TabIndex = 0;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.Transparent;
            this.RemoveButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.RemoveButton.FlatAppearance.BorderSize = 0;
            this.RemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.RemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.ForeColor = System.Drawing.Color.Transparent;
            this.RemoveButton.Image = global::MoviesApp.Properties.Resources.cross_circle_24x24;
            this.RemoveButton.Location = new System.Drawing.Point(67, 464);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(52, 52);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            this.RemoveButton.MouseEnter += new System.EventHandler(this.RemoveButton_MouseEnter);
            this.RemoveButton.MouseLeave += new System.EventHandler(this.RemoveButton_MouseLeave);
            // 
            // MovieGroupBox
            // 
            this.MovieGroupBox.Controls.Add(this.MovieDurationTextBox);
            this.MovieGroupBox.Controls.Add(this.MovieDurationLabel);
            this.MovieGroupBox.Controls.Add(this.MovieGenreComboBox);
            this.MovieGroupBox.Controls.Add(this.MovieRatingTextBox);
            this.MovieGroupBox.Controls.Add(this.MovieReleaseYearTextBox);
            this.MovieGroupBox.Controls.Add(this.MovieNameTextBox);
            this.MovieGroupBox.Controls.Add(this.MovieRatingLabel);
            this.MovieGroupBox.Controls.Add(this.MovieGenreLabel);
            this.MovieGroupBox.Controls.Add(this.MovieReleaseYearLabel);
            this.MovieGroupBox.Controls.Add(this.MovieNameLabel);
            this.MovieGroupBox.Location = new System.Drawing.Point(254, 58);
            this.MovieGroupBox.Name = "MovieGroupBox";
            this.MovieGroupBox.Size = new System.Drawing.Size(375, 264);
            this.MovieGroupBox.TabIndex = 4;
            this.MovieGroupBox.TabStop = false;
            this.MovieGroupBox.Text = "Selected Movie";
            // 
            // MovieDurationTextBox
            // 
            this.MovieDurationTextBox.Location = new System.Drawing.Point(104, 148);
            this.MovieDurationTextBox.Name = "MovieDurationTextBox";
            this.MovieDurationTextBox.Size = new System.Drawing.Size(116, 22);
            this.MovieDurationTextBox.TabIndex = 29;
            this.MovieDurationTextBox.TextChanged += new System.EventHandler(this.MovieDurationTextBox_TextChanged);
            // 
            // MovieDurationLabel
            // 
            this.MovieDurationLabel.AutoSize = true;
            this.MovieDurationLabel.Location = new System.Drawing.Point(38, 148);
            this.MovieDurationLabel.Name = "MovieDurationLabel";
            this.MovieDurationLabel.Size = new System.Drawing.Size(60, 16);
            this.MovieDurationLabel.TabIndex = 28;
            this.MovieDurationLabel.Text = "Duration:";
            // 
            // MovieGenreComboBox
            // 
            this.MovieGenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MovieGenreComboBox.FormattingEnabled = true;
            this.MovieGenreComboBox.Location = new System.Drawing.Point(104, 87);
            this.MovieGenreComboBox.Name = "MovieGenreComboBox";
            this.MovieGenreComboBox.Size = new System.Drawing.Size(116, 24);
            this.MovieGenreComboBox.TabIndex = 27;
            this.MovieGenreComboBox.SelectedIndexChanged += new System.EventHandler(this.MovieGenreComboBox_SelectedIndexChanged);
            // 
            // MovieRatingTextBox
            // 
            this.MovieRatingTextBox.Location = new System.Drawing.Point(104, 119);
            this.MovieRatingTextBox.Name = "MovieRatingTextBox";
            this.MovieRatingTextBox.Size = new System.Drawing.Size(116, 22);
            this.MovieRatingTextBox.TabIndex = 26;
            this.MovieRatingTextBox.TextChanged += new System.EventHandler(this.MovieRatingTextBox_TextChanged);
            // 
            // MovieReleaseYearTextBox
            // 
            this.MovieReleaseYearTextBox.Location = new System.Drawing.Point(104, 59);
            this.MovieReleaseYearTextBox.Name = "MovieReleaseYearTextBox";
            this.MovieReleaseYearTextBox.Size = new System.Drawing.Size(116, 22);
            this.MovieReleaseYearTextBox.TabIndex = 25;
            this.MovieReleaseYearTextBox.TextChanged += new System.EventHandler(this.MovieReleaseYearTextBox_TextChanged);
            // 
            // MovieNameTextBox
            // 
            this.MovieNameTextBox.Location = new System.Drawing.Point(104, 29);
            this.MovieNameTextBox.Name = "MovieNameTextBox";
            this.MovieNameTextBox.Size = new System.Drawing.Size(255, 22);
            this.MovieNameTextBox.TabIndex = 24;
            this.MovieNameTextBox.TextChanged += new System.EventHandler(this.MovieNameTextBox_TextChanged);
            // 
            // MovieRatingLabel
            // 
            this.MovieRatingLabel.AutoSize = true;
            this.MovieRatingLabel.Location = new System.Drawing.Point(49, 119);
            this.MovieRatingLabel.Name = "MovieRatingLabel";
            this.MovieRatingLabel.Size = new System.Drawing.Size(49, 16);
            this.MovieRatingLabel.TabIndex = 23;
            this.MovieRatingLabel.Text = "Rating:";
            // 
            // MovieGenreLabel
            // 
            this.MovieGenreLabel.AutoSize = true;
            this.MovieGenreLabel.Location = new System.Drawing.Point(51, 87);
            this.MovieGenreLabel.Name = "MovieGenreLabel";
            this.MovieGenreLabel.Size = new System.Drawing.Size(47, 16);
            this.MovieGenreLabel.TabIndex = 22;
            this.MovieGenreLabel.Text = "Genre:";
            // 
            // MovieReleaseYearLabel
            // 
            this.MovieReleaseYearLabel.AutoSize = true;
            this.MovieReleaseYearLabel.Location = new System.Drawing.Point(7, 59);
            this.MovieReleaseYearLabel.Name = "MovieReleaseYearLabel";
            this.MovieReleaseYearLabel.Size = new System.Drawing.Size(91, 16);
            this.MovieReleaseYearLabel.TabIndex = 21;
            this.MovieReleaseYearLabel.Text = "ReleaseYear:";
            // 
            // MovieNameLabel
            // 
            this.MovieNameLabel.AutoSize = true;
            this.MovieNameLabel.Location = new System.Drawing.Point(51, 29);
            this.MovieNameLabel.Name = "MovieNameLabel";
            this.MovieNameLabel.Size = new System.Drawing.Size(47, 16);
            this.MovieNameLabel.TabIndex = 20;
            this.MovieNameLabel.Text = "Name:";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.Color.Transparent;
            this.AddButton.Image = global::MoviesApp.Properties.Resources.add_24x24;
            this.AddButton.Location = new System.Drawing.Point(9, 464);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(52, 52);
            this.AddButton.TabIndex = 1;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseEnter += new System.EventHandler(this.AddButton_MouseEnter);
            this.AddButton.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(67, 9);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(172, 22);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(8, 12);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(53, 16);
            this.SearchLabel.TabIndex = 6;
            this.SearchLabel.Text = "Search:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 521);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.MovieGroupBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MoviesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::MoviesApp.Properties.Resources.icon;
            this.Name = "MainForm";
            this.Text = "MoviesApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.MovieGroupBox.ResumeLayout(false);
            this.MovieGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.GroupBox MovieGroupBox;
        private System.Windows.Forms.TextBox MovieDurationTextBox;
        private System.Windows.Forms.Label MovieDurationLabel;
        private System.Windows.Forms.ComboBox MovieGenreComboBox;
        private System.Windows.Forms.TextBox MovieRatingTextBox;
        private System.Windows.Forms.TextBox MovieReleaseYearTextBox;
        private System.Windows.Forms.TextBox MovieNameTextBox;
        private System.Windows.Forms.Label MovieRatingLabel;
        private System.Windows.Forms.Label MovieGenreLabel;
        private System.Windows.Forms.Label MovieReleaseYearLabel;
        private System.Windows.Forms.Label MovieNameLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
    }
}

