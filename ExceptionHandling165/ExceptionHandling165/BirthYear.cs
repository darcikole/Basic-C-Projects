using System;
namespace ExceptionHandling165
{
    public class BirthYear
    {
        public BirthYear()
        {
            Console.WriteLine("What is your age?");
            int age = 0;
            bool validAge = false;
            while (!validAge)
            { 
                validAge = int.TryParse(Console.ReadLine(), out age);
                DateTime todaysDate = DateTime.Today;
                DateTime birthYear = todaysDate.AddYears(-age);
                DateTime yourYear = birthYear;
                

                if (age <= 0)   
                {
                    throw new AgeException();
                }
                else
                {
                    Console.WriteLine("You were born in {0} ", yourYear.Year);
                }
            }
        }
    }
}
