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
            this.buildingsControl1 = new BuildingsApp.View.Controls.BuildingsControl();
            this.SuspendLayout();
            // 
            // buildingsControl1
            // 
            this.buildingsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildingsControl1.Location = new System.Drawing.Point(0, 0);
            this.buildingsControl1.Name = "buildingsControl1";
            this.buildingsControl1.Size = new System.Drawing.Size(931, 677);
            this.buildingsControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 677);
            this.Controls.Add(this.buildingsControl1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "BuildingsApp";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.BuildingsControl buildingsControl1;
    }
}

