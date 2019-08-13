using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.IO;

namespace ARM_Headman
{
    public class Report
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public List<Day> Days { get; set; }

        public Report(string startDate, string endDate, List<Day> days)
        {
            StartDate = startDate;
            EndDate = endDate;
            Days = days;
        }

        public static Report GetReportFromXml(string fileName)
        {
            XDocument xDoc = XDocument.Load($@"{Directory.GetCurrentDirectory()}\Files\ReportFiles\{MainForm.CurrentGroup.GroupName}\{fileName}.xml");
            XElement root = xDoc.Element("report");
            List<Day> reportDays = new List<Day>();

            foreach (var day in root.Element("days").Elements("day"))
            {
                DateTime dayDate = DateTime.Parse(day.Element("dayDate").Value);
                List<Lesson> dayLessons = new List<Lesson>();

                foreach (var lesson in day.Element("lessons").Elements("lesson"))
                {
                    string lessonName = lesson.Element("lessonName").Value;
                    List<(int, int, int)> lessonSkippings = new List<(int, int, int)>();

                    foreach (var skipping in lesson.Element("skippings").Elements("skipping"))
                    {
                        int studentId = int.Parse(skipping.Element("studentId").Value);
                        int skippingHour = int.Parse(skipping.Element("skippingHour").Value);
                        int skippingDisrespectful = int.Parse(skipping.Element("skippingDisrespectful").Value);

                        lessonSkippings.Add((studentId, skippingHour, skippingDisrespectful));
                    }

                    dayLessons.Add(new Lesson(lessonName, lessonSkippings));
                }

                reportDays.Add(new Day(dayDate, dayLessons));
            }

            string reportFirstDate = root.Element("date").Value;
            string reportLastDate = $"{reportDays[reportDays.Count - 1].Date.Day}.{reportDays[reportDays.Count - 1].Date.Month}.{reportDays[reportDays.Count - 1].Date.Year}";

            return new Report(reportFirstDate, reportLastDate, reportDays);
        }
    }
}
