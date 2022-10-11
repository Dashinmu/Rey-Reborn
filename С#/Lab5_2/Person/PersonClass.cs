using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        public string name; //имя
        public string lastName; //фамилия
        public byte age; //возраст

        public Person()
        {
            name = "Name";
            lastName = "lastName";
            age = 0;
        }

        public Person(string name, string lastName, byte age)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }

        public void PersonWrite(string name, string lastName, byte age)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }

        public virtual string Print()
        {
            string s = this.name + " " + this.lastName + " " + this.age;
            return s;
        }
    }
}
