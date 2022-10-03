using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j-- )
                {
                    Console.Write("{0,4}", a);
                }
                Console.WriteLine();
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("{0,4}", a - j - i + 7);
                }
                Console.WriteLine();
            }
        }
    }
}
