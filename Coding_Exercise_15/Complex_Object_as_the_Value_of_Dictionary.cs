using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintDictionaryValues()
        {
            Dictionary<string, List<int>> myDictionary = new Dictionary<string, List<int>>()
            {
                { "Numbers", new List<int> { 1, 2, 3 } }
            };

            List<int> numbers = myDictionary["Numbers"];

            foreach (var i in numbers)
            {
                Console.Write(i + " ");
            }
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintDictionaryValues();
        }
    }
}
