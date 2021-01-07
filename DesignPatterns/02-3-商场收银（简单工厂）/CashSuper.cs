﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_3_商场收银_简单工厂_
{
    /// <summary>
    /// 现金收费抽象类
    /// </summary>
    public abstract class CashSuper
    {
        /// <summary>
        /// 参数为原价，返回值为当前价
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public abstract double AcceptCash(double money);
    }
}
