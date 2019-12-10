using System;
using System.IO;

namespace LogText154
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a whole number: ");
            string number = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(@"/Users/Darci/Projects/Logs/drill154.txt", true))
            {
                file.WriteLine(number);
            }

            string text = File.ReadAllText(@"/Users/Darci/Projects/Logs/drill154.txt");
            Console.WriteLine("\r\n" + "You chose number: {0}", text);


        }
    }
}
