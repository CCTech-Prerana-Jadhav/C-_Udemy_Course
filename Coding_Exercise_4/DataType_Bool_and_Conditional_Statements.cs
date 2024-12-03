using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void CheckLogin()
        {
            bool isLoggedIn;

            isLoggedIn = true;

            if (isLoggedIn)
            {
                Console.WriteLine("Welcome back!");
            }
            else
            {
                Console.WriteLine("Please log in.");
            }
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.CheckLogin();
        }
    }
}
