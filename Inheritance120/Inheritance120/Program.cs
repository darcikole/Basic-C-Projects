﻿using System;

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
            employee.Quit();
        }
    }
}
