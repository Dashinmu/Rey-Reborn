using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[15] { 10, -711, 9, 1, -12, 0, 4, 15, -3, -210, 180, 11, -10, 28, -23 };

            var q1 = (from num in numbers
                     where (num >= 100) || (num <= -100)
                     select num).Reverse();

            foreach (int res in q1)
            {
                Console.WriteLine(res);
            }
            Console.ReadKey();
        }
    }
}
