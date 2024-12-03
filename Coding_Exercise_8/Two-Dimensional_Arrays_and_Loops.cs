using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintRowSums()
        {
            int[,] arr = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int rowSum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    rowSum += arr[i, j];
                }

                Console.WriteLine(rowSum);
            }
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintRowSums();
        }
    }
}
