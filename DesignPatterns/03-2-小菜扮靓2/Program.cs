using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_2_小菜扮靓2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person("小菜");
            Console.WriteLine("\n第一种装扮:");
            Finery dtx = new TShirts();
            dtx.Show();
            xc.Show();

            Console.WriteLine("\n第二种装扮:");
            Finery kk = new BigTrouser();
            kk.Show();
            xc.Show();

            Console.ReadLine();
        }
    }
}
