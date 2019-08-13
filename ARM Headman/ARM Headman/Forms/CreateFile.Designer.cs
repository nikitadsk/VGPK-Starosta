namespace ARM_Headman
{
    partial class CreateFile
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
            this.studentsCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.headmanId = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupName = new System.Windows.Forms.TextBox();
            this.curatorInfoGroupBox = new ARM_Headman.HumanInfoGroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.specialCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // studentsCount
            // 
            this.studentsCount.Location = new System.Drawing.Point(129, 211);
            this.studentsCount.Name = "studentsCount";
            this.studentsCount.Size = new System.Drawing.Size(35, 20);
            this.studentsCount.TabIndex = 1;
            this.studentsCount.TextChanged += new System.EventHandler(this.StudentsCount_TextChanged);
            this.studentsCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentsCount_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Количество студентов:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 277);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(376, 212);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID старосты:";
            // 
            // headmanId
            // 
            this.headmanId.Location = new System.Drawing.Point(129, 234);
            this.headmanId.Name = "headmanId";
            this.headmanId.Size = new System.Drawing.Size(35, 20);
            this.headmanId.TabIndex = 5;
            this.headmanId.TextChanged += new System.EventHandler(this.HeadmanId_TextChanged);
            this.headmanId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeadmanId_KeyPress);
            // 
            // createButton
            // 
            this.createButton.Enabled = false;
            this.createButton.Location = new System.Drawing.Point(170, 192);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(183, 62);
            this.createButton.TabIndex = 7;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Наименование группы:";
            // 
            // groupName
            // 
            this.groupName.Location = new System.Drawing.Point(129, 188);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(35, 20);
            this.groupName.TabIndex = 8;
            this.groupName.TextChanged += new System.EventHandler(this.GroupName_TextChanged);
            // 
            // curatorInfoGroupBox
            // 
            this.curatorInfoGroupBox.Location = new System.Drawing.Point(3, 2);
            this.curatorInfoGroupBox.Name = "curatorInfoGroupBox";
            this.curatorInfoGroupBox.Size = new System.Drawing.Size(350, 159);
            this.curatorInfoGroupBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Код специальности:";
            // 
            // specialCode
            // 
            this.specialCode.Location = new System.Drawing.Point(129, 164);
            this.specialCode.Name = "specialCode";
            this.specialCode.Size = new System.Drawing.Size(224, 20);
            this.specialCode.TabIndex = 10;
            this.specialCode.TextChanged += new System.EventHandler(this.SpecialCode_TextChanged);
            // 
            // CreateFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 501);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.specialCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupName);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headmanId);
            this.Controls.Add(this.curatorInfoGroupBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.studentsCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateFile";
            this.Text = "Создание файла";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateFile_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox studentsCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private HumanInfoGroupBox curatorInfoGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox headmanId;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox groupName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox specialCode;
    }
}