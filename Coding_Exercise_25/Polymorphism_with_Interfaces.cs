using System;

namespace Coding.Exercise
{
    public interface IShape
    {
        double GetArea();
    }

    public class Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }

    public class Rectangle : IShape
    {
        private double _width;
        private double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public double GetArea()
        {
            return _width * _height;
        }
    }

    public class Exercise
    {
        public void PrintAreas()
        {
            IShape[] shapes = new IShape[]
            {
                new Circle(5),    // Circle with radius 5
                new Rectangle(4, 6)  // Rectangle with width 4 and height 6
            };

            foreach (IShape shape in shapes)
            {
                Console.WriteLine($"Area: {shape.GetArea()}");
            }
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintAreas();
        }
    }
}
