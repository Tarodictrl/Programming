namespace BuildingsApp.View.Controls
{
    partial class BuildingsControl
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
            this.BuildingsListBox = new System.Windows.Forms.ListBox();
            this.BuildingsGroupBox = new System.Windows.Forms.GroupBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.BuildingNameTextBox = new System.Windows.Forms.TextBox();
            this.BuildingNameLabel = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.BuildingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuildingsListBox
            // 
            this.BuildingsListBox.FormattingEnabled = true;
            this.BuildingsListBox.ItemHeight = 16;
            this.BuildingsListBox.Location = new System.Drawing.Point(3, 3);
            this.BuildingsListBox.Name = "BuildingsListBox";
            this.BuildingsListBox.Size = new System.Drawing.Size(265, 532);
            this.BuildingsListBox.TabIndex = 0;
            // 
            // BuildingsGroupBox
            // 
            this.BuildingsGroupBox.Controls.Add(this.CategoryTextBox);
            this.BuildingsGroupBox.Controls.Add(this.CategoryLabel);
            this.BuildingsGroupBox.Controls.Add(this.RatingTextBox);
            this.BuildingsGroupBox.Controls.Add(this.RatingLabel);
            this.BuildingsGroupBox.Controls.Add(this.AddressTextBox);
            this.BuildingsGroupBox.Controls.Add(this.AddressLabel);
            this.BuildingsGroupBox.Controls.Add(this.BuildingNameTextBox);
            this.BuildingsGroupBox.Controls.Add(this.BuildingNameLabel);
            this.BuildingsGroupBox.Location = new System.Drawing.Point(274, 3);
            this.BuildingsGroupBox.Name = "BuildingsGroupBox";
            this.BuildingsGroupBox.Size = new System.Drawing.Size(521, 263);
            this.BuildingsGroupBox.TabIndex = 1;
            this.BuildingsGroupBox.TabStop = false;
            this.BuildingsGroupBox.Text = "Select a building";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(124, 49);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(311, 22);
            this.AddressTextBox.TabIndex = 3;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(56, 49);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(61, 16);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "Address:";
            // 
            // BuildingNameTextBox
            // 
            this.BuildingNameTextBox.Location = new System.Drawing.Point(124, 22);
            this.BuildingNameTextBox.Name = "BuildingNameTextBox";
            this.BuildingNameTextBox.Size = new System.Drawing.Size(311, 22);
            this.BuildingNameTextBox.TabIndex = 1;
            // 
            // BuildingNameLabel
            // 
            this.BuildingNameLabel.AutoSize = true;
            this.BuildingNameLabel.Location = new System.Drawing.Point(22, 22);
            this.BuildingNameLabel.Name = "BuildingNameLabel";
            this.BuildingNameLabel.Size = new System.Drawing.Size(95, 16);
            this.BuildingNameLabel.TabIndex = 0;
            this.BuildingNameLabel.Text = "Building name:";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(124, 105);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(156, 22);
            this.RatingTextBox.TabIndex = 5;
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(68, 105);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(49, 16);
            this.RatingLabel.TabIndex = 4;
            this.RatingLabel.Text = "Rating:";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(124, 77);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(156, 22);
            this.CategoryTextBox.TabIndex = 7;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(56, 77);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(65, 16);
            this.CategoryLabel.TabIndex = 6;
            this.CategoryLabel.Text = "Category:";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(14, 542);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(40, 37);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(60, 542);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(36, 37);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "?";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(102, 542);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(38, 37);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "-";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // BuildingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BuildingsGroupBox);
            this.Controls.Add(this.BuildingsListBox);
            this.Name = "BuildingsControl";
            this.Size = new System.Drawing.Size(830, 691);
            this.BuildingsGroupBox.ResumeLayout(false);
            this.BuildingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BuildingsListBox;
        private System.Windows.Forms.GroupBox BuildingsGroupBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox BuildingNameTextBox;
        private System.Windows.Forms.Label BuildingNameLabel;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RemoveButton;
    }
}
