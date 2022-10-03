using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLTest
{
    public class Point
    {
        public float x, y; //X&Y coordinates
   
        //Base
        public Point()
        {
            x = 0;
            y = 0;
        }

        //
        public void PointRead(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        //Get&Set
        public float xGetSet
        {
            get { return x; }
            set { x = value; }
        }

        public float yGetSet
        {
            get { return y; }
            set { y = value; }
        }
    }
}
