using System;
using System.Threading;

namespace BooleanLogic75
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int myAge = Convert.ToInt32(age);
            Console.WriteLine("\r\n");
            Thread.Sleep(1000);

            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\".");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("\r\n");
            Thread.Sleep(1000);

            Console.WriteLine("How many speeding tickets have you had?");
            string tickets = Console.ReadLine();
            int speedTix = Convert.ToInt32(tickets);
            Console.WriteLine("\r\n");
            Thread.Sleep(1000);

            bool qualified = myAge > 15 && DUI == false && speedTix <= 3;

            Console.WriteLine("Are you qualified?");
            Thread.Sleep(1000);
            Console.WriteLine(qualified);


            
            //int bankAccountBalance = 500;
            //bool isInARockBand = false;
            //string name == “Jesse”;

            //bool isReallyCool = (bankAccountBalance > 100000 || isInARockBand || name == “Jesse”)

            //true
        }
    }
}
