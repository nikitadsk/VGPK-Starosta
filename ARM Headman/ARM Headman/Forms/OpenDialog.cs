using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ARM_Headman
{
    public partial class OpenDialog : Form
    {
        public Group group;
        public OpenDialog()
        {
            InitializeComponent();
        }

        private void ListFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupInfo.Items.Clear();
            if(listFiles.SelectedIndex != -1)
            {
                group = Group.GetGroupFromXml($@"{Directory.GetCurrentDirectory()}\Files\GroupFiles\{listFiles.SelectedItem}.xml");

                groupInfo.Items.Add($"Код специальности: {group.SpecialCode}");
                groupInfo.Items.Add($"Наименование группы: {group.GroupName}");
                groupInfo.Items.Add($"ФИО куратора: {group.Curator.FullName}");
                groupInfo.Items.Add($"ФИО старосты: {group.Students[group.HeadmanId - 1].FullName}");
                groupInfo.Items.Add("");
                groupInfo.Items.Add("Список студентов:");

                foreach(var i in group.Students)
                {
                    groupInfo.Items.Add($"{i.FullName}");
                }
                okButton.Enabled = true;
            } else
            {
                okButton.Enabled = false;
            }
        }

        private void OpenDialog_Load(object sender, EventArgs e)
        {
            var dir = new DirectoryInfo($@"{Directory.GetCurrentDirectory()}\Files\GroupFiles"); // папка с файлами 

            foreach (FileInfo file in dir.GetFiles())
            {
                listFiles.Items.Add(Path.GetFileNameWithoutExtension(file.FullName));
            }
        }
    }
}