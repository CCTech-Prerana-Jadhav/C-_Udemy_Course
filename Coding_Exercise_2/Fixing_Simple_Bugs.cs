﻿using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void CalculateAverage()
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            int average = (num1 + num2 + num3) / 3;  // Calculate the average
            Console.WriteLine("The average is: " + average);  // Output the result
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();  
            exercise.CalculateAverage(); 
        }
    }
}
