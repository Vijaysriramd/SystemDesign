namespace DesignPatterns.Adapter
{
    public class StripeAdapter : IPaymentGateway
    {
        private readonly StripeApp _stripeApp;
        private readonly string _apiKey;

        public StripeAdapter(StripeApp stripeApp, string apiKey)
        {
            _stripeApp = stripeApp;
            _apiKey = apiKey;
        }

        public void Pay(string orderId, double amount)
        {
            _stripeApp.ProcessPayment(_apiKey, orderId, amount);
        }
    }
}
