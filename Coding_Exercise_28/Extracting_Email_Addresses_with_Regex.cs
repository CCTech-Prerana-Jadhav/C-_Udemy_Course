using System;
using System.Text.RegularExpressions;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void ExtractPatterns(string input)
        {
            string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count == 0)
            {
                Console.WriteLine("No email addresses found.");
            }

            foreach (Match match in matches)
            {
                Console.WriteLine($"Found email: {match.Value}");
            }
        }

        public static void Main(string[] args)
        {
            var exercise = new Exercise();

            string input = "Contact us at support@example.com or sales@company.org. Visit our website at www.example.com.";
            Console.WriteLine("Extracting email addresses from input:");
            exercise.ExtractPatterns(input);
        }
    }
}
