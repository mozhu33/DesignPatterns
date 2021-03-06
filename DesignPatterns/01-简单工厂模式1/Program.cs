﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_简单工厂模式1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("请输入数字A：");
                string strNumberA = Console.ReadLine();
                Console.WriteLine("请选择运算符号(+、-、*、、):");
                string strOperate = Console.ReadLine();
                Console.WriteLine("请输入数字B：");
                string strNumberB = Console.ReadLine();

                string strResult = "";

                switch (strOperate)
                {
                    case "+":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) + Convert.ToDouble(strNumberB));
                        break;
                    case "-":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) - Convert.ToDouble(strNumberB));
                        break;
                    case "*":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) * Convert.ToDouble(strNumberB));
                        break;
                    case "/":
                        if (Convert.ToDouble(strNumberB) != 0)
                            strResult = Convert.ToString(Convert.ToDouble(strNumberA) / Convert.ToDouble(strNumberB));
                        else
                            strResult = "除数不能为0";
                        break;
                }

                Console.WriteLine("结果是：" + strResult);
            }
            catch (Exception ex)
            { 
                Console.WriteLine("您的输入有错："+ex.Message);
            }

            Console.ReadLine();
        }
    }
}
