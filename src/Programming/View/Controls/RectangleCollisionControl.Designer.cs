namespace Programming.View.Controls
{
    partial class RectangleCollisionControl
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
            this.HeightRectangleTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.WidthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.YRectangleTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.XRectangleTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.IdRectangleTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.RemoveRectangleButton = new System.Windows.Forms.Button();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.AddingRectanglesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // HeightRectangleTextBox
            // 
            this.HeightRectangleTextBox.Location = new System.Drawing.Point(69, 413);
            this.HeightRectangleTextBox.Name = "HeightRectangleTextBox";
            this.HeightRectangleTextBox.Size = new System.Drawing.Size(115, 22);
            this.HeightRectangleTextBox.TabIndex = 29;
            this.HeightRectangleTextBox.TextChanged += new System.EventHandler(this.HeightRectangleTextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 416);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "Height:";
            // 
            // WidthRectangleTextBox
            // 
            this.WidthRectangleTextBox.Location = new System.Drawing.Point(69, 385);
            this.WidthRectangleTextBox.Name = "WidthRectangleTextBox";
            this.WidthRectangleTextBox.Size = new System.Drawing.Size(115, 22);
            this.WidthRectangleTextBox.TabIndex = 27;
            this.WidthRectangleTextBox.TextChanged += new System.EventHandler(this.WidthRectangleTextBox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 388);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "Width:";
            // 
            // YRectangleTextBox
            // 
            this.YRectangleTextBox.Location = new System.Drawing.Point(69, 357);
            this.YRectangleTextBox.Name = "YRectangleTextBox";
            this.YRectangleTextBox.Size = new System.Drawing.Size(115, 22);
            this.YRectangleTextBox.TabIndex = 25;
            this.YRectangleTextBox.TextChanged += new System.EventHandler(this.YRectangleTextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Y:";
            // 
            // XRectangleTextBox
            // 
            this.XRectangleTextBox.Location = new System.Drawing.Point(69, 329);
            this.XRectangleTextBox.Name = "XRectangleTextBox";
            this.XRectangleTextBox.Size = new System.Drawing.Size(115, 22);
            this.XRectangleTextBox.TabIndex = 23;
            this.XRectangleTextBox.TextChanged += new System.EventHandler(this.XRectangleTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "X:";
            // 
            // IdRectangleTextBox
            // 
            this.IdRectangleTextBox.Enabled = false;
            this.IdRectangleTextBox.Location = new System.Drawing.Point(69, 301);
            this.IdRectangleTextBox.Name = "IdRectangleTextBox";
            this.IdRectangleTextBox.ReadOnly = true;
            this.IdRectangleTextBox.Size = new System.Drawing.Size(115, 22);
            this.IdRectangleTextBox.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Id:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Selected Rectangle:";
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Location = new System.Drawing.Point(370, 0);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(467, 446);
            this.CanvasPanel.TabIndex = 18;
            // 
            // RemoveRectangleButton
            // 
            this.RemoveRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRectangleButton.ForeColor = System.Drawing.Color.White;
            this.RemoveRectangleButton.Image = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.RemoveRectangleButton.Location = new System.Drawing.Point(212, 205);
            this.RemoveRectangleButton.Name = "RemoveRectangleButton";
            this.RemoveRectangleButton.Size = new System.Drawing.Size(41, 38);
            this.RemoveRectangleButton.TabIndex = 17;
            this.RemoveRectangleButton.UseVisualStyleBackColor = true;
            this.RemoveRectangleButton.Click += new System.EventHandler(this.RemoveRectangleButton_Click);
            this.RemoveRectangleButton.MouseEnter += new System.EventHandler(this.RemoveRectangleButton_MouseEnter);
            this.RemoveRectangleButton.MouseLeave += new System.EventHandler(this.RemoveRectangleButton_MouseLeave);
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.BackColor = System.Drawing.Color.Transparent;
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.ForeColor = System.Drawing.Color.Transparent;
            this.AddRectangleButton.Image = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.AddRectangleButton.Location = new System.Drawing.Point(66, 205);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(41, 38);
            this.AddRectangleButton.TabIndex = 16;
            this.AddRectangleButton.UseVisualStyleBackColor = false;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            this.AddRectangleButton.MouseEnter += new System.EventHandler(this.AddRectangleButton_MouseEnter);
            this.AddRectangleButton.MouseLeave += new System.EventHandler(this.AddRectangleButton_MouseLeave);
            // 
            // AddingRectanglesListBox
            // 
            this.AddingRectanglesListBox.FormattingEnabled = true;
            this.AddingRectanglesListBox.ItemHeight = 16;
            this.AddingRectanglesListBox.Location = new System.Drawing.Point(3, 3);
            this.AddingRectanglesListBox.Name = "AddingRectanglesListBox";
            this.AddingRectanglesListBox.Size = new System.Drawing.Size(350, 196);
            this.AddingRectanglesListBox.TabIndex = 15;
            this.AddingRectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.AddingRectanglesListBox_SelectedIndexChanged);
            // 
            // RectangleCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HeightRectangleTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.WidthRectangleTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.YRectangleTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.XRectangleTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.IdRectangleTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CanvasPanel);
            this.Controls.Add(this.RemoveRectangleButton);
            this.Controls.Add(this.AddRectangleButton);
            this.Controls.Add(this.AddingRectanglesListBox);
            this.Name = "RectangleCollisionControl";
            this.Size = new System.Drawing.Size(837, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HeightRectangleTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox WidthRectangleTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox YRectangleTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox XRectangleTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox IdRectangleTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.Button RemoveRectangleButton;
        private System.Windows.Forms.Button AddRectangleButton;
        private System.Windows.Forms.ListBox AddingRectanglesListBox;
    }
}
