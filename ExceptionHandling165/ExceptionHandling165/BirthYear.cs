using System;
namespace ExceptionHandling165
{
    public class BirthYear
    {
        public BirthYear()
        {
            Console.WriteLine("What is your age?");
            bool validAge = false;
            while (!validAge)
            {
                validAge = int.TryParse(Console.ReadLine(), out int age);
                DateTime todaysDate = DateTime.Today;
                DateTime birthYear = todaysDate.AddYears(-age);
                DateTime yourYear = birthYear;

                if (age <= 0)
                {
                    throw new AgeException();
                }
                Console.WriteLine("You were born in {0} ", yourYear.Year);
            }
        }
    }
}
