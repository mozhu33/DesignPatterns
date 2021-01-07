using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_3_装饰模式
{
   public class ConcreteComponent:Component
    {

        public override void Operation()
        {
            Console.WriteLine("具体对象的操作");
        }
    }
}
