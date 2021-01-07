using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_5_商场收银_策略_工厂_
{
    public class CashNormal:CashSuper
    {
        /// <summary>
        /// 正常收费类
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public override double AcceptCash(double money)
        {
            return money;
        }
    }
}
