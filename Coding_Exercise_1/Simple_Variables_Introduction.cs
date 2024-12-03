using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintNumber()
        {
            int number = 10;
            Console.WriteLine(number);
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintNumber();
        }
    }
}
