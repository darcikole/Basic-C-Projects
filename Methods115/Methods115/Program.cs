using System;

namespace Methods115
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number.\r\n");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You may enter another whole number if you wish.");
            string input2 = Console.ReadLine();

            bool b1 = string.IsNullOrEmpty(input2);

            OptionMethod op = new OptionMethod();

            if (b1)
            {

                int x = op.OpM(num1);
                Console.WriteLine(num1 + " times 10 + 19 = " + x);
            }
            
            else
            {
                int num2 = Convert.ToInt32(input2);
                int y = op.OpM(num1, num2);
                Console.WriteLine(num1 + " times 10 + " + num2 + " = " + (num1 * 10 + num2));
}
        }
    }
}