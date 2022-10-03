using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLTest
{
    public class Figure
    {
        public float a; //Edge length 
        public Point point = new Point();

        public Figure()
        {
            a = 0;
        }

        public void FigureRead(float x, float y, float a)
        {
            this.a = a;
            point.PointRead(x, y);
        }

        public float aGetSet
        {
            get { return a; }
            set { a = value; }
        }

        //CheckCoordinatePoint
        public bool CheckPoint(Point pointCheck)
        {
            if ((pointCheck.x >= this.point.x) && (pointCheck.x - this.a <= this.point.x))
            {
                if ((pointCheck.y >= this.point.y) && (pointCheck.y - this.a <= this.point.y))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
