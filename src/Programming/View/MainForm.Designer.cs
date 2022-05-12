namespace Programming.View
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
            this.EnumPage = new System.Windows.Forms.TabPage();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.OutLabel = new System.Windows.Forms.Label();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectangleTabPage = new System.Windows.Forms.TabPage();
            this.seasonHandleControl = new Programming.View.Controls.SeasonHandleControl();
            this.weekdayParsingControl = new Programming.View.Controls.WeekdayParsingControl();
            this.enumerationControl = new Programming.View.Controls.EnumerationControl();
            this.moviesControl1 = new Programming.View.Controls.MoviesControl();
            this.rectanglesControl1 = new Programming.View.Controls.RectanglesControl();
            this.rectangleCollisionControl1 = new Programming.View.Controls.RectangleCollisionControl();
            this.EnumPage.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.MoviesGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.RectangleTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumPage
            // 
            this.EnumPage.Controls.Add(this.SeasonHandleGroupBox);
            this.EnumPage.Controls.Add(this.WeekdayParsingGroupBox);
            this.EnumPage.Controls.Add(this.EnumerationsGroupBox);
            this.EnumPage.Location = new System.Drawing.Point(4, 25);
            this.EnumPage.Margin = new System.Windows.Forms.Padding(4);
            this.EnumPage.Name = "EnumPage";
            this.EnumPage.Padding = new System.Windows.Forms.Padding(4);
            this.EnumPage.Size = new System.Drawing.Size(853, 721);
            this.EnumPage.TabIndex = 0;
            this.EnumPage.Text = "Enums";
            this.EnumPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonHandleGroupBox.Controls.Add(this.seasonHandleControl);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(424, 443);
            this.SeasonHandleGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(418, 265);
            this.SeasonHandleGroupBox.TabIndex = 2;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekdayParsingGroupBox.Controls.Add(this.weekdayParsingControl);
            this.WeekdayParsingGroupBox.Controls.Add(this.OutLabel);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(4, 443);
            this.WeekdayParsingGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(426, 265);
            this.WeekdayParsingGroupBox.TabIndex = 1;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // OutLabel
            // 
            this.OutLabel.AutoSize = true;
            this.OutLabel.Location = new System.Drawing.Point(8, 112);
            this.OutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutLabel.Name = "OutLabel";
            this.OutLabel.Size = new System.Drawing.Size(0, 16);
            this.OutLabel.TabIndex = 3;
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnumerationsGroupBox.Controls.Add(this.enumerationControl);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(11, 4);
            this.EnumerationsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(838, 431);
            this.EnumerationsGroupBox.TabIndex = 0;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnumPage);
            this.TabControl.Controls.Add(this.ClassesTabPage);
            this.TabControl.Controls.Add(this.RectangleTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(861, 750);
            this.TabControl.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.MoviesGroupBox);
            this.ClassesTabPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 25);
            this.ClassesTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.ClassesTabPage.Size = new System.Drawing.Size(853, 721);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviesGroupBox.Controls.Add(this.moviesControl1);
            this.MoviesGroupBox.Location = new System.Drawing.Point(436, 4);
            this.MoviesGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoviesGroupBox.Size = new System.Drawing.Size(413, 704);
            this.MoviesGroupBox.TabIndex = 1;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RectanglesGroupBox.Controls.Add(this.rectanglesControl1);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(4, 4);
            this.RectanglesGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesGroupBox.Size = new System.Drawing.Size(412, 704);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // RectangleTabPage
            // 
            this.RectangleTabPage.Controls.Add(this.rectangleCollisionControl1);
            this.RectangleTabPage.Location = new System.Drawing.Point(4, 25);
            this.RectangleTabPage.Name = "RectangleTabPage";
            this.RectangleTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectangleTabPage.Size = new System.Drawing.Size(853, 721);
            this.RectangleTabPage.TabIndex = 2;
            this.RectangleTabPage.Text = "Rectangles";
            this.RectangleTabPage.UseVisualStyleBackColor = true;
            // 
            // seasonHandleControl
            // 
            this.seasonHandleControl.Location = new System.Drawing.Point(7, 22);
            this.seasonHandleControl.Name = "seasonHandleControl";
            this.seasonHandleControl.Size = new System.Drawing.Size(345, 53);
            this.seasonHandleControl.TabIndex = 0;
            // 
            // weekdayParsingControl
            // 
            this.weekdayParsingControl.Location = new System.Drawing.Point(7, 22);
            this.weekdayParsingControl.Name = "weekdayParsingControl";
            this.weekdayParsingControl.Size = new System.Drawing.Size(374, 96);
            this.weekdayParsingControl.TabIndex = 4;
            // 
            // enumerationControl
            // 
            this.enumerationControl.Location = new System.Drawing.Point(7, 22);
            this.enumerationControl.Name = "enumerationControl";
            this.enumerationControl.Size = new System.Drawing.Size(576, 353);
            this.enumerationControl.TabIndex = 0;
            // 
            // moviesControl1
            // 
            this.moviesControl1.Location = new System.Drawing.Point(0, 25);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(366, 336);
            this.moviesControl1.TabIndex = 0;
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Location = new System.Drawing.Point(6, 21);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(371, 340);
            this.rectanglesControl1.TabIndex = 0;
            // 
            // rectangleCollisionControl1
            // 
            this.rectangleCollisionControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleCollisionControl1.Location = new System.Drawing.Point(3, 3);
            this.rectangleCollisionControl1.Name = "rectangleCollisionControl1";
            this.rectangleCollisionControl1.Size = new System.Drawing.Size(837, 722);
            this.rectangleCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(861, 750);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming demo";
            this.EnumPage.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.MoviesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectangleTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage EnumPage;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.Label OutLabel;
        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.TabPage RectangleTabPage;
        private System.Windows.Forms.GroupBox EnumerationsGroupBox;
        private Controls.SeasonHandleControl seasonHandleControl;
        private Controls.WeekdayParsingControl weekdayParsingControl;
        private Controls.EnumerationControl enumerationControl;
        private Controls.RectanglesControl rectanglesControl1;
        private Controls.MoviesControl moviesControl1;
        private Controls.RectangleCollisionControl rectangleCollisionControl1;
    }
}

