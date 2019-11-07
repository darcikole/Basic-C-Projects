using System;
using System.Text;
using System.Threading;

namespace Strings97
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What state are you from?");
            string state = Console.ReadLine();
            string upState = state.ToUpper();

            Console.WriteLine("What course are you currently working on?");
            string course = Console.ReadLine();

            string greeting = "Hello, " + name + " from " + upState + "!" + "  How are you liking the " + course + " course, so far?";
            Console.WriteLine(greeting);


            StringBuilder sb = new StringBuilder();
            sb.Append("Hello, my name is Darci.\r\n");
            sb.Append("I live in Seattle, WA.\r\n");
            sb.Append("I am a mother and a coder.\r\n");
            sb.Append("I am also a wine enthusiast..\r\n\t");
            sb.Append("...which helps with the mothering and the coding!");

            Console.WriteLine(sb);
        }
    }
}

