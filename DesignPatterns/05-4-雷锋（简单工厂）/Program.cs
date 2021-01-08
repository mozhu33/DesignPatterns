using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_4_雷锋_简单工厂_
{
    class Program
    {
        static void Main(string[] args)
        {
            LeiFeng studentA = SimpleFactory.CreateLeiFeng("学雷锋的大学生");
            studentA.Sweep();
            LeiFeng studentB = SimpleFactory.CreateLeiFeng("学雷锋的大学生");
            studentB.Wash();
            LeiFeng volunteer = SimpleFactory.CreateLeiFeng("社区志愿者");
            volunteer.BuyRice();

            Console.ReadLine();
        }
    }
}
