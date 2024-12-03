using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static int DoubleValue(int number)
        {
            return number * 2;
        }

        public static void Main(string[] args)
        {
            int result = DoubleValue(10);
            Console.WriteLine(result);
        }
    }
}
