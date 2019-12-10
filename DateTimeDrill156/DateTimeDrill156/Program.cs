using System;

namespace DateTimeDrill156
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DateTime.Now);
            Console.WriteLine("\r\n" + "Please enter a whole number.");
            double hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("In {0} hour(s) it will be: {1}", hours, DateTime.Now.AddHours(hours));

        }
    }
}
