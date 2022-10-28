using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[15] { 10, -7, 9, 1, -12, 0, 4, 15, -3, -21, 18, 11, -10, 28, -23 };

            var q1 = from num in numbers
                     where (num >= 0) && (num/10 >= 1)
                     select num;

            foreach (int num in q1)
            {
                Console.WriteLine(num);
            }
            double res = q1.Average();

            Console.WriteLine("{0} {1}", res, "<--- Average num");
            Console.ReadKey();
        }
    }
}
