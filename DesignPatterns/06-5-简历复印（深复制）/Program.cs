﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_5_简历复印_深复制_
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("大鸟");
            a.SetPersonalInfo("男", "29");
            a.SetWorkExperience("1998-2000", "xx公司");

            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("2000-2003", "YYY企业");

            Resume c = (Resume)a.Clone();
            c.SetWorkExperience("2004-2006", "hhhh");

            a.Display();
            b.Display();
            c.Display();

            Console.ReadLine();
        }
    }
}
