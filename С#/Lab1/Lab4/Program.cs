using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты X и Y: "); //Ну у нас проверка точки вне квадрате, так что CHILL
            float x = Convert.ToSingle(Console.ReadLine());
            float y = Convert.ToSingle(Console.ReadLine());

            //Квадрат образуется точками {0;0} > {0;-15} > {-15;-15} > {-15;0}
            if (x < 0 && x > -15 && y < 0 && y > -15) //В квадрате
            {
                Console.WriteLine("Точка не в зоне");
            }
            else if ((x == 0 || x == -15) || (y == 0 || y == -15)) //На рёбрах квадрата
            {
                Console.WriteLine("Точка на границе зоны");
            }
            else Console.WriteLine("Точка в зоне"); //Буква Ю
        }
    }
}
