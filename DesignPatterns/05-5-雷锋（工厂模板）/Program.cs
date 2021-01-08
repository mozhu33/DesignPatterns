using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_5_雷锋_工厂模板_
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new UndergraduateFactory();
            LeiFeng student = factory.CreateLeiFeng();

            student.Wash();
            student.Sweep();
            student.BuyRice();

            Console.ReadLine();

        }
    }
}
