using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_3_为别人做嫁衣3_代理模式_
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl jiaojiao = new SchoolGirl();
            jiaojiao.Name = "娇娇";

            Proxy daili = new Proxy(jiaojiao);
            daili.GiveDolls();
            daili.GiveFlowers();
            daili.GiveChocolate();

            Console.ReadLine();
        }
    }
}
