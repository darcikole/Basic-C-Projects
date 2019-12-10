using System;
using System.Collections.Generic;
using System.Linq;
using InheritanceDrills;

namespace Inheritance
{
    class Program
    {
        public static int ID { get; private set; }

        static void Main(string[] args)
        {

            // Employee<string> employee = new Employee<string>();
            // employee.Things = new List<string>
            // {
            //     "Sales Associate",
            //     "Supervisor",
            //     "Manager"
            // };
            // Employee<int> employee3 = new Employee<int>();
            // employee3.Things = new List<int>
            // {
            //     40000,
            //     50000,
            //     60000
            // };

            //foreach (var item in employee.Things)
            // {
            //     Console.WriteLine(item);
            // }

            // foreach (var item in employee3.Things)
            // {
            //     Console.WriteLine(item);
            // }


            // Instantiated list and added employee objects
            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    FirstName = "Sample",
                    LastName = "Student",
                    ID = 1
                },

                new Employee
                {
                    FirstName = "Example",
                    LastName = "Scholar",
                    ID = 2
                },
                new Employee
                {
                    FirstName = "Joe",
                    LastName = "Strummer",
                    ID = 3
                },
                new Employee
                {
                    FirstName = "Joe",
                    LastName = "DiMaggio",
                    ID = 4
                },
                new Employee
                {
                    FirstName = "Joe",
                    LastName = "Frazier",
                    ID = 5
                },
                new Employee
                {
                    FirstName = "Walt",
                    LastName = "Disney",
                    ID = 6
                },
                new Employee
                {
                    FirstName = "Little",
                    LastName = "Richard",
                    ID = 7
                },
                new Employee
                {
                    FirstName = "Margaret",
                    LastName = "Cho",
                    ID = 8
                },
                new Employee
                {
                    FirstName = "William",
                    LastName = "Duckett",
                    ID = 9
                },
                new Employee
                {
                    FirstName = "Frankie",
                    LastName = "Muniz",
                    ID = 10
                }
            };
            // foreach loop to find employees with the first name Joe
            foreach (Employee employee in employees)
            {
               if (employee.FirstName == "Joe")
                {
                    Console.WriteLine(employee.FirstName + " " + employee.LastName);
                }
            }

            Console.WriteLine("\r\n");

            // Lambda expression to find all employees named Joe in the list
            List<Employee> JoeList = employees.FindAll(x => x.FirstName == "Joe").ToList();
            foreach (var value in JoeList)
            {
                Console.WriteLine(value.FirstName + " " + value.LastName);
            }

            Console.WriteLine("\r\n");
            // Lambda expression to find all employees with an ID over 5
            List<Employee> newList = employees.FindAll(x => x.ID > 5).ToList();
            foreach (var value in newList)
            {
                Console.WriteLine(value.FirstName + " " + value.LastName);
            }


            //employee.SayName();

            // creating IQuittable object
            //IQuittable quit1 = new Employee();
            //quit1.Quit();
        }
    }
}
