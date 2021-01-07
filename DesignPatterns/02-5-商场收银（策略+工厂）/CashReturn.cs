using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_5_商场收银_策略_工厂_
{
    /// <summary>
    /// 返利收费类
    /// </summary>
    public class CashReturn : CashSuper
    {
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;

        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }

        public override double AcceptCash(double money)
        {
            double result = money;
            if (money > moneyCondition) //若大于返利条件，则需要减去返利值
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;

            return result;
        }
    }
}
