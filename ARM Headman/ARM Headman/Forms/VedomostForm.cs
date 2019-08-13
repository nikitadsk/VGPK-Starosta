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
using Excel = Microsoft.Office.Interop.Excel;

namespace ARM_Headman
{
    public partial class VedomostForm : Form
    {
        private Excel.Application excelApp = new Excel.Application();

        public List<Day> Days = new List<Day>();

        public VedomostForm()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Days.Clear();
            int count = 0;
            switch (monthComboBox.SelectedIndex)
            {
                case 0: case 2: case 4: case 6:
                case 7: case 9: case 11:
                    count = 31;
                    break;

                case 3: case 5: case 8: case 10:
                    count = 30;
                    break;
                case 1:
                    if (int.Parse(yearTextBox.Text) % 4 == 0) count = 29;
                    else count = 28;
                    break;

            }

            for (int i = 1; i <= count; i++)
            {
                Label l = new Label
                {
                    AutoSize = true,
                    Font = new Font("Microsoft Sans Serif", 9),
                    Text = i.ToString()
                };
                flowLayoutPanel1.Controls.Add(l);
            }
        }

        private void VedomostForm_Load(object sender, EventArgs e)
        {
            var dir = new DirectoryInfo($@"{Directory.GetCurrentDirectory()}\Files\ReportFiles\{MainForm.CurrentGroup.GroupName}\");

            foreach (FileInfo file in dir.GetFiles())
            {
                reportFiles.Items.Add(Path.GetFileNameWithoutExtension(file.FullName));
            }

            yearTextBox.Text = DateTime.Now.Year.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Days.Clear();
            foreach (var file in reportFiles.Items)
            {
                Report report = Report.GetReportFromXml(file.ToString());

                foreach (var day in report.Days)
                {
                    //проверка, записан ли у нас уже этот день, подходит ли месяц и год
                    if (!Days.Contains(day) && day.Date.Month == monthComboBox.SelectedIndex + 1 && day.Date.Year == int.Parse(yearTextBox.Text))
                    {
                        Days.Add(day);
                        (flowLayoutPanel1.Controls[day.Date.Day - 1] as Label).ForeColor = Color.Green;
                    }
                }
            }
        }

        private void ShowExcel(string month, int year)
        {
            File.Copy($@"{Directory.GetCurrentDirectory()}\Files\DefaultFiles\EmptyVedomost.xlsx", $@"{Directory.GetCurrentDirectory()}\Files\ExcelVedomost\{MainForm.CurrentGroup.GroupName}\{month}{year}.xlsx", true);
            excelApp.Workbooks.Open($@"{Directory.GetCurrentDirectory()}\Files\ExcelVedomost\{MainForm.CurrentGroup.GroupName}\{month}{year}.xlsx");

            //шапка ведомости
            excelApp.Cells[4, 1].Value = $"за {month} {year} г.";
            excelApp.Cells[5, 1].Value = $"Спецыяльнасць {MainForm.CurrentGroup.SpecialCode} курс _____ група {MainForm.CurrentGroup.GroupName}";

            //заполнение списка учащихся
            int i = 1;
            foreach (var student in MainForm.CurrentGroup.Students)
            {
                string[] info = student.FullName.Split(' ');
                excelApp.Cells[8 + i, 2].Value = $"{info[0]} {info[1][0]}. {info[2][0]}.";
                i++;
            }

            //запись в ведомость
            foreach(var day in Days)
            {
                int firstDayX = day.Date.Day + 2;

                foreach(var lesson in day.Lessons)
                {
                    foreach(var skipping in lesson.Skipping)
                    {
                        excelApp.Cells[8 + skipping.Item1, firstDayX].Value++;

                        if (skipping.Item3 == 1)
                        {
                            excelApp.Cells[8 + skipping.Item1, 35].Value++;
                            excelApp.Cells[8 + skipping.Item1, firstDayX].Font.Underline = true;
                        }
                        else excelApp.Cells[8 + skipping.Item1, 34].Value++;
                    }
                }
            }

            excelApp.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ShowExcel(monthComboBox.SelectedItem.ToString(), int.Parse(yearTextBox.Text));
        }
    }
}
