using System;

namespace ExceptionHandling165
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BirthYear birthYear = new BirthYear();
            }
            catch (AgeException)
            {
                Console.WriteLine("Please enter a valid age using digits only.");
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Please try again.");
                return;
            }
                
                
              
        }
    }
}
