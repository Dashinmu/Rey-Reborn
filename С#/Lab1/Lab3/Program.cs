using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трёхзначное число "); //Сообщение
            string a = Console.ReadLine(); //Запись число в виде строки для работы с цифрами числа, ХА!
          

            if (a[0] == a[1] && a[0] == a[2])
            {
                Console.WriteLine("Цифры одинаковые");
            }
            else Console.WriteLine("Цифры не одинаковые");
        }
    }
}
