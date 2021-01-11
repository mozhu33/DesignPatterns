using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_2_抄试卷2
{
    public class TestPaperA:TestPaper
    {
        public new void TestQuestion1()
        {
            base.TestQuestion1();
            Console.WriteLine("答案：b");
        }

        public new void TestQuestion2()
        {
            base.TestQuestion2();
            Console.WriteLine("答案：a");
        }

        public new void TestQuestion3()
        {
            base.TestQuestion3();
            Console.WriteLine("答案：b");
        }
    }
}
