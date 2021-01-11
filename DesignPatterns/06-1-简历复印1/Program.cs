using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_1_简历复印1
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("大鸟");
            a.SetPersonalInfo("男", "29");
            a.SetWorkExperience("1998-2000", "XX公司");

            Resume b = new Resume("大鸟");
            b.SetPersonalInfo("男", "29");
            b.SetWorkExperience("1998-2000", "XX公司");

            a.Display();
            b.Display();

            Console.ReadLine();
        }
    }
}
