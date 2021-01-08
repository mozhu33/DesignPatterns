using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_1_为别人做嫁衣1
{
    /// <summary>
    /// 追求者类
    /// </summary>
    public class Pursuit
    {
        SchoolGirl mm;
        public Pursuit(SchoolGirl mm)
        {
            this.mm = mm;
        }

        public void GiveDolls()
        {
            Console.WriteLine(mm.Name + "送你洋娃娃");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(mm.Name + "送你鲜花");
        }

        public void GiveChocolate()
        {
            Console.WriteLine(mm.Name + "送你巧克力");
        }

    }
}
