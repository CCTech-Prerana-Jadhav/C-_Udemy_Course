using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(int id, string name, int grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }
    }

    public class Exercise
    {
        public void PrintStudents()
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>()
            {
                { "John", new Student(1, "John", 85) },
                { "Alice", new Student(2, "Alice", 90) },
                { "Bob", new Student(3, "Bob", 78) }
            };

            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Value.Name}, Id: {student.Value.Id}, Grade: {student.Value.Grade}");
            }
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintStudents();
        }
    }
}
