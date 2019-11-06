using System;
using System.Threading;

namespace Math2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program" + "\r\n");
            Thread.Sleep(1500);

            Console.WriteLine("Person 1:");
            Console.WriteLine("What is your Hourly Rate?");
            decimal rate1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How many hours worked per week?");
            decimal hours1 = Convert.ToDecimal(Console.ReadLine());
            Thread.Sleep(1000);

            Console.WriteLine("Person 2:");
            Console.WriteLine("What is your Hourly Rate?");
            decimal rate2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How many hours worked per week?");
            decimal hours2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\r\n");
            Thread.Sleep(1000);

            Console.WriteLine("Weekly salary of Person 1: ");
            decimal salary1 = rate1 * hours1;
            Console.WriteLine(salary1 + "\r\n");
            Thread.Sleep(1000);

            Console.WriteLine("Weekly salary of Person 2: ");
            decimal salary2 = rate2 * hours2;
            Console.WriteLine(salary2 + "\r\n");
            Thread.Sleep(1000);

            Console.WriteLine("Does Person 1 make more money than Person 2?" + "\r\n");
            bool salaryComp = salary1 > salary2;
            Console.WriteLine(salaryComp);




        }
    }
}
