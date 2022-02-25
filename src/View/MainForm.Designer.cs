namespace Programming
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.ChooseSeasonCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OutLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParseInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IntBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabEnum = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TabEnum.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Winter",
            "Summer",
            "Autumn",
            "Spring"});
            this.comboBox1.Location = new System.Drawing.Point(25, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(628, 583);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enums";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GoButton);
            this.groupBox3.Controls.Add(this.ChooseSeasonCombo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(318, 360);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 215);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Season Handle";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(168, 56);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(76, 21);
            this.GoButton.TabIndex = 2;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // ChooseSeasonCombo
            // 
            this.ChooseSeasonCombo.FormattingEnabled = true;
            this.ChooseSeasonCombo.Location = new System.Drawing.Point(9, 56);
            this.ChooseSeasonCombo.Name = "ChooseSeasonCombo";
            this.ChooseSeasonCombo.Size = new System.Drawing.Size(153, 21);
            this.ChooseSeasonCombo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Choose season:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OutLabel);
            this.groupBox2.Controls.Add(this.ParseButton);
            this.groupBox2.Controls.Add(this.ParseInput);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(8, 360);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 215);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weekday Parsing";
            // 
            // OutLabel
            // 
            this.OutLabel.AutoSize = true;
            this.OutLabel.Location = new System.Drawing.Point(6, 91);
            this.OutLabel.Name = "OutLabel";
            this.OutLabel.Size = new System.Drawing.Size(0, 13);
            this.OutLabel.TabIndex = 3;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(182, 63);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(72, 20);
            this.ParseButton.TabIndex = 2;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParseInput
            // 
            this.ParseInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ParseInput.Location = new System.Drawing.Point(9, 63);
            this.ParseInput.Name = "ParseInput";
            this.ParseInput.Size = new System.Drawing.Size(167, 20);
            this.ParseInput.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type value for parsing:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IntBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ValuesListBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EnumsListBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enumerations";
            // 
            // IntBox
            // 
            this.IntBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntBox.Enabled = false;
            this.IntBox.Location = new System.Drawing.Point(376, 52);
            this.IntBox.Name = "IntBox";
            this.IntBox.Size = new System.Drawing.Size(122, 20);
            this.IntBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Int value:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(192, 52);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(141, 264);
            this.ValuesListBox.TabIndex = 3;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose value:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Location = new System.Drawing.Point(6, 52);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(141, 264);
            this.EnumsListBox.TabIndex = 1;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose enumerations:";
            // 
            // TabEnum
            // 
            this.TabEnum.Controls.Add(this.tabPage1);
            this.TabEnum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabEnum.Location = new System.Drawing.Point(0, 0);
            this.TabEnum.Name = "TabEnum";
            this.TabEnum.SelectedIndex = 0;
            this.TabEnum.Size = new System.Drawing.Size(636, 609);
            this.TabEnum.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 609);
            this.Controls.Add(this.TabEnum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming demo";
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TabEnum.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl TabEnum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IntBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox ParseInput;
        private System.Windows.Forms.Label OutLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.ComboBox ChooseSeasonCombo;
    }
}

