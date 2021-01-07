using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_1_小菜扮靓1
{
    public class Person
    {
        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public void WearTShirts()
        {
            Console.WriteLine("大T恤");
        }

        public void WearBigTrouser()
        {
            Console.WriteLine("垮裤");
        }

        public void WearSneakers()
        {
            Console.WriteLine("破球鞋");
        }

        public void WearSuit()
        {
            Console.WriteLine("西装");
        }

        public void WearTie()
        {
            Console.WriteLine("领带");
        }

        public void WearLeatherShoes()
        {
            Console.WriteLine("皮鞋");
        }

        public void Show()
        {
            Console.WriteLine("装扮的" + name);
        }

    }
}
