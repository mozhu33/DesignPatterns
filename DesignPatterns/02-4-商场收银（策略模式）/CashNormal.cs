using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_4_商场收银_策略模式_
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
