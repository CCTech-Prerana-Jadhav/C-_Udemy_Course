using System;

namespace Coding.Exercise
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    public class Exercise
    {
        public void PrintSounds()
        {
            Animal animal = new Animal();
            animal.MakeSound();
            Animal dog = new Dog();
            dog.MakeSound();
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintSounds();
        }
    }
}
