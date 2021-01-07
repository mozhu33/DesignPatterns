using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_5_商场收银_策略_工厂_
{
    public class CashContext
    {
        CashSuper cs = null;

        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    cs = new CashNormal();
                    break;
                case "满300返100":
                    cs = new CashReturn("300", "100");
                    break;
                case "打8折":
                    cs = new CashRebate("0.8");
                    break;
            }
        }

        public double GetResult(double money)
        {
            return cs.AcceptCash(money);
        }
    }
}
