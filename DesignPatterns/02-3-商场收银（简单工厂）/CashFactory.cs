using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_3_商场收银_简单工厂_
{
    public class CashFactory
    {
        public static CashSuper CreateCashAccept(string type)
        {
            CashSuper cashSuper = null;

            switch (type)
            {
                case "正常收费":
                    cashSuper = new CashNormal();
                    break;
                case "满300返100":
                    cashSuper = new CashReturn("300", "100");
                    break;
                case "打8折":
                    cashSuper = new CashRebate("0.8");
                    break;
            }

            return cashSuper;
        }
    }
}
