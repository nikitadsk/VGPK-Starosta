namespace ARM_Headman.Controls
{
    partial class LessonGroupBox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.disrespectfulList1 = new System.Windows.Forms.ListBox();
            this.respectfulList1 = new System.Windows.Forms.ListBox();
            this.studentList1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lessonName1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.disrespectfulList2 = new System.Windows.Forms.ListBox();
            this.respectfulList2 = new System.Windows.Forms.ListBox();
            this.studentList2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lessonName2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lessonNum = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.lessonNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lessonName1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1 час";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.disrespectfulList1);
            this.panel1.Controls.Add(this.respectfulList1);
            this.panel1.Controls.Add(this.studentList1);
            this.panel1.Location = new System.Drawing.Point(72, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 152);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(200, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Неув";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(200, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Уваж";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // disrespectfulList1
            // 
            this.disrespectfulList1.FormattingEnabled = true;
            this.disrespectfulList1.Location = new System.Drawing.Point(246, 80);
            this.disrespectfulList1.Name = "disrespectfulList1";
            this.disrespectfulList1.Size = new System.Drawing.Size(190, 69);
            this.disrespectfulList1.TabIndex = 4;
            this.disrespectfulList1.DoubleClick += new System.EventHandler(this.DisrespectfulList1_DoubleClick);
            // 
            // respectfulList1
            // 
            this.respectfulList1.FormattingEnabled = true;
            this.respectfulList1.Location = new System.Drawing.Point(246, 3);
            this.respectfulList1.Name = "respectfulList1";
            this.respectfulList1.Size = new System.Drawing.Size(190, 69);
            this.respectfulList1.TabIndex = 3;
            this.respectfulList1.DoubleClick += new System.EventHandler(this.RespectfulList1_DoubleClick);
            // 
            // studentList1
            // 
            this.studentList1.FormattingEnabled = true;
            this.studentList1.Location = new System.Drawing.Point(3, 2);
            this.studentList1.Name = "studentList1";
            this.studentList1.Size = new System.Drawing.Size(190, 147);
            this.studentList1.Sorted = true;
            this.studentList1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пропуски:";
            // 
            // lessonName1
            // 
            this.lessonName1.Location = new System.Drawing.Point(150, 13);
            this.lessonName1.Name = "lessonName1";
            this.lessonName1.Size = new System.Drawing.Size(234, 20);
            this.lessonName1.TabIndex = 1;
            this.lessonName1.TextChanged += new System.EventHandler(this.LessonName1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование предмета:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lessonName2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 205);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2 час";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.disrespectfulList2);
            this.panel2.Controls.Add(this.respectfulList2);
            this.panel2.Controls.Add(this.studentList2);
            this.panel2.Location = new System.Drawing.Point(72, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 152);
            this.panel2.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(200, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Неув";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(200, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Уваж";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // disrespectfulList2
            // 
            this.disrespectfulList2.FormattingEnabled = true;
            this.disrespectfulList2.Location = new System.Drawing.Point(246, 80);
            this.disrespectfulList2.Name = "disrespectfulList2";
            this.disrespectfulList2.Size = new System.Drawing.Size(190, 69);
            this.disrespectfulList2.TabIndex = 4;
            this.disrespectfulList2.DoubleClick += new System.EventHandler(this.DisrespectfulList2_DoubleClick);
            // 
            // respectfulList2
            // 
            this.respectfulList2.FormattingEnabled = true;
            this.respectfulList2.Location = new System.Drawing.Point(246, 3);
            this.respectfulList2.Name = "respectfulList2";
            this.respectfulList2.Size = new System.Drawing.Size(190, 69);
            this.respectfulList2.TabIndex = 3;
            this.respectfulList2.DoubleClick += new System.EventHandler(this.RespectfulList2_DoubleClick);
            // 
            // studentList2
            // 
            this.studentList2.FormattingEnabled = true;
            this.studentList2.Location = new System.Drawing.Point(3, 2);
            this.studentList2.Name = "studentList2";
            this.studentList2.Size = new System.Drawing.Size(190, 147);
            this.studentList2.Sorted = true;
            this.studentList2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пропуски:";
            // 
            // lessonName2
            // 
            this.lessonName2.Location = new System.Drawing.Point(150, 13);
            this.lessonName2.Name = "lessonName2";
            this.lessonName2.Size = new System.Drawing.Size(234, 20);
            this.lessonName2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Наименование предмета:";
            // 
            // lessonNum
            // 
            this.lessonNum.Controls.Add(this.groupBox2);
            this.lessonNum.Controls.Add(this.groupBox1);
            this.lessonNum.Location = new System.Drawing.Point(0, 4);
            this.lessonNum.Name = "lessonNum";
            this.lessonNum.Size = new System.Drawing.Size(529, 438);
            this.lessonNum.TabIndex = 2;
            this.lessonNum.TabStop = false;
            this.lessonNum.Text = "groupBox3";
            // 
            // LessonGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lessonNum);
            this.Name = "LessonGroupBox";
            this.Size = new System.Drawing.Size(532, 449);
            this.Load += new System.EventHandler(this.LessonGroupBox_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.lessonNum.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lessonName1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lessonName2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox lessonNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox disrespectfulList1;
        private System.Windows.Forms.ListBox respectfulList1;
        private System.Windows.Forms.ListBox studentList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox disrespectfulList2;
        private System.Windows.Forms.ListBox respectfulList2;
        private System.Windows.Forms.ListBox studentList2;
    }
}
