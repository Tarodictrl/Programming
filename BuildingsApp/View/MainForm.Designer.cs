namespace BuildingsApp.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BuildingsListBox = new System.Windows.Forms.ListBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.BuildingsGroupBox = new System.Windows.Forms.GroupBox();
            this.BuildingCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.BuildingRatingTextBox = new System.Windows.Forms.TextBox();
            this.BuildingAddressTextBox = new System.Windows.Forms.TextBox();
            this.BuildingNameTextBox = new System.Windows.Forms.TextBox();
            this.BuildingRatingLabel = new System.Windows.Forms.Label();
            this.BuildingCategoryLabel = new System.Windows.Forms.Label();
            this.BuildingAddressLabel = new System.Windows.Forms.Label();
            this.BuildingNameLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.BuildingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuildingsListBox
            // 
            this.BuildingsListBox.FormattingEnabled = true;
            this.BuildingsListBox.ItemHeight = 16;
            this.BuildingsListBox.Location = new System.Drawing.Point(12, 12);
            this.BuildingsListBox.Name = "BuildingsListBox";
            this.BuildingsListBox.Size = new System.Drawing.Size(230, 404);
            this.BuildingsListBox.TabIndex = 0;
            this.BuildingsListBox.SelectedIndexChanged += new System.EventHandler(this.BuildingsListBox_SelectedIndexChanged);
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
            this.RemoveButton.Image = global::BuildingsApp.Properties.Resources.cross_circle_24x24;
            this.RemoveButton.Location = new System.Drawing.Point(190, 418);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(52, 52);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            this.RemoveButton.MouseEnter += new System.EventHandler(this.RemoveButton_MouseEnter);
            this.RemoveButton.MouseLeave += new System.EventHandler(this.RemoveButton_MouseLeave);
            // 
            // BuildingsGroupBox
            // 
            this.BuildingsGroupBox.Controls.Add(this.BuildingCategoryComboBox);
            this.BuildingsGroupBox.Controls.Add(this.BuildingRatingTextBox);
            this.BuildingsGroupBox.Controls.Add(this.BuildingAddressTextBox);
            this.BuildingsGroupBox.Controls.Add(this.BuildingNameTextBox);
            this.BuildingsGroupBox.Controls.Add(this.BuildingRatingLabel);
            this.BuildingsGroupBox.Controls.Add(this.BuildingCategoryLabel);
            this.BuildingsGroupBox.Controls.Add(this.BuildingAddressLabel);
            this.BuildingsGroupBox.Controls.Add(this.BuildingNameLabel);
            this.BuildingsGroupBox.Location = new System.Drawing.Point(270, 12);
            this.BuildingsGroupBox.Name = "BuildingsGroupBox";
            this.BuildingsGroupBox.Size = new System.Drawing.Size(538, 264);
            this.BuildingsGroupBox.TabIndex = 4;
            this.BuildingsGroupBox.TabStop = false;
            this.BuildingsGroupBox.Text = "Selected Building";
            // 
            // BuildingCategoryComboBox
            // 
            this.BuildingCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuildingCategoryComboBox.FormattingEnabled = true;
            this.BuildingCategoryComboBox.Location = new System.Drawing.Point(92, 90);
            this.BuildingCategoryComboBox.Name = "BuildingCategoryComboBox";
            this.BuildingCategoryComboBox.Size = new System.Drawing.Size(171, 24);
            this.BuildingCategoryComboBox.TabIndex = 7;
            // 
            // BuildingRatingTextBox
            // 
            this.BuildingRatingTextBox.Location = new System.Drawing.Point(92, 120);
            this.BuildingRatingTextBox.Name = "BuildingRatingTextBox";
            this.BuildingRatingTextBox.Size = new System.Drawing.Size(171, 22);
            this.BuildingRatingTextBox.TabIndex = 6;
            this.BuildingRatingTextBox.TextChanged += new System.EventHandler(this.BuildingRatingTextBox_TextChanged);
            // 
            // BuildingAddressTextBox
            // 
            this.BuildingAddressTextBox.Location = new System.Drawing.Point(92, 60);
            this.BuildingAddressTextBox.Name = "BuildingAddressTextBox";
            this.BuildingAddressTextBox.Size = new System.Drawing.Size(171, 22);
            this.BuildingAddressTextBox.TabIndex = 5;
            this.BuildingAddressTextBox.TextChanged += new System.EventHandler(this.BuildingAddressTextBox_TextChanged);
            // 
            // BuildingNameTextBox
            // 
            this.BuildingNameTextBox.Location = new System.Drawing.Point(91, 30);
            this.BuildingNameTextBox.Name = "BuildingNameTextBox";
            this.BuildingNameTextBox.Size = new System.Drawing.Size(171, 22);
            this.BuildingNameTextBox.TabIndex = 4;
            this.BuildingNameTextBox.TextChanged += new System.EventHandler(this.BuildingNameTextBox_TextChanged);
            // 
            // BuildingRatingLabel
            // 
            this.BuildingRatingLabel.AutoSize = true;
            this.BuildingRatingLabel.Location = new System.Drawing.Point(36, 120);
            this.BuildingRatingLabel.Name = "BuildingRatingLabel";
            this.BuildingRatingLabel.Size = new System.Drawing.Size(49, 16);
            this.BuildingRatingLabel.TabIndex = 3;
            this.BuildingRatingLabel.Text = "Rating:";
            // 
            // BuildingCategoryLabel
            // 
            this.BuildingCategoryLabel.AutoSize = true;
            this.BuildingCategoryLabel.Location = new System.Drawing.Point(20, 90);
            this.BuildingCategoryLabel.Name = "BuildingCategoryLabel";
            this.BuildingCategoryLabel.Size = new System.Drawing.Size(65, 16);
            this.BuildingCategoryLabel.TabIndex = 2;
            this.BuildingCategoryLabel.Text = "Category:";
            // 
            // BuildingAddressLabel
            // 
            this.BuildingAddressLabel.AutoSize = true;
            this.BuildingAddressLabel.Location = new System.Drawing.Point(24, 60);
            this.BuildingAddressLabel.Name = "BuildingAddressLabel";
            this.BuildingAddressLabel.Size = new System.Drawing.Size(61, 16);
            this.BuildingAddressLabel.TabIndex = 1;
            this.BuildingAddressLabel.Text = "Address:";
            // 
            // BuildingNameLabel
            // 
            this.BuildingNameLabel.AutoSize = true;
            this.BuildingNameLabel.Location = new System.Drawing.Point(38, 30);
            this.BuildingNameLabel.Name = "BuildingNameLabel";
            this.BuildingNameLabel.Size = new System.Drawing.Size(47, 16);
            this.BuildingNameLabel.TabIndex = 0;
            this.BuildingNameLabel.Text = "Name:";
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
            this.AddButton.Image = global::BuildingsApp.Properties.Resources.add_24x24;
            this.AddButton.Location = new System.Drawing.Point(12, 418);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(52, 52);
            this.AddButton.TabIndex = 1;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseEnter += new System.EventHandler(this.AddButton_MouseEnter);
            this.AddButton.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            // 
            // EditButton
            // 
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.ForeColor = System.Drawing.Color.Transparent;
            this.EditButton.Image = global::BuildingsApp.Properties.Resources.edit_24x24;
            this.EditButton.Location = new System.Drawing.Point(98, 418);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(52, 52);
            this.EditButton.TabIndex = 5;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            this.EditButton.MouseEnter += new System.EventHandler(this.EditButton_MouseEnter);
            this.EditButton.MouseLeave += new System.EventHandler(this.EditButton_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 486);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.BuildingsGroupBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BuildingsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "BuildingsApp";
            this.BuildingsGroupBox.ResumeLayout(false);
            this.BuildingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BuildingsListBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.GroupBox BuildingsGroupBox;
        private System.Windows.Forms.ComboBox BuildingCategoryComboBox;
        private System.Windows.Forms.TextBox BuildingRatingTextBox;
        private System.Windows.Forms.TextBox BuildingAddressTextBox;
        private System.Windows.Forms.TextBox BuildingNameTextBox;
        private System.Windows.Forms.Label BuildingRatingLabel;
        private System.Windows.Forms.Label BuildingCategoryLabel;
        private System.Windows.Forms.Label BuildingAddressLabel;
        private System.Windows.Forms.Label BuildingNameLabel;
        private System.Windows.Forms.Button EditButton;
    }
}

