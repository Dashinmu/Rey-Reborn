using System;
using System.Diagnostics.CodeAnalysis;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[15];
            double cnt = 0, res = 0;
            Random rand = new Random();
            for (int i = 0; i < 15; i++)
            {
                arr[i] = rand.Next(20) - 10; //заполнение массива рандомными числами
                Console.Write(arr[i]+" \t");
            }
            Console.WriteLine();
            for (int i = 0; i < 15; i++)
            {
                if (arr[i] < 0)
                {
                    cnt++; //посчет количества отрицательных чисел
                    res += arr[i]; //сумма отрицательных чисел
                }
            }
            Console.WriteLine(res/cnt);
        }
    }
}
