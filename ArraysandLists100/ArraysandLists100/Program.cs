using System;
using System.Collections.Generic;

class Program
    {
    static void Main()
    {

        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);

        //Console.WriteLine(intList[0]);

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);

        string[] colorArray = { "blue", "green", "yellow", "red", "purple" };
        Console.WriteLine("Choose a number from 0 to 4");
        int yourIndex = Convert.ToInt32(Console.ReadLine());

        if (yourIndex >= 0 && yourIndex < colorArray.Length)

        {
            Console.WriteLine("Do you like the color " + colorArray[yourIndex] + "?");
        }
        else
        {
            Console.WriteLine("Oops!  You didn't choose a number from 0 to 4.");
        }
            Console.WriteLine("\r\n");

            int[] intArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Choose a number from 0 to 4");
            int yourNum = Convert.ToInt32(Console.ReadLine());

        if (yourNum >= 0 && yourNum < intArray.Length)
        {
            Console.WriteLine("You get  " + intArray[yourNum] + " candybars!");
        }
        else
        {
            Console.WriteLine("Oops!  You didn't choose a number from 0 to 4.");
        }
            Console.WriteLine("\r\n");

            List<string> myList = new List<string>();
            myList.Add("Twix");
            myList.Add("KitKat");
            myList.Add("Snickers");
            myList.Add("Hersheys");
            myList.Add("Almond Joy");


            Console.WriteLine("Choose a number from 0 to 4");
            int listNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you like  " + myList[listNum] + "?");
        

        }

}
 