namespace DesignPatterns.Adapter
{
    public class PaypalApp
    {
        public void MakePayment(string email, string orderId, double amount)
        {
            Console.WriteLine($"PayPal payment of ${amount} for order {orderId} using email {email}");
        }
    }
}
