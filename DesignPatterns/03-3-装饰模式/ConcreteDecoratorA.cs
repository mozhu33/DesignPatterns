using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_3_装饰模式
{
    public class ConcreteDecoratorA:Decorator
    {
        private string addedState;

        public override void Operation()
        {
            base.Operation();
            addedState = "New State";
            Console.WriteLine("具体装饰对象A的操作");
        }

    }
}
