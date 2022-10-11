using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Marks;

namespace Auto
{
    public class Auto
    {
        public string dateRelease;
        public Marks.Marks.Mark Mark;

        public Auto()
        {
            dateRelease = Convert.ToString(new DateTime(2000, 01, 01));
            Mark = Marks.Marks.Mark.Lada;
        }

        public Auto(string dt, Marks.Marks.Mark Name)
        {
            this.dateRelease = dt;
            this.Mark = Name;
        }
    }
}
