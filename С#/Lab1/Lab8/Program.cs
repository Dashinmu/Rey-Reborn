using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A: "); //Начало диапазона
            float a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите B: "); //Конец диапазона
            float b = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите шаг: ");
            float h = Convert.ToSingle(Console.ReadLine());

            for (float x = a; x <=b; x+=h)
            {
                if (x + 2 <= 1)
                {
                    Console.Write("{0} > ", x * x);
                } else if (x + 2 > 1 && x + 2 < 10)
                {
                    Console.Write("{0} > ", 1 / (x + 2));
                } else if (x + 2 >= 10)
                {
                    Console.Write("{0} > ", x + 2);
                }
            }
        }
    }
}
