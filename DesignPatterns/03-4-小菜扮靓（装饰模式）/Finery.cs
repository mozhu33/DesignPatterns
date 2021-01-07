using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_4_小菜扮靓_装饰模式_
{
    public class Finery:Person
    {
        protected Person component;

        public void Decorate(Person component)
        {
            this.component = component;
        }

        public override void Show()
        {
            if (component != null)
            {
                component.Show();
            }
        }
    }
}
