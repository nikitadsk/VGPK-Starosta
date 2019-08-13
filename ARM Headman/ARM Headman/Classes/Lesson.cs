using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_Headman
{
    public class Lesson
    {
        public string LessonName { get; set; }
        public List<(int, int, int)> Skipping { get; set; }

        public Lesson(string lessonName)
        {
            LessonName = lessonName;
            Skipping = new List<(int, int, int)>();
        }

        public Lesson(string lessonName, List<(int, int, int)> skipping)
        {
            LessonName = lessonName;
            Skipping = skipping;
        }

    }
}
