namespace ARM_Headman
{
    partial class MainForm
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
            this.reportButton = new System.Windows.Forms.Button();
            this.vedomostButton = new System.Windows.Forms.Button();
            this.groupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(0, 0);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(455, 65);
            this.reportButton.TabIndex = 0;
            this.reportButton.Text = "Рапортички";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // vedomostButton
            // 
            this.vedomostButton.Location = new System.Drawing.Point(0, 71);
            this.vedomostButton.Name = "vedomostButton";
            this.vedomostButton.Size = new System.Drawing.Size(455, 65);
            this.vedomostButton.TabIndex = 1;
            this.vedomostButton.Text = "Ведомости";
            this.vedomostButton.UseVisualStyleBackColor = true;
            this.vedomostButton.Click += new System.EventHandler(this.VedomostButton_Click);
            // 
            // groupButton
            // 
            this.groupButton.Location = new System.Drawing.Point(0, 142);
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(455, 65);
            this.groupButton.TabIndex = 2;
            this.groupButton.Text = "Редактирование информации о группе";
            this.groupButton.UseVisualStyleBackColor = true;
            this.groupButton.Click += new System.EventHandler(this.GroupButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 217);
            this.Controls.Add(this.groupButton);
            this.Controls.Add(this.vedomostButton);
            this.Controls.Add(this.reportButton);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button vedomostButton;
        private System.Windows.Forms.Button groupButton;
    }
}