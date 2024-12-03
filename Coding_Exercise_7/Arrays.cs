using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintNumbers()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintNumbers();
        }
    }
}
