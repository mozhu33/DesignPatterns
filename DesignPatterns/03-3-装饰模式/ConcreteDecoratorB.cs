using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_3_装饰模式
{
    public class ConcreteDecoratorB:Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("具体装饰类对象B的操作");
        }

        private void AddedBehavior()
        { }
    }
}
