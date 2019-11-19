using System;
using static System.Console;

namespace MethodsDrill114
{
    public class MathOp
    {

        public int OpX(int x)
        {
            int result = x * 5;
            return result;
        }

        public int OpX(decimal y)
        {
            decimal result = y / 2;
            return (int)result;
        }

        public int OpX(string z)
        {
            int result = Convert.ToInt32(z);
            int add = result + 8;
            return add;

        }
    }
}
