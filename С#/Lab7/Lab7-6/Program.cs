using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = new string[10] { "Катя", "Миша", "Иван", "Даниил", "Кабан", "Никита", "Петя", "Даша", "Анж", "Лера" };

            var q1 = from name in s
                     orderby name.Length descending
                     select name;

            foreach (string name in q1)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
