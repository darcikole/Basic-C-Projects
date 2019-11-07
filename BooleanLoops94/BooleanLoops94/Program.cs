using System;
using System.Threading;

namespace BooleanLoops94
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int x = 0;
            while (x < 5)
            {
                Console.WriteLine(x);
                x++;
            }

            Console.WriteLine("\r\n");
            Thread.Sleep(1500);


            Console.WriteLine("Guess how many bottles of beer on the wall?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool beers = number == 0;

            do
            {
                switch (number)
                {
                    case 0:
                        Console.WriteLine("You guessed Correct! We drank them all!");
                        beers = true;
                        break;
                    default:
                        Console.WriteLine("Nope, take one down and pass it around.");
                        Console.WriteLine("Guess again!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!beers);

            Console.Read();
        }
    }
}
