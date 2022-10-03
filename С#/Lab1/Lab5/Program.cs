using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите пол М (мужской) или Ж (женский): "); //Сравнение между М и Ж
            char c = Convert.ToChar(Console.ReadLine());

            string s = (c == 'М' || c == 'M') ? ("Боб, Майк, иные мужские") : ("Эла, Рейчел, иные женские"); //Введут иначе - значит женщина
            Console.WriteLine(s);
        }
    }
}
