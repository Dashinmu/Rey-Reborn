using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//using Person;
//using Auto;
//using Marks;

namespace Owners
{
    public class Owners : Person.Person
    {
        public string datePurshase;
        public Auto.Auto auto;

        public Owners() : base()
        {
            datePurshase = Convert.ToString(new DateTime(2010, 01, 01));
        }

        public Owners(string name, string lastName, byte age, string datePurshase, string dateRelease, Marks.Marks.Mark Name) : base (name, lastName, age) 
        {
            this.datePurshase = datePurshase;
            auto =  new Auto.Auto(dateRelease, Name);
        }

        public void OwnersWrite(string name, string lastName, byte age, string dt)
        {
            base.PersonWrite(name, lastName, age);
            this.datePurshase = dt;
        }

        public override string Print()
        {
            string s = base.Print();
            string s1 = auto.dateRelease + " " + auto.Mark;
            s += " " + this.datePurshase + " " + s1;
            return s;
        }
    }
}
