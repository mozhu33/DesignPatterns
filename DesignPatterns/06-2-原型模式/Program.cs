using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_2_原型模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype p1 = new ConcretePrototype("I");
            ConcretePrototype c1 = (ConcretePrototype)p1.Clone();
            Console.WriteLine($"cloned:{c1.Id}");

            Console.ReadLine();
        }
    }
}
