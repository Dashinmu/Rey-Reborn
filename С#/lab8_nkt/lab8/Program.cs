using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new[]
            {
                new Employee
                {
                    IdEmployee = 1,
                    FullName = "James Bob",
                    Sex = 'M',
                    Birthday = "01.07.1997",
                    Post = "Security",
                    Salary = 1200,
                    IdDepartment = 2
                },
                new Employee
                {
                    IdEmployee = 2,
                    FullName = "Mary Jin",
                    Sex = 'F',
                    Birthday = "22.11.1995",
                    Post = "Maneger",
                    Salary = 5000,
                    IdDepartment = 1
                }
            };
            Department[] departments = new[]
            {
                new Department
                {
                    IdDepartment = 1,
                    Name = "Department1",
                    Phone = "8-921-234-23-12"
                },
                new Department
                {
                    IdDepartment = 2,
                    Name = "Department2",
                    Phone = "8-921-785-89-00"
                }
            };

            GetEmployee(employees);
            GetFemaleEmployees(employees);
            GetCountEmployees(employees);
            GetEmployeesBetweenSalary(employees);
            GetSumSalaryPost(employees);
            GetGroupEmployees(employees);
            GetFullNameBirthdayDepartment(employees, departments);

            Console.ReadKey();
        }

        static void GetEmployee(Employee[] employees)
        {
            Console.WriteLine("/------------------------------------------------------------------------/");
            string post = "Security";
            var res = from empl in employees
                      where empl.Post == post
                      select empl;
            foreach (var emp in res)
            {
                Console.WriteLine(emp.ToString());
            }
        }

        static void GetFemaleEmployees(Employee[] employees)
        {
            Console.WriteLine("/------------------------------------------------------------------------/");
            var res = from empl in employees
                      where empl.Sex == 'F'
                      select empl;
            foreach (var emp in res)
            {
                Console.WriteLine(emp.ToString());
            }
        }

        static void GetCountEmployees(Employee[] employees)
        {
            Console.WriteLine("/------------------------------------------------------------------------/");
            string date = "01.07.1997";
            var res = from empl in employees
                      where empl.Birthday == date
                      select empl;

            Console.WriteLine(res.Count());
        }

        static void GetEmployeesBetweenSalary(Employee[] employees)
        {
            Console.WriteLine("/------------------------------------------------------------------------/");
            int salaryMin = 100;
            int salaryMax = 2000;
            var res = from empl in employees
                      where empl.Salary > salaryMin && empl.Salary < salaryMax
                      select empl.FullName;
            foreach (var emp in res)
            {
                Console.WriteLine(emp);
            }
        }

        static void GetSumSalaryPost(Employee[] employees)
        {
            Console.WriteLine("/------------------------------------------------------------------------/");
            string post = "Maneger";
            var res = from empl in employees
                      where empl.Post == post
                      select empl.Salary;
            Console.WriteLine(res.Sum());
        }

        static void GetGroupEmployees(Employee[] employees)
        {
            Console.WriteLine("/------------------------------------------------------------------------/");
            var groups = from empl in employees
                      group empl by empl.IdDepartment;
            foreach (var group in groups)
            {
                foreach (var res in group)
                {
                    Console.WriteLine(res.ToString());
                }
            }
        }

        static void GetFullNameBirthdayDepartment(Employee[] employees, Department[] departments)
        {
            Console.WriteLine("/------------------------------------------------------------------------/");
            var result = from empl in employees
                      join dep in departments on empl.IdDepartment equals dep.IdDepartment
                      select new
                      {
                          FullName = empl.FullName,
                          Birthday = empl.Birthday,
                          Department = dep.Name,
                          Phone = dep.Phone
                      };
            foreach (var res in result)
            {
                Console.WriteLine(
                        " ФИО: {0}\n Дата Рождения: {1}\n Отдел: {2}\n Телефон отдела: {3}\n"
                        , res.FullName, res.Birthday, res.Department, res.Phone
                    );
            }
        }
    }
}
