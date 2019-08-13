namespace ARM_Headman
{
    partial class OpenDialog
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
            this.listFiles = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.groupInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listFiles
            // 
            this.listFiles.FormattingEnabled = true;
            this.listFiles.Location = new System.Drawing.Point(12, 12);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(288, 21);
            this.listFiles.TabIndex = 0;
            this.listFiles.SelectedIndexChanged += new System.EventHandler(this.ListFiles_SelectedIndexChanged);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(12, 232);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(288, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Открыть";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // groupInfo
            // 
            this.groupInfo.FormattingEnabled = true;
            this.groupInfo.Location = new System.Drawing.Point(13, 40);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(287, 186);
            this.groupInfo.TabIndex = 2;
            // 
            // OpenDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 261);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.listFiles);
            this.Name = "OpenDialog";
            this.Text = "Открыть файл списка учащихся";
            this.Load += new System.EventHandler(this.OpenDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ListBox groupInfo;
        protected System.Windows.Forms.ComboBox listFiles;
    }
}