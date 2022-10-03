using System;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Convert.ToString(Console.ReadLine());
            string s1 = Convert.ToString(Console.ReadLine());
            string s2 = "pupu-pipi-check";

            string res_s = s.Replace(s1, s2);

            Console.WriteLine(res_s);
        }
    }
}
