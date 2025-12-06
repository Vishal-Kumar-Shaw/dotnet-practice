public static class PaymentFactory
{
    public static IPayment CreatePayment(string method)
    {
        switch(method.ToLower())
        {
            case "upi":
                return new UPIPayment();
            case "card":
                return new CardPayment();
            case "wallet":
                return new WalletPayment();
            default:
                throw new Exception("Invalida payment method");    
        }
    }
}