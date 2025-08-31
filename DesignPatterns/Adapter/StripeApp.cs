namespace DesignPatterns.Adapter
{
    public class StripeApp
    {
        public void ProcessPayment(string apiKey, string orderId, double amount)
        {
            Console.WriteLine($"Stripe payment of ${amount} for order {orderId} using API key {apiKey}");
        }
    }
}
