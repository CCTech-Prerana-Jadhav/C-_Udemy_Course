using System;

namespace Coding.Exercise
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("Person constructor: John Doe");
        }
    }

    public class Employee : Person
    {
        public Employee()
        {
            Console.WriteLine("Employee constructor: John Doe, ID: 123");
        }
    }

    public class Exercise
    {
        public void PrintMessages()
        {
            Person John = new Employee();
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintMessages();
        }
    }
}
