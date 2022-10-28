using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int [15] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14};
            string[] s = new string [15]
            {
                "zero",
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine",
                "ten",
                "eleven",
                "twelve",
                "thirteen",
                "fourteen"
            };

            var q1 = from n in numbers
                     where (n%2 != 0)
                     select s[n];

            foreach(var s1 in q1)
            {
                Console.Write(" {0} |", s1);
            }
            Console.ReadKey();
        }
    }
}
