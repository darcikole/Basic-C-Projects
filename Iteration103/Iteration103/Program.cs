using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}


        //string[] names = { "Darci", "Dalia", "Dina", "David" };

        //for (int d = 0; d < names.Length; d++)
        //{
        //    Console.WriteLine(names[d]);
        //}


        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + score);
        //    }
        //}

        //List<string> names = new List<string>() { "Darci", "Dalia", "Dina", "David" };

        //foreach (string name in names)
        //{
        //    Console.WriteLine(name);
        //}

        //List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 89 };
        //List<int> passingScores = new List<int>();

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        passingScores.Add(score);
        //    }
        //}
        //Console.WriteLine(passingScores.Count);

        /////////////////////////////////////////////////////////////////////////////////
        ///
        //1)
        string[] rockBands = new string[5];
        rockBands[0] = "GnR";
        rockBands[1] = "Ramones";
        rockBands[2] = "The Clash";
        rockBands[3] = "Led Zepplin";

        Console.WriteLine("Who is your favorite Rock Band?");
        rockBands[4] = Console.ReadLine();

        Console.WriteLine("\r\n");

        for (int i = 0; i < rockBands.Length; i++)
        {
            Console.WriteLine(rockBands[i]);
        }
        Console.WriteLine("\r\n");
        Thread.Sleep(1500);
        ///////////////

        //2, 3)

        int x = 0;

        while (true)
        {
            int value = ++x;
            Console.WriteLine("Infinite Loop");

            if (value > 5)
            {
                Console.WriteLine("Break loop");
                break;
            }
        }
        Console.WriteLine("\r\n");
        Thread.Sleep(1500);
        //////////////

        //4)

        int a = 0;
        while (a < 5)
        {
            Console.WriteLine(a);
            a++;
        }

        Console.WriteLine("\r\n");
        Thread.Sleep(1500);
        //////////////

        //5)

        int b = 3;
        while (b <= 10)
        {
            Console.WriteLine(b);
            b++;
        }

        Console.WriteLine("\r\n");
        Thread.Sleep(1500);
        //////////////

        //6,7,8)

        List<string> colors = new List<string>() { "blue", "green", "yellow", "red", "pink", "purple" };

        Console.WriteLine("Choose a color: blue, green, yellow, red, pink or purple.");

        string userInput = Console.ReadLine();
        string userColor = userInput.ToLower();

        if (colors.Contains(userColor))
        {
            int c = colors.IndexOf(userColor);
            Console.WriteLine("The index of your color choice is: " + c);
        }

        else
        {
            Console.WriteLine("That color isn't listed.");
        }

        Console.WriteLine("\r\n");
        Thread.Sleep(1500);
        //////////////

        //9)

        List<string> trolls = new List<string>() { "poppy", "branch", "creek", "poppy", "biggie", "guy diamond", "dj suki", "branch" };


        Console.WriteLine("Which is your favorite Troll? Poppy, Branch, Creek, Biggie, Guy Diamond or DJ Suki?");

        string uInput = Console.ReadLine();
        string userTroll = uInput.ToLower();

        if (trolls.Contains(userTroll))
        {
            IEnumerable<int> duplicateIndexes = trolls
                .Select((t, i) => (Index: i, Text: t))
                .Where(p => p.Text == userTroll)
                .Select(p => p.Index);

            foreach (var i in duplicateIndexes)
            {

                Console.WriteLine("The index of your Troll is: {0}", i);

            }
        }

        else
        {
            Console.WriteLine("That Troll isn't listed.");
        }

        Console.WriteLine("\r\n");
        Thread.Sleep(1500);
        //////////////

        //10)

        List<string> villians = new List<string>() { "Maleficient", "Cruella De Vil", "Ursula", "Maleficient", "Scar", "Jafar", "Shan Yu", "Cruella De Vil" };

        IEnumerable<string> distinctStr = villians.Distinct();

        foreach (string name in distinctStr)
        {
            Console.WriteLine(name + " - is not a duplicate");
        }

        IEnumerable<string> duplicates = villians
            .GroupBy(s => s)
            .SelectMany(grp => grp.Skip(1));

        foreach (string name in duplicates)
        {
            Console.WriteLine(name + " - is a duplicate");
        }

    }
}
