using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_1_小菜扮靓1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person("小菜");

            Console.WriteLine("\n 第一种装扮：");
            xc.WearTShirts();
            xc.WearBigTrouser();
            xc.WearSneakers();
            xc.Show();

            Console.WriteLine("\n第二种装扮：");
            xc.WearSuit();
            xc.WearTie();
            xc.WearLeatherShoes();
            xc.Show();

            Console.ReadLine();
        }
    }
}
