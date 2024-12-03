using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void SimpleCalculator()
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an operation: +, -, *, /");
            string operation = Console.ReadLine();

            double result;

            if (operation == "+")
            {
                result = num1 + num2;
                Console.WriteLine("Result: " + result);
            }
            else if (operation == "-")
            {
                result = num1 - num2;
                Console.WriteLine("Result: " + result);
            }
            else if (operation == "*")
            {
                result = num1 * num2;
                Console.WriteLine("Result: " + result);
            }
            else if (operation == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                }
            }
            else
            {
                Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
            }
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.SimpleCalculator();
        }
    }
}
