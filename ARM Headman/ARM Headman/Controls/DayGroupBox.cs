using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM_Headman.Controls
{
    public partial class DayGroupBox : UserControl
    {
        public DayGroupBox()
        {
            InitializeComponent();
        }

        public DayGroupBox(int num)
        {
            InitializeComponent();
            dayNum.Text = $"День {num}";
        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void LessonNum_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (lessonNum.Text == "") return;
            for (int i = 0; i < int.Parse(lessonNum.Text); i++)
            {
                flowLayoutPanel1.Controls.Add(new LessonGroupBox(i + 1));
            }
        }

        private void DayGroupBox_Load(object sender, EventArgs e)
        {
            lessonNum.Text = "1";
        }

        public void SetDay(Day day)
        {
            lessonNum.Text = (day.Lessons.Count / 2).ToString();
            int i = 0;
            foreach (LessonGroupBox lesson in flowLayoutPanel1.Controls)
            {
                lesson.SetLessons(day.Lessons[i], day.Lessons[i + 1]);
                i += 2;
            }
        } 
    }
}
