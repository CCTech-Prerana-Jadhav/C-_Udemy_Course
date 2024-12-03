using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintDay()
        {
            int day = 3;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("Another day");
                    break;
            }
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintDay();
        }
    }
}
