using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_5_商场收银_策略_工厂_
{
    /// <summary>
    /// 打折收费类
    /// </summary>
    public class CashRebate:CashSuper
    {
        private double moneyRebate = 1d;

        public CashRebate(string moneyRebate)
        {
            this.moneyRebate = double.Parse(moneyRebate);
        }

        public override double AcceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
}
