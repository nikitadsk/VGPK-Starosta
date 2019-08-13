namespace ARM_Headman.Controls
{
    partial class DayGroupBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.lessonNum = new System.Windows.Forms.MaskedTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dayNum = new System.Windows.Forms.GroupBox();
            this.dayNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество пар:";
            // 
            // lessonNum
            // 
            this.lessonNum.Location = new System.Drawing.Point(102, 25);
            this.lessonNum.Mask = "0";
            this.lessonNum.Name = "lessonNum";
            this.lessonNum.Size = new System.Drawing.Size(14, 20);
            this.lessonNum.TabIndex = 1;
            this.lessonNum.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox1_MaskInputRejected);
            this.lessonNum.TextChanged += new System.EventHandler(this.LessonNum_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 58);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(559, 462);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // dayNum
            // 
            this.dayNum.Controls.Add(this.lessonNum);
            this.dayNum.Controls.Add(this.flowLayoutPanel1);
            this.dayNum.Controls.Add(this.label1);
            this.dayNum.Location = new System.Drawing.Point(3, 3);
            this.dayNum.Name = "dayNum";
            this.dayNum.Size = new System.Drawing.Size(580, 532);
            this.dayNum.TabIndex = 4;
            this.dayNum.TabStop = false;
            this.dayNum.Text = "groupBox1";
            // 
            // DayGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.dayNum);
            this.Name = "DayGroupBox";
            this.Size = new System.Drawing.Size(591, 548);
            this.Load += new System.EventHandler(this.DayGroupBox_Load);
            this.dayNum.ResumeLayout(false);
            this.dayNum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox lessonNum;
        private System.Windows.Forms.GroupBox dayNum;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
