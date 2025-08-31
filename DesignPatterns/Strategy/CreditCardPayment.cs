using System;

namespace DesignPatterns.Strategy
{
    public class CreditCardPayment : IPaymentStrategy
    {
        private readonly string _cardNumber;

        public CreditCardPayment(string cardNumber)
        {
            _cardNumber = cardNumber;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Paid ${amount} using Credit Card ending in {_cardNumber.Substring(_cardNumber.Length - 4)}");
        }
    }
}

