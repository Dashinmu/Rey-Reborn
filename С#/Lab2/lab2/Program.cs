using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()), position = 0;
            double num;
            double[] arr = new double[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                num = rand.NextDouble() + rand.Next(-20, 20); //генерация числа
                num = Math.Round(num, 1);
                arr[i] = num; 
                Console.Write(arr[i] + " \t");
            }
            Console.WriteLine();
            double max_num = -21.0; //поиск максимального числа от минимального
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max_num)
                {
                    max_num = arr[i];
                    position = i;
                }
            }
            position++; //Для ЛЮДЯ массив с 1
            Console.Write("Максимальный эл. {0} располагается на позиции {1}", max_num, position);
        }
    }
}
