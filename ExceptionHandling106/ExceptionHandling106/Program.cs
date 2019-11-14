using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        //try
        //{
        //    Console.WriteLine("Pick a number.");
        //    int numberOne = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Pick a second number.");
        //    int numberTwo = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Dividing the two...");
        //    int numberThree = numberOne / numberTwo;
        //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
        //}
        //catch (FormatException)
        //{
        //    Console.WriteLine("Please type a whole number.");
        //    return;
        //}
        //catch (DivideByZeroException)
        //{
        //    Console.WriteLine("Please don't divide by zero");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //    Console.ReadLine();
        //}

        //////////////////////////////////////////////////////////////

        try
        {
            List<int> myList = new List<int> { 5, 6, 7, 8, 9, 10, 15, 20, 25, 30 };

            Console.WriteLine("Please choose a number.");
            int divisor = Convert.ToInt32(Console.ReadLine());

            foreach (decimal num in myList)
            {
                decimal result = Convert.ToDecimal(num / divisor);
                Console.WriteLine(num + " divided by " + divisor + " equals " + result);

            }
        }
        catch (DivideByZeroException)
        {
                Console.WriteLine("Please choose a number other than zero."); 
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("End of try/catch");
        }


    }
}