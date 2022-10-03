using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Convert.ToString(Console.ReadLine());
            char[] arr = new char[s.Length];
            arr = s.ToCharArray();
            char current_char;

            Array.Sort(arr); //ну сортировка работает и на символы))

            for (int i = 0; i < arr.Length; i++)
            {
                current_char = arr[i];
                bool has_equal = false;
                
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && current_char == arr[j]) has_equal = true;
                }

                if (has_equal == false) Console.WriteLine("{0} char hasn't equals", current_char);
            }
           
        }
    }
}
