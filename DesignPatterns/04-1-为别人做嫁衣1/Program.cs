using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_1_为别人做嫁衣1
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl jiaojiao = new SchoolGirl();
            jiaojiao.Name = "娇娇";

            Pursuit zhuojiayi = new Pursuit(jiaojiao);

            zhuojiayi.GiveDolls();
            zhuojiayi.GiveFlowers();
            zhuojiayi.GiveChocolate();

            Console.ReadLine();
        }
    }
}
