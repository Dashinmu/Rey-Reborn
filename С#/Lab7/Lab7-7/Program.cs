using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = new string[10] { "Катя", "Миша", "Иван", "Даниил", "Камбан", "Никита", "Петя", "Даша", "Анж", "Лера" };

            string c = "м";
            var q1 = from name in s
                     where name.IndexOf(c, 0, name.Length) == 2
                     select name;

            if (!q1.Any())
            {
                Console.WriteLine("empty!");
            } else
            {
                foreach (string name in q1)
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine(q1.Count());
            }
            Console.ReadKey();
        }
    }
}
