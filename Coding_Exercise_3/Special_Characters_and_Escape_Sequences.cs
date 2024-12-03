using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintSpecialCharacters()
        {
            Console.WriteLine("Hello\n\tWorld!");
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintSpecialCharacters();
        }
    }
}
