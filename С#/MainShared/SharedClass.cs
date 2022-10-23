using System;
using System.Collections.Generic;
using System.Text;

namespace MainShared
{
    internal class SharedClass
    {
        public delegate int RectangleD(int x, int y);

        public static int SquareRectangle(int x, int y)
        {
            int res = x * y;
            return res;
        }
    
        public static int PerimeterRectangle(int x, int y)
        {
            int res = 2 * (x + y);
            return res;
        }
    }
}
