using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_Headman
{
    public class Human
    {
        public string FullName { get; set; }
        public string VkUrl { get; set; }
        public int Phone { get; set; } //телефон формата (33)305-55-32 (БЕЗ ТИРЕ И СКОБОК)

        public Human(string fullName, string vkUrl, int phone)
        {
            FullName = fullName;
            VkUrl = vkUrl;
            Phone = phone;
        }

        public override string ToString()
        {
            string[] info = FullName.Split(' ');
            return $"{info[0]} {info[1][0]}. {info[2][0]}.";
        }
    }
}
