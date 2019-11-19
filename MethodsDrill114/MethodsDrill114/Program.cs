using System;

namespace MethodsDrill114
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MathOp op = new MathOp();

            int result1 = op.OpX(x: 12);
            Console.WriteLine("{0}", result1);

            int result2 = Convert.ToInt32(op.OpX(y: 10));
            Console.WriteLine("{0}", result2);

            //string result = op.OpX(z: "14");
            int result3 = Convert.ToInt32(op.OpX(z: "14"));
            Console.WriteLine("{0}", result3);




        }
    }
}