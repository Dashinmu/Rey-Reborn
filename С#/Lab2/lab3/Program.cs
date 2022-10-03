using System;
using System.Runtime.Intrinsics.X86;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine()), cnt = 0, pustota = 0;
            int[,] arr = new int[n, n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rand.Next(-21, 20);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[j, i] < 0) cnt++;
                }

                if (cnt == n) Console.WriteLine("{0} столбик отритацельных чисел", i + 1);
                    else pustota++;
                cnt = 0;
            }

            if (pustota == n) Console.WriteLine("Ну не повезло, нет столбика из отрицательных чисел");
        }
    }
}
