using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void HandleMultipleExceptions(string numberString, int index)
        {
            int[] numbers = { 1, 2, 3 };

            try
            {
                int number = int.Parse(numberString);
                Console.WriteLine(numbers[index]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range.");
            }
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.HandleMultipleExceptions("abc", 1); // Example with invalid format
            exercise.HandleMultipleExceptions("123", 5); // Example with index out of range
        }
    }
}
