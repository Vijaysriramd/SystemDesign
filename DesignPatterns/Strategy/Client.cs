using System;

namespace DesignPatterns.Strategy
{
    public class Client
    {
        public static void Demo()
        {
            Console.WriteLine("=== Strategy Pattern Demo ===");

            var cart = new ShoppingCart();

            // Use different payment strategies
            cart.SetPaymentStrategy(new CreditCardPayment("1234567890123456"));
            cart.Checkout(100.50);

            cart.SetPaymentStrategy(new PayPalPayment("user@example.com"));
            cart.Checkout(75.25);

            cart.SetPaymentStrategy(new BitcoinPayment("1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa"));
            cart.Checkout(200.00);
        }
    }
}

