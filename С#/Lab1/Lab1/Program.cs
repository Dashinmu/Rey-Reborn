using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b; //Переменные числа
            //string s; //Переменная строки для записи

            Console.Write("Enter a = "); //Вывод сообщения шо нада
            a = Convert.ToInt32(Console.ReadLine()); //Запись строки и её преобразование в число

            Console.Write("Enter b = ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", a, b, a + b); //Вывод решения
        }
    }
}
