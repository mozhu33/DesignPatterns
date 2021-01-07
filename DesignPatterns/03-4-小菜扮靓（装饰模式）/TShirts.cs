using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_4_小菜扮靓_装饰模式_
{
    public class TShirts:Finery
    {
        public override void Show()
        {
            Console.WriteLine("大T恤");
            base.Show();
        }
    }
}
