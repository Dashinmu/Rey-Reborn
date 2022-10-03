using System;

namespace CLPointFigure
{
    public class Point
    {
        public int x; //X coordinate
        public int y; //Y coordinate

        //Base
        public Point()
        {
            x = 0;
            y = 0;
        }

        //
        public void PointRead(int x, int y)
        {
            this.x = x;
            this.y = y;
        } 
        
        //Get&Set
        public int xGetSet
        {
            get { return x; }
            set { x = value; }
        }

        public int yGetSet
        {
            get { return y; }
            set { y = value; }
        }
    }

    public class Figure
    {
        public int a; //Edge length 
        public Point point = new Point();

        public Figure()
        {
            a = 0;
        }

        public void FigureRead(int x, int y, int a)
        {
            this.a = a;
            point.PointRead(x,y);
        }

        public int aGetSet
        {
            get { return a; }
            set { a = value; }
        }
    }
}
