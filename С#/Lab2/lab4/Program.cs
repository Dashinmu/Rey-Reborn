using System;
using System.Runtime.Serialization.Formatters;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] arr = new int[5][]; //зубастик
            int[] array = new int[0]; // новый массив по строкам равный зубастику

            Random rand = new Random();

            // ->> fill arr
            for (int c = 0; c < 5; c++) // arr[0][], arr[1][] ... arr[4][]
            {
                int n = rand.Next(1, 6); // random length
                arr[c] = new int [n];
                for (int i = 0; i < n; i++)
                {
                    arr[c][i] = rand.Next(1, 100); // arr[c][i] = [1..100]
                    Console.Write(arr[c][i] + "\t");
                }
                Console.WriteLine();
            }

            int last_num = 0; // последнее чётное число

            // ->> do arr
            for (int c = 0; c < 5; c++)
            {
                int n = arr[c].Length; //get lenght
                for (int i = 0; i < n; i++)
                {
                    if (arr[c][i] % 2 == 0) last_num = arr[c][i];
                }
                if (last_num != 0)
                {
                    Array.Resize(ref array, array.Length + 1); //что-то на марсианском, check docs please.
                    array[array.Length - 1] = last_num;
                    last_num = 0;
                }
            }

            Console.WriteLine("--------");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+"\t");
            }
        }
    }
}
