using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static int NotHungryCats(string kitchen)
        {
            kitchen = kitchen.Replace(" ", "");
            string[] parts = kitchen.Split('F');
            if (parts.Length != 2) return 0;

            string left = parts[0];
            string right = parts[1];
            int notHungryCats = 0;

            for (int i = 0; i < left.Length; i += 2)
            {
                if (left[i] == 'O') notHungryCats++;
            }

            for (int i = 0; i < right.Length; i += 2)
            {
                if (right[i] == '~') notHungryCats++;
            }

            return notHungryCats;
        }

        public static void Main(string[] args)
        {
            string kitchen = "O O F ~ ~ ~";
            int result = NotHungryCats(kitchen);
            Console.WriteLine($"Number of not hungry cats: {result}");
        }
    }
}
