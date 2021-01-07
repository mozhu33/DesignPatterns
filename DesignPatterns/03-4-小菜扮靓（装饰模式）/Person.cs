using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_4_小菜扮靓_装饰模式_
{
    public class Person
    {
        public Person()
        {}

        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("装扮的" + name);
        }
    }
}
