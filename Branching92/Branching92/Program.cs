using System;
using System.Threading;

namespace Branching92
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please folow the instructions below." + "\r\n");
            Thread.Sleep(1000);

            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());
            Thread.Sleep(1000);
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.  Have a good day.");
            }

            else { 

            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());
            Thread.Sleep(1000);

            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());
            Thread.Sleep(1000);

            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());
            Thread.Sleep(1000);

            double sum = width + height + length;
            decimal quote = (decimal)(sum * weight / 100);

            Console.WriteLine("Your estimated total for shipping this package is: $" + quote + "\r\n" + "Thank You!");

            }
        }
    }
}
