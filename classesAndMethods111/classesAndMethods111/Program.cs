using System;
using System.Threading;

namespace classesAndMethods111
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter a number between 1 and 10.");
            double Radius = Convert.ToDouble(Console.ReadLine());

            Circle circleDiameter = new Circle();
            double diameter = circleDiameter.Diameter(Radius);
            Console.WriteLine("The Diameter of your circle is: " + diameter + "\r\n");
            Thread.Sleep(1000);

            Circle circleCircumference = new Circle();
            double circumference = Math.Round(circleCircumference.Circumference(Radius), 2);
            Console.WriteLine("The Circumference of your circle is: " + circumference + "\r\n");
            Thread.Sleep(1000);

            Circle circleArea = new Circle();
            double area = Math.Round(circleArea.Area(Radius), 2);
            Console.WriteLine("The Area of your circle is: " + area);



            
        }
    }
}
