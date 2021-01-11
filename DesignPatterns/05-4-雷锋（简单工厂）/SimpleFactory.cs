﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_4_雷锋_简单工厂_
{
    public class SimpleFactory
    {
        public static LeiFeng CreateLeiFeng(string type)
        {
            LeiFeng result = null;

            switch (type)
            {
                case "学雷锋的大学生":
                    result = new Undergraduate();
                    break;
                case "社区志愿者":
                    result = new Volunteer();
                    break;
            }

            return result;
        }
    }
}
