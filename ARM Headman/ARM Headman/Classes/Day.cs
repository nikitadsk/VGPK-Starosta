using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_Headman
{
    public class Day
    {
        public DateTime Date { get; set; }
        public List<Lesson> Lessons { get; set; }

        public Day(DateTime date, List<Lesson> lessons)
        {
            Date = date;
            Lessons = lessons;
        }
    }
}
