using System;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dashinmu playing POE-bota!

            string s = Convert.ToString(Console.ReadLine());
            string[] arr = s.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            int min_length = 1000;

            for (int i = 0; i < arr.Length; i++)
            {
                //Console.WriteLine("{0} -> {1}   ", i, arr[i]);
                if (arr[i].Length < min_length) min_length = arr[i].Length;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == min_length) Console.Write(arr[i] + "\t");
            }
        }
    }
}
