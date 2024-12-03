using System;

namespace Coding.Exercise
{
    public struct Event
    {
        public DateTime StartDate;
        public DateTime EndDate;

        public Event(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        public double GetDuration()
        {
            return (EndDate - StartDate).TotalDays;
        }

        public bool IsOverlapping(Event otherEvent)
        {
            return (StartDate < otherEvent.EndDate && EndDate > otherEvent.StartDate);
        }
    }

    public class Exercise
    {
        public void TestEvents()
        {
            Event event1 = new Event(new DateTime(2024, 7, 1), new DateTime(2024, 7, 10)); // July 1 to 10
            Event event2 = new Event(new DateTime(2024, 7, 5), new DateTime(2024, 7, 15)); // July 5 to 15

            Console.WriteLine($"Event 1 Duration: {event1.GetDuration()} days");
            Console.WriteLine($"Event 2 Duration: {event2.GetDuration()} days");

            bool overlap = event1.IsOverlapping(event2);
            Console.WriteLine($"Events Overlap: {overlap}");
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.TestEvents();
        }
    }
}
