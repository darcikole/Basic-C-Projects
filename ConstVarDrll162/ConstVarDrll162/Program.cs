using System;

namespace ConstVarDrill162
{
    class Program
    {
        static void Main(string[] args)
        {
            var newEmployee = new Employee("Kole", "Darci", 1);// created variable using var

            const string welcomeNewbie = "Welcome to X-Corp";// created a const variable

            Console.WriteLine("Hello, {0} {1}, {2}!", newEmployee.FirstName, newEmployee.LastName, welcomeNewbie);
        }
            
    }
}
