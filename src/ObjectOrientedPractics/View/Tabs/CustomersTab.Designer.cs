namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            ObjectOrientedPractics.Model.Address address1 = new ObjectOrientedPractics.Model.Address();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.SelectedCustomerLabel = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.RemoveButtonPanel = new System.Windows.Forms.Panel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButtonPanel = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.CustomersLable = new System.Windows.Forms.Label();
            this.ItemsPanel = new System.Windows.Forms.Panel();
            this.IDLabel = new System.Windows.Forms.Label();
            this.SelectedItemPanel = new System.Windows.Forms.Panel();
            this.RemoveDiscountButton = new System.Windows.Forms.Button();
            this.AddDiscountButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DiscountsListBox = new System.Windows.Forms.ListBox();
            this.IsPriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.ButtonsPanel.SuspendLayout();
            this.RemoveButtonPanel.SuspendLayout();
            this.AddButtonPanel.SuspendLayout();
            this.ItemsPanel.SuspendLayout();
            this.SelectedItemPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDTextBox
            // 
            this.IDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.IDTextBox.Location = new System.Drawing.Point(88, 43);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(132, 22);
            this.IDTextBox.TabIndex = 12;
            // 
            // SelectedCustomerLabel
            // 
            this.SelectedCustomerLabel.AutoSize = true;
            this.SelectedCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedCustomerLabel.Location = new System.Drawing.Point(4, 4);
            this.SelectedCustomerLabel.Margin = new System.Windows.Forms.Padding(4);
            this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            this.SelectedCustomerLabel.Size = new System.Drawing.Size(144, 17);
            this.SelectedCustomerLabel.TabIndex = 10;
            this.SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonsPanel.Controls.Add(this.ButtonPanel);
            this.ButtonsPanel.Controls.Add(this.RemoveButtonPanel);
            this.ButtonsPanel.Controls.Add(this.AddButtonPanel);
            this.ButtonsPanel.Location = new System.Drawing.Point(4, 543);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(388, 62);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Location = new System.Drawing.Point(260, 4);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(124, 54);
            this.ButtonPanel.TabIndex = 3;
            // 
            // RemoveButtonPanel
            // 
            this.RemoveButtonPanel.Controls.Add(this.RemoveButton);
            this.RemoveButtonPanel.Location = new System.Drawing.Point(132, 4);
            this.RemoveButtonPanel.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveButtonPanel.Name = "RemoveButtonPanel";
            this.RemoveButtonPanel.Size = new System.Drawing.Size(124, 54);
            this.RemoveButtonPanel.TabIndex = 2;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Location = new System.Drawing.Point(0, 0);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(124, 54);
            this.RemoveButton.TabIndex = 0;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButtonPanel
            // 
            this.AddButtonPanel.Controls.Add(this.AddButton);
            this.AddButtonPanel.Location = new System.Drawing.Point(4, 4);
            this.AddButtonPanel.Margin = new System.Windows.Forms.Padding(4);
            this.AddButtonPanel.Name = "AddButtonPanel";
            this.AddButtonPanel.Size = new System.Drawing.Size(124, 54);
            this.AddButtonPanel.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Location = new System.Drawing.Point(0, 0);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(124, 54);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(88, 75);
            this.FullNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(416, 22);
            this.FullNameTextBox.TabIndex = 14;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(4, 79);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(71, 16);
            this.CostLabel.TabIndex = 13;
            this.CostLabel.Text = "Full Name:";
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 16;
            this.CustomersListBox.Location = new System.Drawing.Point(4, 27);
            this.CustomersListBox.Margin = new System.Windows.Forms.Padding(4);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(387, 500);
            this.CustomersListBox.TabIndex = 1;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // CustomersLable
            // 
            this.CustomersLable.AutoSize = true;
            this.CustomersLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLable.Location = new System.Drawing.Point(4, 4);
            this.CustomersLable.Margin = new System.Windows.Forms.Padding(4);
            this.CustomersLable.Name = "CustomersLable";
            this.CustomersLable.Size = new System.Drawing.Size(84, 17);
            this.CustomersLable.TabIndex = 0;
            this.CustomersLable.Text = "Customers";
            // 
            // ItemsPanel
            // 
            this.ItemsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemsPanel.Controls.Add(this.ButtonsPanel);
            this.ItemsPanel.Controls.Add(this.CustomersListBox);
            this.ItemsPanel.Controls.Add(this.CustomersLable);
            this.ItemsPanel.Location = new System.Drawing.Point(4, 4);
            this.ItemsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsPanel.Name = "ItemsPanel";
            this.ItemsPanel.Size = new System.Drawing.Size(400, 608);
            this.ItemsPanel.TabIndex = 11;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(4, 46);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(23, 16);
            this.IDLabel.TabIndex = 11;
            this.IDLabel.Text = "ID:";
            // 
            // SelectedItemPanel
            // 
            this.SelectedItemPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemPanel.Controls.Add(this.RemoveDiscountButton);
            this.SelectedItemPanel.Controls.Add(this.AddDiscountButton);
            this.SelectedItemPanel.Controls.Add(this.label1);
            this.SelectedItemPanel.Controls.Add(this.DiscountsListBox);
            this.SelectedItemPanel.Controls.Add(this.IsPriorityCheckBox);
            this.SelectedItemPanel.Controls.Add(this.AddressControl);
            this.SelectedItemPanel.Controls.Add(this.FullNameTextBox);
            this.SelectedItemPanel.Controls.Add(this.CostLabel);
            this.SelectedItemPanel.Controls.Add(this.IDTextBox);
            this.SelectedItemPanel.Controls.Add(this.IDLabel);
            this.SelectedItemPanel.Controls.Add(this.SelectedCustomerLabel);
            this.SelectedItemPanel.Location = new System.Drawing.Point(408, 4);
            this.SelectedItemPanel.Margin = new System.Windows.Forms.Padding(4);
            this.SelectedItemPanel.Name = "SelectedItemPanel";
            this.SelectedItemPanel.Size = new System.Drawing.Size(509, 608);
            this.SelectedItemPanel.TabIndex = 12;
            // 
            // RemoveDiscountButton
            // 
            this.RemoveDiscountButton.Location = new System.Drawing.Point(341, 386);
            this.RemoveDiscountButton.Name = "RemoveDiscountButton";
            this.RemoveDiscountButton.Size = new System.Drawing.Size(101, 41);
            this.RemoveDiscountButton.TabIndex = 21;
            this.RemoveDiscountButton.Text = "Remove";
            this.RemoveDiscountButton.UseVisualStyleBackColor = true;
            this.RemoveDiscountButton.Click += new System.EventHandler(this.RemoveDiscountButton_Click);
            // 
            // AddDiscountButton
            // 
            this.AddDiscountButton.Location = new System.Drawing.Point(341, 330);
            this.AddDiscountButton.Name = "AddDiscountButton";
            this.AddDiscountButton.Size = new System.Drawing.Size(101, 41);
            this.AddDiscountButton.TabIndex = 20;
            this.AddDiscountButton.Text = "Add";
            this.AddDiscountButton.UseVisualStyleBackColor = true;
            this.AddDiscountButton.Click += new System.EventHandler(this.AddDiscountButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 306);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Discounts";
            // 
            // DiscountsListBox
            // 
            this.DiscountsListBox.FormattingEnabled = true;
            this.DiscountsListBox.ItemHeight = 16;
            this.DiscountsListBox.Location = new System.Drawing.Point(7, 330);
            this.DiscountsListBox.Name = "DiscountsListBox";
            this.DiscountsListBox.Size = new System.Drawing.Size(328, 148);
            this.DiscountsListBox.TabIndex = 18;
            // 
            // IsPriorityCheckBox
            // 
            this.IsPriorityCheckBox.AutoSize = true;
            this.IsPriorityCheckBox.Location = new System.Drawing.Point(88, 108);
            this.IsPriorityCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            this.IsPriorityCheckBox.Size = new System.Drawing.Size(83, 20);
            this.IsPriorityCheckBox.TabIndex = 17;
            this.IsPriorityCheckBox.Text = "Is Priority";
            this.IsPriorityCheckBox.UseVisualStyleBackColor = true;
            this.IsPriorityCheckBox.CheckedChanged += new System.EventHandler(this.IsPriorityCheckBox_CheckedChanged);
            // 
            // AddressControl
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 100000;
            address1.Street = "";
            this.AddressControl.Address = address1;
            this.AddressControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressControl.Location = new System.Drawing.Point(4, 138);
            this.AddressControl.Margin = new System.Windows.Forms.Padding(5);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.ReadOnly = false;
            this.AddressControl.Size = new System.Drawing.Size(501, 135);
            this.AddressControl.TabIndex = 16;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemsPanel);
            this.Controls.Add(this.SelectedItemPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(933, 615);
            this.ButtonsPanel.ResumeLayout(false);
            this.RemoveButtonPanel.ResumeLayout(false);
            this.AddButtonPanel.ResumeLayout(false);
            this.ItemsPanel.ResumeLayout(false);
            this.ItemsPanel.PerformLayout();
            this.SelectedItemPanel.ResumeLayout(false);
            this.SelectedItemPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label SelectedCustomerLabel;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Panel RemoveButtonPanel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Panel AddButtonPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Label CustomersLable;
        private System.Windows.Forms.Panel ItemsPanel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Panel SelectedItemPanel;
        private Controls.AddressControl AddressControl;
        private System.Windows.Forms.CheckBox IsPriorityCheckBox;
        private System.Windows.Forms.ListBox DiscountsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveDiscountButton;
        private System.Windows.Forms.Button AddDiscountButton;
    }
}
