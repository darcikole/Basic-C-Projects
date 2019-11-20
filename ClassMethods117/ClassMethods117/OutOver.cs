using System;
using System.Threading;

namespace ClassMethods117
{
    public class OutOver
    {
        public void Op1(int x)
        {
            int result = x / 2;
            Thread.Sleep(1000);
            Console.WriteLine("... divided by 2 = " + result);
        }


        public void Op1(int x, int y)
        {
            int result = ((x /2) * y);
            Thread.Sleep(1000);
            Console.WriteLine("... divided by 2 and then multiplied by " + y + " = " + result);
        }

        public void Op2(double radius, out double area)
        {
            area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine("The Circle's circumference is " + circumference);
            Console.WriteLine("The Circle's area is " + area);
        }
    }
}
