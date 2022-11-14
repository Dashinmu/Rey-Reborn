using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Employee
    {
        public int IdEmployee { get; set; }
        public string FullName { get; set; }
        public char Sex { get; set; }
        public string Birthday { get; set; }
        public string Post { get; set; }
        public int Salary { get; set; }
        public int IdDepartment { get; set; }

        public override string ToString()
        {
            return string.Format(" ID: {0}\n ФИО: {1}\n Пол:{2}\n Дата рождения: {3}\n Должность: {4}\n Зарплата: {5} у.е.\n ID отдела: {6}\n",
                                    IdEmployee, FullName, Sex, Birthday, Post, Salary, IdDepartment);
        }
    }
}
