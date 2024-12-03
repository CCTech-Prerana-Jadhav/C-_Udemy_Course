using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintAverage(double[] temperatures)
        {
            double average = CalculateAverage(temperatures);

            Console.WriteLine($"The average temperature is: {average}");
        }

        public double CalculateAverage(double[] temperatures)
        {
            double sum = 0;

            foreach (double t in temperatures)
            {
                sum += t;
            }

            return sum / temperatures.Length;
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            double[] temperatures = { 23.5, 24.8, 22.1, 26.3, 21.7 };
            exercise.PrintAverage(temperatures);
        }
    }
}
