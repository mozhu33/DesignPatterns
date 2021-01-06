using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_4_商场收银_策略模式_
{
    public class CashContext
    {
        private CashSuper cs;
        public CashContext(CashSuper csuper)  //通过构造方法，传入具体的收费策略
        {
            this.cs = csuper;
        }

        public double GetResult(double money)
        {
            return cs.AcceptCash(money);  //根据收费策略的不同，获得计算结果
        }
    }
}
