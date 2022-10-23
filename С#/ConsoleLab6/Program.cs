using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainShared;

namespace ConsoleLab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, res_square, res_perimeter;

            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            SharedClass.RectangleD func1 = SharedClass.SquareRectangle;
            res_square = func1(x, y);

            SharedClass.RectangleD func2 = SharedClass.PerimeterRectangle;
            res_perimeter = func2(x, y);

            Console.WriteLine("{0} & {1}", res_square, res_perimeter);
            Console.ReadKey();
        }
    }
}
