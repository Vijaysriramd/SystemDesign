using System;

namespace DesignPatterns.Strategy
{
    public class ShoppingCart
    {
        private IPaymentStrategy _paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void Checkout(double amount)
        {
            if (_paymentStrategy == null)
            {
                Console.WriteLine("Please select a payment method first.");
                return;
            }

            _paymentStrategy.Pay(amount);
        }
    }
}

