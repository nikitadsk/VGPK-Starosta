namespace ARM_Headman
{
    partial class LoadMenu
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
            this.loadButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(0, 0);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(285, 52);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Выбрать файл группы";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сгенерировать файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LoadMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 118);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoadMenu";
            this.Text = "Загрузочное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button button1;
    }
}

