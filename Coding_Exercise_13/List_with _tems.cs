using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintNumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 3 };

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintNumbers();
        }
    }
}
