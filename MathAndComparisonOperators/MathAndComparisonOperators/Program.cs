using System;
using System.Threading;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 -5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //finds the remainder (used commonly for even/odd)
            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);

            //bool trueOrFalse = 12 < 5;
            //Console.Write(trueOrFalse.ToString());

            //int roomTemperature = 70;
            //int currentTemperature = 70;

            //bool isWarm = currentTemperature > roomTemperature;
            //bool isWarm = currentTemperature >= roomTemperature;
            //bool isWarm = currentTemperature == roomTemperature;
            //bool isWarm = currentTemperature != roomTemperature;
            //Console.WriteLine(isWarm);


            Console.WriteLine("Enter a number");
            string num1 = Console.ReadLine();
            double num1Choice = Convert.ToInt32(num1);

            double multNum = num1Choice * 50;
            Console.WriteLine("Your number multiplied by 50 is: " + multNum + "\r\n");
            Thread.Sleep(1000);
          

            Console.WriteLine("Enter a number");
            string num2 = Console.ReadLine();
            double num2Choice = Convert.ToInt32(num2);

            double addNum = num2Choice + 25;
            Console.WriteLine("Your number plus 25 is: " + addNum + "\r\n");
            Thread.Sleep(1000);


            Console.WriteLine("Enter a number");
            string num3 = Console.ReadLine();
            double num3Choice = Convert.ToInt32(num3);

            double divideNum = num3Choice / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + divideNum + "\r\n");
            Thread.Sleep(1000);

            Console.WriteLine("Enter a number");
            string num4 = Console.ReadLine();
            double num4Choice = Convert.ToInt32(num4);

            bool numGreater = num4Choice > 50;
            Console.WriteLine("Is your number greater that 50? ");
            Thread.Sleep(1000);
            Console.Write(numGreater.ToString());
            Console.WriteLine("\r\n");
            Thread.Sleep(1000);

            Console.WriteLine("Enter a number");
            string num5 = Console.ReadLine();
            double num5Choice = Convert.ToInt32(num5);

            double remainder = num5Choice % 7;
            Console.WriteLine("The remainder of your number divided by 7 is: " + remainder + "\r\n");
            Thread.Sleep(1000);
            Console.WriteLine("Thank you for playing!");






        }
    }
}
