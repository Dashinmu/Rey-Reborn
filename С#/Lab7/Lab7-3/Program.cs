using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = new string[10] { "Катерину", "Мишу", "Иван", "Даниил", "Кабану", "Никита", "Петя", "Даша", "ууууууууууууууууу", "Лера" };

            var q1 = from name in s
                     where name.EndsWith("у")
                     select name;

            int len = 0;
            string n = "";
            foreach (string name in q1)
            {
                if (name.Length > len)
                {
                    len = name.Length;
                    n = name;
                }
            }
            Console.WriteLine("{0} {1}", len, n);
            Console.ReadKey();
        }
    }
}
