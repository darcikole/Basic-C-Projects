using System;

namespace EnumExercise134
{
    class Program
    {
        public enum Day
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the current day of the week.");
            string userDay = Console.ReadLine();
            string today = userDay.ToLower();

            Day day;
            try
            {
                day = (Day)Enum.Parse(typeof(Day), today);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            
                

            
        }
       
    }
}
