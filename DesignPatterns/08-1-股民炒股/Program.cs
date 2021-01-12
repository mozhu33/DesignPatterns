using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_1_股民炒股
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock1 gu1 = new Stock1();
            Stock2 gu2 = new Stock2();
            Stock3 gu3 = new Stock3();
            NationalDebt1 nd1 = new NationalDebt1();
            Realty1 rt1 = new Realty1();

            gu1.Buy();
            gu2.Buy();
            gu3.Buy();
            nd1.Buy();
            rt1.Buy();

            gu1.Sell();
            gu2.Sell();
            gu3.Sell();
            nd1.Sell();
            rt1.Sell();

            Console.Read();
        }
    }
}
