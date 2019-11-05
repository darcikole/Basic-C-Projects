using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is a simple progra
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();


            //bool isStudying = false;
            //byte hoursWorked = 42;
            //sbyte currTemp = -23;
            //char questMark = '\u2103';

            //Console.WriteLine(questMark);
            //Console.ReadLine();

			Console.WriteLine("The Tech Academy" + "\r\n" + "Student Daily Report");

			Console.WriteLine("What course are you on?");
			string yourCourse = Console.ReadLine();

			Console.WriteLine("What page are you on?");
			string yourPage = Console.ReadLine();

			Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
          

            Console.WriteLine("Were there any positive experiences you'd like to share?  Please give specifics.");
            string yourExperience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide?  Please be specific.");
            string yourFeedback = Console.ReadLine();

            Console.WriteLine("How may hours did you study today?");
            var yourHours = Console.ReadLine();
           

            Console.WriteLine("Thank you for your answers.  An Instructor will respond to this shortly." + "\r\n" + "Have a great day!");


        }
    }
}
