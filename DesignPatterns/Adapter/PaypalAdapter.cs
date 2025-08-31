namespace DesignPatterns.Adapter
{
    public class PaypalAdapter : IPaymentGateway
    {
        private readonly PaypalApp _paypalApp;
        private readonly string _email;

        public PaypalAdapter(PaypalApp paypalApp, string email)
        {
            _paypalApp = paypalApp;
            _email = email;
        }

        public void Pay(string orderId, double amount)
        {
            _paypalApp.MakePayment(_email, orderId, amount);
        }
    }
}
