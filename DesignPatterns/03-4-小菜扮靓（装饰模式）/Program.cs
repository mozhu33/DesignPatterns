using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_4_小菜扮靓_装饰模式_
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person("小菜");

            BigTrouser bgt = new BigTrouser();
            TShirts tsh = new TShirts();

            //bgt.Decorate(tsh);
            tsh.Decorate(bgt);
            tsh.Show();
            Console.WriteLine("\n第一种装扮");

            Console.ReadLine();
        }
    }
}
