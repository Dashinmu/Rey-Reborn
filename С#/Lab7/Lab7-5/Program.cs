using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int D = 8;
            int[] numbers = new int[15] { 10, -7, 8, 1, -12, 0, 4, 15, -3, -21, 17, 11, -10, 28, -23 };

            var q1 = from num in numbers
                     where (num >= 0) && (num % 10 == D)
                     select num;

            int res = (!q1.Any()) ? 0 : q1.First();
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
