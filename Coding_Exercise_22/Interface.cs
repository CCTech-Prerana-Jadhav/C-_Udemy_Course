using System;

namespace Coding.Exercise
{
    public interface IVehicle
    {
        void Drive();
    }

    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }
    }

    public class Exercise
    {
        public void TestDrive()
        {
            Car car = new Car();
            car.Drive();
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.TestDrive();
        }
    }
}
