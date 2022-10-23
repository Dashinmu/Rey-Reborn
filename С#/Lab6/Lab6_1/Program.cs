using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    internal class Program
    {
        private delegate double FuncLab(double x); //делегат

        private static double FuncFirst(double x)
        {
            double y = Math.Pow(Math.Abs(x), 5.0) * (1.0 / Math.Tan(Math.Abs(2.0 * x)));
            return Math.Round(y, 3);
        }
        private static double FuncSecond(double x)
        {
            double y = Math.Log(Math.Pow(x, 2.0) + 1.0);
            return Math.Round(y, 3);
        }
        private static double FuncThird(double x)
        {
            double y = Math.Exp(-2.0 * x) - Math.Pow(Math.Abs(x + 1.0), 1.0 / 3.0);
            return Math.Round(y, 3);
        }
        static void Main(string[] args)
        {
            double pos_start = -3.4; //интервал начало
            double pos_end = 2.5; //интервал конец
            double a = 1.0; //параметр
            double step = 0.23; //шаг интервала
            double y;
            
            for (double x = pos_start; x < pos_end; x+=step)
            {
                if (x < 0)
                {
                    FuncLab op = FuncFirst;
                    y = op(x);
                    Console.WriteLine("{0}  ", y);
                } else if (x <= a)
                {
                    FuncLab op = FuncSecond;
                    y = op(x);
                    Console.WriteLine("{0}  ", y);
                } else if (x > a)
                {
                    FuncLab op = FuncThird;
                    y = op(x);
                    Console.WriteLine("{0}  ", y);
                }
            }
        }
    }
}
