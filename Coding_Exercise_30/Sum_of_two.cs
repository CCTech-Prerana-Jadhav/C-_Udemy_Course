using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static int SumOfTwo(int[] nums, int SumToFind)
        {
            HashSet<int> seen = new HashSet<int>();
            HashSet<Tuple<int, int>> uniquePairs = new HashSet<Tuple<int, int>>();

            foreach (int num in nums)
            {
                int complement = SumToFind - num;

                if (seen.Contains(complement))
                {
                    var pair = num < complement ? Tuple.Create(num, complement) : Tuple.Create(complement, num);
                    uniquePairs.Add(pair);
                }

                seen.Add(num);
            }

            return uniquePairs.Count;
        }

        public static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 3, 2 };
            int sumToFind = 5;
            int result = SumOfTwo(nums, sumToFind);
            Console.WriteLine($"Number of unique pairs: {result}");
        }
    }
}
