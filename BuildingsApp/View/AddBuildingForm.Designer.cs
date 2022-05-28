namespace BuildingsApp.View
{
    partial class AddBuildingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BuildingCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.BuildingRatingTextBox = new System.Windows.Forms.TextBox();
            this.BuildingAddressTextBox = new System.Windows.Forms.TextBox();
            this.BuildingNameTextBox = new System.Windows.Forms.TextBox();
            this.BuildingRatingLabel = new System.Windows.Forms.Label();
            this.BuildingCategoryLabel = new System.Windows.Forms.Label();
            this.BuildingAddressLabel = new System.Windows.Forms.Label();
            this.BuildingNameLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BuildingCategoryComboBox
            // 
            this.BuildingCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuildingCategoryComboBox.FormattingEnabled = true;
            this.BuildingCategoryComboBox.Location = new System.Drawing.Point(81, 69);
            this.BuildingCategoryComboBox.Name = "BuildingCategoryComboBox";
            this.BuildingCategoryComboBox.Size = new System.Drawing.Size(171, 24);
            this.BuildingCategoryComboBox.TabIndex = 15;
            this.BuildingCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.BuildingCategoryComboBox_SelectedIndexChanged);
            // 
            // BuildingRatingTextBox
            // 
            this.BuildingRatingTextBox.Location = new System.Drawing.Point(81, 99);
            this.BuildingRatingTextBox.Name = "BuildingRatingTextBox";
            this.BuildingRatingTextBox.Size = new System.Drawing.Size(171, 22);
            this.BuildingRatingTextBox.TabIndex = 14;
            this.BuildingRatingTextBox.TextChanged += new System.EventHandler(this.BuildingRatingTextBox_TextChanged);
            // 
            // BuildingAddressTextBox
            // 
            this.BuildingAddressTextBox.Location = new System.Drawing.Point(81, 39);
            this.BuildingAddressTextBox.Name = "BuildingAddressTextBox";
            this.BuildingAddressTextBox.Size = new System.Drawing.Size(171, 22);
            this.BuildingAddressTextBox.TabIndex = 13;
            this.BuildingAddressTextBox.TextChanged += new System.EventHandler(this.BuildingAddressTextBox_TextChanged);
            // 
            // BuildingNameTextBox
            // 
            this.BuildingNameTextBox.Location = new System.Drawing.Point(80, 9);
            this.BuildingNameTextBox.Name = "BuildingNameTextBox";
            this.BuildingNameTextBox.Size = new System.Drawing.Size(171, 22);
            this.BuildingNameTextBox.TabIndex = 12;
            this.BuildingNameTextBox.TextChanged += new System.EventHandler(this.BuildingNameTextBox_TextChanged);
            // 
            // BuildingRatingLabel
            // 
            this.BuildingRatingLabel.AutoSize = true;
            this.BuildingRatingLabel.Location = new System.Drawing.Point(25, 99);
            this.BuildingRatingLabel.Name = "BuildingRatingLabel";
            this.BuildingRatingLabel.Size = new System.Drawing.Size(49, 16);
            this.BuildingRatingLabel.TabIndex = 11;
            this.BuildingRatingLabel.Text = "Rating:";
            // 
            // BuildingCategoryLabel
            // 
            this.BuildingCategoryLabel.AutoSize = true;
            this.BuildingCategoryLabel.Location = new System.Drawing.Point(9, 69);
            this.BuildingCategoryLabel.Name = "BuildingCategoryLabel";
            this.BuildingCategoryLabel.Size = new System.Drawing.Size(65, 16);
            this.BuildingCategoryLabel.TabIndex = 10;
            this.BuildingCategoryLabel.Text = "Category:";
            // 
            // BuildingAddressLabel
            // 
            this.BuildingAddressLabel.AutoSize = true;
            this.BuildingAddressLabel.Location = new System.Drawing.Point(13, 39);
            this.BuildingAddressLabel.Name = "BuildingAddressLabel";
            this.BuildingAddressLabel.Size = new System.Drawing.Size(61, 16);
            this.BuildingAddressLabel.TabIndex = 9;
            this.BuildingAddressLabel.Text = "Address:";
            // 
            // BuildingNameLabel
            // 
            this.BuildingNameLabel.AutoSize = true;
            this.BuildingNameLabel.Location = new System.Drawing.Point(27, 9);
            this.BuildingNameLabel.Name = "BuildingNameLabel";
            this.BuildingNameLabel.Size = new System.Drawing.Size(47, 16);
            this.BuildingNameLabel.TabIndex = 8;
            this.BuildingNameLabel.Text = "Name:";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(16, 148);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(185, 148);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddBuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 213);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BuildingCategoryComboBox);
            this.Controls.Add(this.BuildingRatingTextBox);
            this.Controls.Add(this.BuildingAddressTextBox);
            this.Controls.Add(this.BuildingNameTextBox);
            this.Controls.Add(this.BuildingRatingLabel);
            this.Controls.Add(this.BuildingCategoryLabel);
            this.Controls.Add(this.BuildingAddressLabel);
            this.Controls.Add(this.BuildingNameLabel);
            this.Name = "AddBuildingForm";
            this.ShowIcon = false;
            this.Text = "AddBuildingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox BuildingRatingTextBox;
        private System.Windows.Forms.TextBox BuildingAddressTextBox;
        private System.Windows.Forms.TextBox BuildingNameTextBox;
        private System.Windows.Forms.Label BuildingRatingLabel;
        private System.Windows.Forms.Label BuildingCategoryLabel;
        private System.Windows.Forms.Label BuildingAddressLabel;
        private System.Windows.Forms.Label BuildingNameLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox BuildingCategoryComboBox;
    }
}