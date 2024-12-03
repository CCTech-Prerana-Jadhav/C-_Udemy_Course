using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintWithFinally()
        {
            try
            {
                Console.WriteLine("Trying...");
            }
            finally
            {
                Console.WriteLine("Finally executed.");
            }
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintWithFinally();
        }
    }
}
