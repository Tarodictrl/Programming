namespace Programming.View.Controls
{
    partial class RectanglesControl
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
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // IdTextBox
            // 
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Location = new System.Drawing.Point(196, 270);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(157, 22);
            this.IdTextBox.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Id:";
            // 
            // YTextBox
            // 
            this.YTextBox.Enabled = false;
            this.YTextBox.Location = new System.Drawing.Point(199, 220);
            this.YTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.ReadOnly = true;
            this.YTextBox.Size = new System.Drawing.Size(157, 22);
            this.YTextBox.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Y:";
            // 
            // XTextBox
            // 
            this.XTextBox.Enabled = false;
            this.XTextBox.Location = new System.Drawing.Point(199, 170);
            this.XTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.ReadOnly = true;
            this.XTextBox.Size = new System.Drawing.Size(157, 22);
            this.XTextBox.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "X:";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(199, 303);
            this.FindButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(140, 25);
            this.FindButton.TabIndex = 21;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(199, 120);
            this.ColorTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(157, 22);
            this.ColorTextBox.TabIndex = 20;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(196, 102);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(42, 16);
            this.ColorLabel.TabIndex = 19;
            this.ColorLabel.Text = "Color:";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(199, 70);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(157, 22);
            this.WidthTextBox.TabIndex = 18;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(196, 52);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(44, 16);
            this.WidthLabel.TabIndex = 17;
            this.WidthLabel.Text = "Width:";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(199, 20);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(157, 22);
            this.HeightTextBox.TabIndex = 16;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(196, 2);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(49, 16);
            this.HeightLabel.TabIndex = 15;
            this.HeightLabel.Text = "Height:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 16;
            this.RectanglesListBox.Location = new System.Drawing.Point(3, 2);
            this.RectanglesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(187, 324);
            this.RectanglesListBox.TabIndex = 14;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.RectanglesListBox);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(371, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.ListBox RectanglesListBox;
    }
}
