namespace ARM_Headman
{
    partial class ReportForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reportFirstDate = new System.Windows.Forms.MaskedTextBox();
            this.reportFiles = new System.Windows.Forms.ComboBox();
            this.openButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dayCount = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.reportFirstDate);
            this.groupBox1.Controls.Add(this.reportFiles);
            this.groupBox1.Controls.Add(this.openButton);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.dayCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 674);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создать/открыть файл рапортички";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата начала недели:";
            // 
            // reportFirstDate
            // 
            this.reportFirstDate.Location = new System.Drawing.Point(563, 19);
            this.reportFirstDate.Mask = "00/00/0000";
            this.reportFirstDate.Name = "reportFirstDate";
            this.reportFirstDate.Size = new System.Drawing.Size(61, 20);
            this.reportFirstDate.TabIndex = 6;
            this.reportFirstDate.ValidatingType = typeof(System.DateTime);
            // 
            // reportFiles
            // 
            this.reportFiles.FormattingEnabled = true;
            this.reportFiles.Location = new System.Drawing.Point(414, 621);
            this.reportFiles.Name = "reportFiles";
            this.reportFiles.Size = new System.Drawing.Size(210, 21);
            this.reportFiles.TabIndex = 5;
            this.reportFiles.SelectedIndexChanged += new System.EventHandler(this.ReportFiles_SelectedIndexChanged);
            // 
            // openButton
            // 
            this.openButton.Enabled = false;
            this.openButton.Location = new System.Drawing.Point(522, 644);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(102, 21);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "Открыть в Excel";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(6, 621);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(192, 44);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(615, 561);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // dayCount
            // 
            this.dayCount.Location = new System.Drawing.Point(102, 19);
            this.dayCount.Mask = "0";
            this.dayCount.Name = "dayCount";
            this.dayCount.Size = new System.Drawing.Size(13, 20);
            this.dayCount.TabIndex = 1;
            this.dayCount.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CountLessons_MaskInputRejected);
            this.dayCount.TextChanged += new System.EventHandler(this.CountLessons_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество дней:";
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(414, 644);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(102, 21);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 680);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportForm";
            this.Text = "Рапортички";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox dayCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox reportFiles;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox reportFirstDate;
        private System.Windows.Forms.Button editButton;
    }
}