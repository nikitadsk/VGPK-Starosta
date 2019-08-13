using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ARM_Headman.Controls
{
    public partial class LessonGroupBox : UserControl
    {
        public LessonGroupBox()
        {
            InitializeComponent();
        }

        public LessonGroupBox(int num)
        {
            InitializeComponent();
            lessonNum.Text = $"Пара {num}";
        }

        private void LessonGroupBox_Load(object sender, EventArgs e)
        {
            int number = 1;
            foreach (var i in MainForm.CurrentGroup.Students)
            {
                string[] info = i.FullName.Split(' ');
                studentList1.Items.Add($"{info[0]} {info[1][0]}. {info[2][0]}. {number}");
                studentList2.Items.Add($"{info[0]} {info[1][0]}. {info[2][0]}. {number}");
                number++;
            }

        }

        private void LessonName1_TextChanged(object sender, EventArgs e)
        {
            lessonName2.Text = lessonName1.Text;
        }

        public (string, string) GetLessonsName()
        {
            return (lessonName1.Text, lessonName2.Text);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (studentList1.SelectedIndex != -1)
            {
                if (sender != lessonName1)
                {
                    studentList2.Items.Remove(studentList1.SelectedItem);
                    if (!respectfulList2.Items.Contains(studentList1.SelectedItem)) respectfulList2.Items.Add(studentList1.SelectedItem);
                    respectfulList1.Items.Add(studentList1.SelectedItem);
                    studentList1.Items.Remove(studentList1.SelectedItem);
                }
                else
                {
                    respectfulList1.Items.Add(studentList1.SelectedItem);
                    studentList1.Items.Remove(studentList1.SelectedItem);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (studentList1.SelectedIndex != -1)
            {
                if (sender != lessonName1)
                {
                    if (!disrespectfulList2.Items.Contains(studentList1.SelectedItem)) disrespectfulList2.Items.Add(studentList1.SelectedItem);
                    studentList2.Items.Remove(studentList1.SelectedItem);
                    disrespectfulList1.Items.Add(studentList1.SelectedItem);
                    studentList1.Items.Remove(studentList1.SelectedItem);
                }
                else
                {
                    disrespectfulList1.Items.Add(studentList1.SelectedItem);
                    studentList1.Items.Remove(studentList1.SelectedItem);
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (studentList2.SelectedIndex != -1)
            {
                respectfulList2.Items.Add(studentList2.SelectedItem);
                studentList2.Items.Remove(studentList2.SelectedItem);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (studentList2.SelectedIndex != -1)
            {
                disrespectfulList2.Items.Add(studentList2.SelectedItem);
                studentList2.Items.Remove(studentList2.SelectedItem);
            }
        }

        public List<(int, int, int)> GetSkipping1()
        {
            List<(int, int, int)> result = new List<(int, int, int)>();
            foreach(string i in respectfulList1.Items)
            {
                int studentId = int.Parse(i.Remove(0, i.LastIndexOf(' ')));
                result.Add((studentId, 1, 0));
            }

            foreach (string i in disrespectfulList1.Items)
            {
                int studentId = int.Parse(i.Remove(0, i.LastIndexOf(' ')));
                result.Add((studentId, 1, 1));
            }
            result.Sort();
            return result;
        }

        public List<(int, int, int)> GetSkipping2()
        {
            List<(int, int, int)> result = new List<(int, int, int)>();
            foreach (string i in respectfulList2.Items)
            {
                int studentId = int.Parse(i.Remove(0, i.LastIndexOf(' ')));
                result.Add((studentId, 1, 0));
            }

            foreach (string i in disrespectfulList2.Items)
            {
                int studentId = int.Parse(i.Remove(0, i.LastIndexOf(' ')));
                result.Add((studentId, 1, 1));
            }
            result.Sort();
            return result;
        }

        private void RespectfulList1_DoubleClick(object sender, EventArgs e)
        {
            if (respectfulList1.SelectedIndex != -1)
            {
                studentList1.Items.Add(respectfulList1.SelectedItem);
                respectfulList1.Items.Remove(respectfulList1.SelectedItem);
            }
        }

        private void DisrespectfulList1_DoubleClick(object sender, EventArgs e)
        {
            if (disrespectfulList1.SelectedIndex != -1)
            {
                studentList1.Items.Add(disrespectfulList1.SelectedItem);
                disrespectfulList1.Items.Remove(disrespectfulList1.SelectedItem);
            }
        }

        private void RespectfulList2_DoubleClick(object sender, EventArgs e)
        {
            if (respectfulList2.SelectedIndex != -1)
            {
                studentList2.Items.Add(respectfulList2.SelectedItem);
                respectfulList2.Items.Remove(respectfulList2.SelectedItem);
            }
        }

        private void DisrespectfulList2_DoubleClick(object sender, EventArgs e)
        {
            if (disrespectfulList2.SelectedIndex != -1)
            {
                studentList2.Items.Add(disrespectfulList2.SelectedItem);
                disrespectfulList2.Items.Remove(disrespectfulList2.SelectedItem);
            }
        }

        public void SetLessons(Lesson l1, Lesson l2)
        {
            lessonName1.Text = l1.LessonName;
            lessonName2.Text = l2.LessonName;

            //l1.Skipping.Reverse();
            //l2.Skipping.Reverse();
            foreach (var skipping in l2.Skipping)
            {
                studentList2.SelectedIndex = studentList2.FindString($"{MainForm.CurrentGroup.GetStudentName(skipping.Item1)} {skipping.Item1}");
                if (skipping.Item2 == 1)
                {
                    if (skipping.Item3 == 1) Button3_Click(this, EventArgs.Empty);
                    else Button4_Click(this, EventArgs.Empty);
                }
            }

            foreach (var skipping in l1.Skipping)
            {
                studentList1.SelectedIndex = studentList1.FindString($"{MainForm.CurrentGroup.GetStudentName(skipping.Item1)} {skipping.Item1}");
                if (skipping.Item2 == 1)
                {
                    if (skipping.Item3 == 1)
                    {
                        Button2_Click(lessonName1, EventArgs.Empty);
                    }

                    else
                    {
                        Button1_Click(lessonName1, EventArgs.Empty);
                    }
                }
            }
        }
    }
}