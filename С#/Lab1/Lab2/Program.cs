using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: "); //Сообщение об числе
            int a = Convert.ToInt32(Console.ReadLine()); //Запись числа и конвертация

            Console.Write("Введите разницу: "); //Сообщение об разности
            int b = Convert.ToInt32(Console.ReadLine()); //Запись разности

            Console.Write("Введите количество членов: "); //Количество
            int c = Convert.ToInt32(Console.ReadLine()); //Запись количества

            int response = a + b * c; //Арифметическая прогрессия???
            Console.WriteLine("Арифметическая прогерссия = {0}", response);
        }
    }
}
