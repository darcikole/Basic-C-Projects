using System;

namespace StructExercise137
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number
            {
                Amount = 7.50m
            };

            Console.WriteLine(number.Amount);
        }
    }
}
