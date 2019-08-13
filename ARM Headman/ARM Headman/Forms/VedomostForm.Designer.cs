namespace ARM_Headman
{
    partial class VedomostForm
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
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.excelButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.reportFiles = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "январь",
            "февраль",
            "март",
            "апрель",
            "май",
            "июнь",
            "июль",
            "август",
            "сентябрь",
            "октябрь",
            "ноябрь",
            "декабрь"});
            this.monthComboBox.Location = new System.Drawing.Point(12, 22);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(96, 21);
            this.monthComboBox.TabIndex = 0;
            this.monthComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "месяц";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(123, 23);
            this.yearTextBox.Mask = "0000";
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(32, 20);
            this.yearTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "год";
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadButton.Location = new System.Drawing.Point(172, 6);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(117, 51);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Загрузить";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // excelButton
            // 
            this.excelButton.Location = new System.Drawing.Point(295, 4);
            this.excelButton.Name = "excelButton";
            this.excelButton.Size = new System.Drawing.Size(117, 53);
            this.excelButton.TabIndex = 5;
            this.excelButton.Text = "Открыть ведомость в Excel";
            this.excelButton.UseVisualStyleBackColor = true;
            this.excelButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(399, 44);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Покрытые дни:";
            // 
            // reportFiles
            // 
            this.reportFiles.FormattingEnabled = true;
            this.reportFiles.Location = new System.Drawing.Point(257, 131);
            this.reportFiles.Name = "reportFiles";
            this.reportFiles.Size = new System.Drawing.Size(117, 21);
            this.reportFiles.TabIndex = 8;
            // 
            // VedomostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 121);
            this.Controls.Add(this.reportFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.excelButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthComboBox);
            this.Name = "VedomostForm";
            this.Text = "Ведомости";
            this.Load += new System.EventHandler(this.VedomostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox yearTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox reportFiles;
        private System.Windows.Forms.Button excelButton;
    }
}