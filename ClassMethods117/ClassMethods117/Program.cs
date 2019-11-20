using System;

namespace ClassMethods117
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter another whole number.");
            int num2 = Convert.ToInt32(Console.ReadLine());

            OutOver outOver = new OutOver();
            outOver.Op1(num1);
            outOver.Op1(num1, num2);

            Console.WriteLine("\r\n");

            Console.WriteLine("Please enter the radius for a circle.");
            double radius = Convert.ToDouble(Console.ReadLine());

            OutOver outOver2 = new OutOver();
            outOver2.Op2(radius, out double area);

            Console.WriteLine("\r\n");

            StaticClass.StaticProp = 19;
            Console.WriteLine(StaticClass.StaticProp);
        }
    }
}
