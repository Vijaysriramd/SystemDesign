namespace DesignPatterns.Adapter
{
    public interface IPaymentGateway
    {
        void Pay(string orderId, double amount);
    }
}
