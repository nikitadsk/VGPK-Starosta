using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;

namespace ARM_Headman
{
    public partial class CreateFile : Form
    {
        readonly Form mainForm;
        readonly bool isEditing;

        public CreateFile()
        {
            InitializeComponent();
        }

        public CreateFile(Form mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        public CreateFile(Form mainForm, bool isEditing)
        {
            this.mainForm = mainForm;
            this.isEditing = isEditing;
            InitializeComponent();

            //блок редактирования окна
            this.Text = "Редактирование группы";
            createButton.Text = "Сохранить";

            //заполнение полей
            curatorInfoGroupBox.Fill(MainForm.CurrentGroup.Curator);

            specialCode.Text = MainForm.CurrentGroup.SpecialCode;
            groupName.Text = MainForm.CurrentGroup.GroupName;
            studentsCount.Text = MainForm.CurrentGroup.Students.Count.ToString();
            headmanId.Text = MainForm.CurrentGroup.HeadmanId.ToString();

            int studentId = 0;
            foreach(HumanInfoGroupBox student in flowLayoutPanel1.Controls)
            {
                student.Fill(MainForm.CurrentGroup.Students[studentId]);
                studentId++;
            }
        }

        private void StudentsCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08) e.Handled = true;
        }

        private void StudentsCount_TextChanged(object sender, EventArgs e)
        {
            if (groupName.Text != "" && studentsCount.Text != "" && headmanId.Text != "" && specialCode.Text != "") createButton.Enabled = true;
            else createButton.Enabled = false;

            flowLayoutPanel1.Controls.Clear();
            if (studentsCount.Text != "")
            {
                for (int i = 0; i < int.Parse(studentsCount.Text); i++)
                {
                    flowLayoutPanel1.Controls.Add(new HumanInfoGroupBox($"Учащийся {i + 1}"));
                }
            }
        }

        private void HeadmanId_TextChanged(object sender, EventArgs e)
        {
            if (groupName.Text != "" && studentsCount.Text != "" && headmanId.Text != "" && specialCode.Text != "") createButton.Enabled = true;
            else createButton.Enabled = false;

            if (flowLayoutPanel1.Controls.Count == 0) return;

            if (headmanId.Text == "" || headmanId.Text == "0") headmanId.Text = "1";
            else if (int.Parse(headmanId.Text) > flowLayoutPanel1.Controls.Count) headmanId.Text = flowLayoutPanel1.Controls.Count.ToString();
        }

        private void HeadmanId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08) e.Handled = true;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (curatorInfoGroupBox.BoxIsFill())
            {
                foreach (HumanInfoGroupBox i in flowLayoutPanel1.Controls)
                {
                    if (!i.BoxIsFill())
                    {
                        MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                var outer = Task.Factory.StartNew(CreateXmlFile);
                outer.Wait();

                mainForm.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GroupName_TextChanged(object sender, EventArgs e)
        {
            if (groupName.Text != "" && studentsCount.Text != "" && headmanId.Text != "" && specialCode.Text != "") createButton.Enabled = true;
            else createButton.Enabled = false;
        }

        private void SpecialCode_TextChanged(object sender, EventArgs e)
        {
            if (groupName.Text != "" && studentsCount.Text != "" && headmanId.Text != "" && specialCode.Text != "") createButton.Enabled = true;
            else createButton.Enabled = false;
        }

        private void CreateFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void CreateXmlFile()
        {
            string code = specialCode.Text; //код группы
            string name = groupName.Text; //наименование группы
            int headman = int.Parse(headmanId.Text); //ид старосты

            //куратор
            string curatorName = curatorInfoGroupBox.GetName();
            string curatorVkUrl = curatorInfoGroupBox.GetVkUrl();
            int curatorPhone = curatorInfoGroupBox.GetPhone();

            Human curator = new Human(curatorName, curatorVkUrl, curatorPhone);


            //студенты
            List<Human> students = new List<Human>();

            foreach(HumanInfoGroupBox student in flowLayoutPanel1.Controls)
            {
                string studentName = student.GetName();
                string vkUrl = student.GetVkUrl();
                int phone = student.GetPhone();

                students.Add(new Human(studentName, vkUrl, phone));
            }

            Group group = new Group(code, name, curator, headman, students);
            Group.CreateXml(group);

            if (isEditing) MainForm.CurrentGroup = group;
        }
    }
}