using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_3_计算器3
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper;
            oper = OperationFactory.CreateOperate("+");
            oper.NumberA = 1;
            oper.NumberB = 2;
            double result1 = oper.GetResult();

            oper = OperationFactory.CreateOperate("-");
            oper.NumberA = 2;
            oper.NumberB = 1;
            double result2 = oper.GetResult();

            Console.WriteLine($"运算结果分别是：{result1},{result2}");

            Console.ReadLine();
        }
    }
}
