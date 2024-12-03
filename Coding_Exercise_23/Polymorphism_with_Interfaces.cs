using System;

namespace Coding.Exercise
{
    public interface IPayment
    {
        void ProcessPayment();
    }

    public class CreditCardPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment");
        }
    }

    public class PayPalPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal payment");
        }
    }

    public class Exercise
    {
        public void ProcessPayments()
        {
            CreditCardPayment creditPayment = new CreditCardPayment();
            creditPayment.ProcessPayment();

            PayPalPayment payPayment = new PayPalPayment();
            payPayment.ProcessPayment();
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.ProcessPayments();
        }
    }
}
