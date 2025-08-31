using System;

namespace DesignPatterns.Adapter
{
    public class Client
    {
        public static void Demo()
        {
            var legacyPaypalApp = new PaypalApp();
            IPaymentGateway paymentGateway = new PaypalAdapter(legacyPaypalApp, "xyz@gmail.com");
            paymentGateway.Pay("order123", 2312.90);

            var stripeApp = new StripeApp();
            IPaymentGateway paymentGateway1 = new StripeAdapter(stripeApp, Guid.NewGuid().ToString());
            paymentGateway1.Pay("order123", 2312.90);
        }
    }
}
