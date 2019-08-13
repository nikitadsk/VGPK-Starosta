using System.Collections.Generic;
using System.Xml.Linq;
using System.Windows.Forms;
using System.IO;

namespace ARM_Headman
{
    public class Group
    {
        public string SpecialCode { get; set; }
        public string GroupName { get; set; }
        public Human Curator { get; set; }
        public int HeadmanId { get; set; }
        public List<Human> Students { get; set; }

        public Group(string specialCode, string groupName, Human curator, int headmanId, List<Human> students)
        {
            SpecialCode = specialCode;
            GroupName = groupName;
            Curator = curator;
            HeadmanId = headmanId;
            Students = students;
        }

        public string GetStudentName(int id)
        {
            return Students[id - 1].ToString();
        }

        public static void CreateXml(Group group)
        {
            XDocument xDoc = new XDocument();
            XElement root = new XElement("group");

            XElement specialCode = new XElement("specialCode", group.SpecialCode);
            XElement groupName = new XElement("groupName", group.GroupName);

            //Информация про куратора
            XElement curator = new XElement("curator");
            XElement curatorName = new XElement("curatorName", $"{group.Curator.FullName}");
            XElement curatorVkUrl = new XElement("curatorVkUrl", $"{group.Curator.VkUrl}");
            XElement curatorPhone = new XElement("curatorPhone", group.Curator.Phone);

            curator.Add(curatorName, curatorVkUrl, curatorPhone);

            XElement headmanId = new XElement("headmanId", group.HeadmanId); //id старосты

            //Информация о студентах
            XElement students = new XElement("students");
            foreach (Human i in group.Students)
            {
                XElement student = new XElement("student");
                XElement studentName = new XElement("studentName", $"{i.FullName}");
                XElement studentVkUrl = new XElement("studentVkUrl", $"{i.VkUrl}");
                XElement studentPhone = new XElement("studentPhone", i.Phone);

                student.Add(studentName, studentVkUrl, studentPhone);
                students.Add(student);
            }

            root.Add(specialCode, groupName, curator, headmanId, students);
            xDoc.Add(root);
            xDoc.Save($@"Files\GroupFiles\{group.GroupName}.xml");

            Directory.CreateDirectory($@"{Directory.GetCurrentDirectory()}\Files\ReportFiles\{group.GroupName}");
            Directory.CreateDirectory($@"{Directory.GetCurrentDirectory()}\Files\ExcelReport\{group.GroupName}");
            Directory.CreateDirectory($@"{Directory.GetCurrentDirectory()}\Files\ExcelVedomost\{group.GroupName}");

            MessageBox.Show("Группа записана в файл", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static Group GetGroupFromXml(string path)
        {
            XDocument xDoc = XDocument.Load(path);

            string specialCode = xDoc.Element("group").Element("specialCode").Value;
            string groupName = xDoc.Element("group").Element("groupName").Value;

            //получение информации о кураторе
            string curatorName = xDoc.Element("group").Element("curator").Element("curatorName").Value;
            string vkUrl = xDoc.Element("group").Element("curator").Element("curatorVkUrl").Value;
            string curatorVkUrl = vkUrl.Substring(vkUrl.IndexOf('/') + 1);
            int curatorPhone = int.Parse(xDoc.Element("group").Element("curator").Element("curatorPhone").Value);
            Human curator = new Human(curatorName, curatorVkUrl, curatorPhone);

            int headmanId = int.Parse(xDoc.Element("group").Element("headmanId").Value); //id старосты

            List<Human> students = new List<Human>();
            foreach (var i in xDoc.Element("group").Element("students").Elements("student"))
            {
                string studentName = i.Element("studentName").Value;
                vkUrl = i.Element("studentVkUrl").Value;
                string studentVkUrl = vkUrl.Substring(vkUrl.IndexOf('/') + 1);
                int studentPhone;
                try
                {
                    studentPhone = int.Parse(i.Element("studentPhone").Value);
                }
                catch { studentPhone = 0; }

                students.Add(new Human(studentName, studentVkUrl, studentPhone));
            }

            return new Group(specialCode, groupName, curator, headmanId, students);
        }
    }
}