using System;

namespace Coding.Exercise
{
    public class MyClass
    {
        private readonly string _value;

        public string Value
        {
            get { return _value; }
        }

        public MyClass(string value)
        {
            _value = value;
        }
    }

    public class Exercise
    {
        public void PrintReadOnlyProperty()
        {
            MyClass myObject = new MyClass("Read-Only Property Value");
            Console.WriteLine(myObject.Value);
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintReadOnlyProperty();
        }
    }
}
