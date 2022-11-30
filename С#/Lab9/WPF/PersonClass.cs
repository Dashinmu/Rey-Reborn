using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPF
{
    public class PersonClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set 
            {
                if (value != _FirstName)
                {
                    _FirstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }

        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set
            {
                if (value != _LastName)
                {
                    _LastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }

        private string _SecondName;
        public string SecondName
        {
            get { return _SecondName; }
            set
            {
                if (value != _SecondName)
                {
                   _SecondName = value;
                    OnPropertyChanged("SecondName");
                }
            }
        }

        private int _Age;
        public int Age
        {
            get { return _Age; }
            set
            {
                if (value != _Age)
                {
                    _Age = value;
                    OnPropertyChanged("Age");
                }
            }
        }

        public PersonClass() : this("FirstName", "LastName", "SecondName", 0) { }
        public PersonClass(string ln, string fn, string sn, int yo)
        {
            LastName = ln;
            FirstName = fn;
            SecondName = sn;
            Age = yo;
        }

        public PersonClass(PersonClass person) : this (person.LastName, person.FirstName, person.SecondName, person.Age) { }

        public static void CopyData(PersonClass person1, PersonClass person2)
        {
            person1.LastName = person2.LastName;
            person1.FirstName = person2.FirstName;
            person1.SecondName = person2.SecondName;
            person1.Age = person2.Age;
        }
    }
}
