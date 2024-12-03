using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Animal makes a sound");
            }
        }

        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Dog barks");
            }
        }

        public class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Cat meows");
            }
        }

        public void DemonstrateOverriding()
        {
            Animal animal = new Animal();
            animal.MakeSound();

            Animal dog = new Dog();
            dog.MakeSound();

            Animal cat = new Cat();
            cat.MakeSound();
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.DemonstrateOverriding();
        }
    }
}
