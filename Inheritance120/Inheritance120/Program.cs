using System;
using InheritanceDrills;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating Employee class & method
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();


            IQuittable quit1 = new Employee();
            quit1.Quit();
        }
    }
}
