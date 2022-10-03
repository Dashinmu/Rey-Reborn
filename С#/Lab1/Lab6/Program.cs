using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: "); //начало диапазона
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число B: "); //конец диапазона
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число X: "); //последняя цифра числа
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число Y: "); //последняя цифра числа
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                if (i%10 == x || i%10 == y)
                {
                    Console.Write("{0} > ", i);
                }
            }
        }
    }
}
