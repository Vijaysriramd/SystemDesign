using System;

namespace DesignPatterns.Strategy
{
    public class BitcoinPayment : IPaymentStrategy
    {
        private readonly string _walletAddress;

        public BitcoinPayment(string walletAddress)
        {
            _walletAddress = walletAddress;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Paid ${amount} using Bitcoin wallet: {_walletAddress.Substring(0, 8)}...");
        }
    }
}

