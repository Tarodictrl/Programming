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
            this.EnumPage = new System.Windows.Forms.TabPage();
            this.SeasonHandleGroup = new System.Windows.Forms.GroupBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.ChooseSeason = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WeekdayParsingGroup = new System.Windows.Forms.GroupBox();
            this.OutLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParseInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EnumerationsGroup = new System.Windows.Forms.GroupBox();
            this.IntBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabEnums = new System.Windows.Forms.TabControl();
            this.EnumPage.SuspendLayout();
            this.SeasonHandleGroup.SuspendLayout();
            this.WeekdayParsingGroup.SuspendLayout();
            this.EnumerationsGroup.SuspendLayout();
            this.TabEnums.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumPage
            // 
            this.EnumPage.Controls.Add(this.SeasonHandleGroup);
            this.EnumPage.Controls.Add(this.WeekdayParsingGroup);
            this.EnumPage.Controls.Add(this.EnumerationsGroup);
            this.EnumPage.Location = new System.Drawing.Point(4, 22);
            this.EnumPage.Name = "EnumPage";
            this.EnumPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumPage.Size = new System.Drawing.Size(628, 583);
            this.EnumPage.TabIndex = 0;
            this.EnumPage.Text = "Enums";
            this.EnumPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroup
            // 
            this.SeasonHandleGroup.Controls.Add(this.GoButton);
            this.SeasonHandleGroup.Controls.Add(this.ChooseSeason);
            this.SeasonHandleGroup.Controls.Add(this.label5);
            this.SeasonHandleGroup.Location = new System.Drawing.Point(318, 360);
            this.SeasonHandleGroup.Name = "SeasonHandleGroup";
            this.SeasonHandleGroup.Size = new System.Drawing.Size(302, 215);
            this.SeasonHandleGroup.TabIndex = 2;
            this.SeasonHandleGroup.TabStop = false;
            this.SeasonHandleGroup.Text = "Season Handle";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(182, 56);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(76, 21);
            this.GoButton.TabIndex = 2;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // ChooseSeason
            // 
            this.ChooseSeason.FormattingEnabled = true;
            this.ChooseSeason.Location = new System.Drawing.Point(9, 56);
            this.ChooseSeason.Name = "ChooseSeason";
            this.ChooseSeason.Size = new System.Drawing.Size(167, 21);
            this.ChooseSeason.TabIndex = 1;
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
            // WeekdayParsingGroup
            // 
            this.WeekdayParsingGroup.Controls.Add(this.OutLabel);
            this.WeekdayParsingGroup.Controls.Add(this.ParseButton);
            this.WeekdayParsingGroup.Controls.Add(this.ParseInput);
            this.WeekdayParsingGroup.Controls.Add(this.label4);
            this.WeekdayParsingGroup.Location = new System.Drawing.Point(8, 360);
            this.WeekdayParsingGroup.Name = "WeekdayParsingGroup";
            this.WeekdayParsingGroup.Size = new System.Drawing.Size(304, 215);
            this.WeekdayParsingGroup.TabIndex = 1;
            this.WeekdayParsingGroup.TabStop = false;
            this.WeekdayParsingGroup.Text = "Weekday Parsing";
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
            this.ParseButton.Size = new System.Drawing.Size(70, 20);
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
            // EnumerationsGroup
            // 
            this.EnumerationsGroup.Controls.Add(this.IntBox);
            this.EnumerationsGroup.Controls.Add(this.label3);
            this.EnumerationsGroup.Controls.Add(this.ValuesListBox);
            this.EnumerationsGroup.Controls.Add(this.label2);
            this.EnumerationsGroup.Controls.Add(this.EnumsListBox);
            this.EnumerationsGroup.Controls.Add(this.label1);
            this.EnumerationsGroup.Location = new System.Drawing.Point(8, 6);
            this.EnumerationsGroup.Name = "EnumerationsGroup";
            this.EnumerationsGroup.Size = new System.Drawing.Size(612, 337);
            this.EnumerationsGroup.TabIndex = 0;
            this.EnumerationsGroup.TabStop = false;
            this.EnumerationsGroup.Text = "Enumerations";
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
            // TabEnums
            // 
            this.TabEnums.Controls.Add(this.EnumPage);
            this.TabEnums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabEnums.Location = new System.Drawing.Point(0, 0);
            this.TabEnums.Name = "TabEnums";
            this.TabEnums.SelectedIndex = 0;
            this.TabEnums.Size = new System.Drawing.Size(636, 609);
            this.TabEnums.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 609);
            this.Controls.Add(this.TabEnums);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming demo";
            this.EnumPage.ResumeLayout(false);
            this.SeasonHandleGroup.ResumeLayout(false);
            this.SeasonHandleGroup.PerformLayout();
            this.WeekdayParsingGroup.ResumeLayout(false);
            this.WeekdayParsingGroup.PerformLayout();
            this.EnumerationsGroup.ResumeLayout(false);
            this.EnumerationsGroup.PerformLayout();
            this.TabEnums.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage EnumPage;
        private System.Windows.Forms.TabControl TabEnums;
        private System.Windows.Forms.GroupBox EnumerationsGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IntBox;
        private System.Windows.Forms.GroupBox WeekdayParsingGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox ParseInput;
        private System.Windows.Forms.Label OutLabel;
        private System.Windows.Forms.GroupBox SeasonHandleGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.ComboBox ChooseSeason;
    }
}

