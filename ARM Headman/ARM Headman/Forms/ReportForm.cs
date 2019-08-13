using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using ARM_Headman.Controls;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace ARM_Headman
{
    public partial class ReportForm : Form
    {
        private Excel.Application excelApp = new Excel.Application();

        public ReportForm()
        {
            InitializeComponent();
        }

        private void CountLessons_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void CountLessons_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (dayCount.Text == "") return;

            for (int i = 0; i < int.Parse(dayCount.Text); i++)
            {
                flowLayoutPanel1.Controls.Add(new DayGroupBox(i + 1));
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var outer = Task.Factory.StartNew(CreateReportFile);
            outer.Wait();
            ReportForm_Load(this, EventArgs.Empty);
            dayCount.Text = "0";
        }

        private void CreateReportFile()
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\Files\ReportFiles\{MainForm.CurrentGroup.GroupName}\";
                XDocument xDoc = new XDocument();

                XElement root = new XElement("report");
                XElement date = new XElement("date", reportFirstDate.Text);
                XElement days = new XElement("days");

                int dayNumber = 0;
                foreach (DayGroupBox dayGroupBox in flowLayoutPanel1.Controls)
                {
                    XElement day = new XElement("day");
                    XElement dayDate = new XElement("dayDate", DateTime.Parse(reportFirstDate.Text).AddDays(dayNumber));
                    XElement lessons = new XElement("lessons");
                    foreach (LessonGroupBox lessonGroupBox in dayGroupBox.flowLayoutPanel1.Controls)
                    {
                        XElement lesson1 = new XElement("lesson");
                        XElement lesson2 = new XElement("lesson");

                        XElement skippings1 = new XElement("skippings");
                        XElement skippings2 = new XElement("skippings");

                        foreach (var i in lessonGroupBox.GetSkipping1())
                        {
                            skippings1.Add(new XElement("skipping",
                                new XElement("studentId", i.Item1),
                                new XElement("skippingHour", i.Item2),
                                new XElement("skippingDisrespectful", i.Item3)));
                        }

                        foreach (var i in lessonGroupBox.GetSkipping2())
                        {
                            skippings2.Add(new XElement("skipping",
                                new XElement("studentId", i.Item1),
                                new XElement("skippingHour", i.Item2),
                                new XElement("skippingDisrespectful", i.Item3)));
                        }

                        lesson1.Add(new XElement("lessonName", lessonGroupBox.GetLessonsName().Item1), skippings1);
                        lesson2.Add(new XElement("lessonName", lessonGroupBox.GetLessonsName().Item2), skippings2);

                        lessons.Add(lesson1, lesson2);
                    }
                    day.Add(dayDate, lessons);
                    days.Add(day);
                    dayNumber++;
                }
                root.Add(date, days);
                xDoc.Add(root);
                DateTime fileDate = DateTime.Parse(reportFirstDate.Text);
                string fileName = $"{fileDate.Day}_{fileDate.Month}_{fileDate.Year}_" +
                                  $"{fileDate.AddDays(dayNumber - 1).Day}_{fileDate.AddDays(dayNumber - 1).Month}_{fileDate.AddDays(dayNumber - 1).Year}.xml";
                if (File.Exists($"{path}{fileName}")) File.Delete($"{path}{fileName}");
                xDoc.Save($"{path}{fileName}");
                MessageBox.Show("Записано :)");
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            reportFiles.Items.Clear();
            var dir = new DirectoryInfo($@"{Directory.GetCurrentDirectory()}\Files\ReportFiles\{MainForm.CurrentGroup.GroupName}\");

            foreach (FileInfo file in dir.GetFiles())
            {
                reportFiles.Items.Add(Path.GetFileNameWithoutExtension(file.FullName));
            }
        }

        private void ShowExcel(Report report, string fileName)
        {
            File.Copy($@"{Directory.GetCurrentDirectory()}\Files\DefaultFiles\EmptyRap.xlsx", $@"{Directory.GetCurrentDirectory()}\Files\ExcelReport\{MainForm.CurrentGroup.GroupName}\{fileName}.xlsx", true);
            excelApp.Workbooks.Open($@"{Directory.GetCurrentDirectory()}\Files\ExcelReport\{MainForm.CurrentGroup.GroupName}\{fileName}.xlsx");

            excelApp.Cells[1, 1].Value = $"Учет посещаемости занятий учащимися группы {MainForm.CurrentGroup.GroupName} " +
                                         $"с {report.StartDate} по {report.EndDate}  " +
                                         $"Староста: {MainForm.CurrentGroup.Students[MainForm.CurrentGroup.HeadmanId - 1].FullName} " +
                                         $"Куратор: {MainForm.CurrentGroup.Curator.FullName}";
            int i = 1;
            foreach(var student in MainForm.CurrentGroup.Students)
            {
                string[] info = student.FullName.Split(' ');
                excelApp.Cells[4 + i, 1].Value = i;
                excelApp.Cells[4 + i, 2].Value = $"{info[0]} {info[1][0]}. {info[2][0]}."; //Interior.Color - цвет фона ячейка, Font.Color - цвет текста
                i++;
            }

            int dayNum = 0;
            foreach(var day in report.Days)
            {
                int firstDayCellX = dayNum * 10 + 3;
                excelApp.Cells[2, firstDayCellX].Value = $"{day.Date.Day}.{day.Date.Month}.{day.Date.Year}"; //записываем дату
                dayNum++;

                int lessonNum = 0;
                foreach(var lesson in day.Lessons)
                {
                    int lessonCellX = firstDayCellX + lessonNum;
                    excelApp.Cells[35, lessonCellX].Value = lesson.LessonName; //название пары
                    foreach(var skipping in lesson.Skipping)
                    {
                        excelApp.Cells[4 + skipping.Item1, lessonCellX].Value = skipping.Item2;
                        if (skipping.Item3 == 1)
                        {
                            excelApp.Cells[4 + skipping.Item1, lessonCellX].Interior.Color = Color.Red; //меняем цвет неуважительной причины
                            excelApp.Cells[4 + skipping.Item1, 64].Value += 1; //записываем в итог недели по неуважительным причинам
                        }
                    }
                    lessonNum++;
                }
            }

            excelApp.Visible = true;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            string fileName = reportFiles.SelectedItem.ToString();
            Task.Factory.StartNew(() => ShowExcel(Report.GetReportFromXml(fileName), fileName));
        }

        private void ReportFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reportFiles.SelectedIndex != -1)
            {
                openButton.Enabled = true;
                editButton.Enabled = true;
            }
            else
            {
                openButton.Enabled = false;
                editButton.Enabled = false;
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string fileName = reportFiles.SelectedItem.ToString();
            Report report = Report.GetReportFromXml(fileName);

            dayCount.Text = report.Days.Count.ToString();
            reportFirstDate.Text = report.StartDate.ToString();

            int i = 0;
            foreach(DayGroupBox day in flowLayoutPanel1.Controls)
            {
                day.SetDay(report.Days[i]);
                i++;
            }
            reportFiles.SelectedIndex = -1;
        }
    }
}