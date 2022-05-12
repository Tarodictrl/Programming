namespace Programming.View.Controls
{
    partial class MoviesControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.FindMoviesButton = new System.Windows.Forms.Button();
            this.ReleaseYearTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseYearLabel = new System.Windows.Forms.Label();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(199, 220);
            this.RatingTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(157, 22);
            this.RatingTextBox.TabIndex = 23;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(196, 202);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(49, 16);
            this.RatingLabel.TabIndex = 22;
            this.RatingLabel.Text = "Rating:";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(199, 170);
            this.GenreTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(157, 22);
            this.GenreTextBox.TabIndex = 21;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(196, 152);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(47, 16);
            this.GenreLabel.TabIndex = 20;
            this.GenreLabel.Text = "Genre:";
            // 
            // FindMoviesButton
            // 
            this.FindMoviesButton.Location = new System.Drawing.Point(199, 303);
            this.FindMoviesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindMoviesButton.Name = "FindMoviesButton";
            this.FindMoviesButton.Size = new System.Drawing.Size(140, 25);
            this.FindMoviesButton.TabIndex = 19;
            this.FindMoviesButton.Text = "Find";
            this.FindMoviesButton.UseVisualStyleBackColor = true;
            this.FindMoviesButton.Click += new System.EventHandler(this.FindMoviesButton_Click);
            // 
            // ReleaseYearTextBox
            // 
            this.ReleaseYearTextBox.Location = new System.Drawing.Point(199, 120);
            this.ReleaseYearTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            this.ReleaseYearTextBox.Size = new System.Drawing.Size(157, 22);
            this.ReleaseYearTextBox.TabIndex = 18;
            this.ReleaseYearTextBox.TextChanged += new System.EventHandler(this.ReleaseYearTextBox_TextChanged);
            // 
            // ReleaseYearLabel
            // 
            this.ReleaseYearLabel.AutoSize = true;
            this.ReleaseYearLabel.Location = new System.Drawing.Point(196, 102);
            this.ReleaseYearLabel.Name = "ReleaseYearLabel";
            this.ReleaseYearLabel.Size = new System.Drawing.Size(91, 16);
            this.ReleaseYearLabel.TabIndex = 17;
            this.ReleaseYearLabel.Text = "ReleaseYear:";
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(199, 70);
            this.DurationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(157, 22);
            this.DurationTextBox.TabIndex = 16;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(196, 52);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(60, 16);
            this.DurationLabel.TabIndex = 15;
            this.DurationLabel.Text = "Duration:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(199, 20);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(157, 22);
            this.TitleTextBox.TabIndex = 14;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(196, 2);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(36, 16);
            this.TitleLabel.TabIndex = 13;
            this.TitleLabel.Text = "Title:";
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 16;
            this.MoviesListBox.Location = new System.Drawing.Point(3, 2);
            this.MoviesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(187, 324);
            this.MoviesListBox.TabIndex = 12;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RatingTextBox);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.FindMoviesButton);
            this.Controls.Add(this.ReleaseYearTextBox);
            this.Controls.Add(this.ReleaseYearLabel);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.MoviesListBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(366, 336);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Button FindMoviesButton;
        private System.Windows.Forms.TextBox ReleaseYearTextBox;
        private System.Windows.Forms.Label ReleaseYearLabel;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListBox MoviesListBox;
    }
}
