﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_2_计算器2
{
    public class Operation
    {
        public static double GetResult(double numberA, double numberB, string operate)
        {
            double result= 0d;

            switch (operate)
            {
                case "+":
                    result = numberA + numberB;
                    break;
                case "-":
                    result = numberA - numberB;
                    break;
                case "*":
                    result = numberA * numberB;
                    break;
                case "/":
                    result = numberA / numberB;
                    break;
            }

            return result;
        }
    }
}
