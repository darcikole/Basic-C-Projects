using System;
using System.Collections.Generic;
using InheritanceDrills;

namespace Inheritance
{
    class Program
    {
        public static int ID { get; private set; }

        static void Main(string[] args)
        {

            Employee<string> employee = new Employee<string>();


            //instantiating Employee class & method
            //Employee employee1 = new Employee();
            //{
            //    employee1.FirstName = "Sample";
            //    employee1.LastName = "Student";
            //    employee1.ID = 1;
            //}
            //Employee employee2 = new Employee();
            //{
            //    employee2.FirstName = "Example";
            //    employee2.LastName = "Scholar";
            //    employee2.ID = 2;
            //}



            //employee.SayName();

            // creating IQuittable object
            IQuittable quit1 = new Employee();
            quit1.Quit();
        }
    }
}
