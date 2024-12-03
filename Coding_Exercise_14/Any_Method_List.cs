using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void CheckAny()
        {
            List<int> myNumbers = new List<int> { 1, 6, 3 };

            bool result = myNumbers.Any(x => x > 5);

            Console.WriteLine(result);
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.CheckAny();
        }
    }
}
