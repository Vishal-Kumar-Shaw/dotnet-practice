public static class PaymentFactory
{
    public static IPayment CreatePaymentMethod(string method)
    {
        switch(method.ToLower())
        {
            case "upi":
                return new UPIPayment();
            case "wallet":
                return new WalletPayment();
            case "card":
                return new CardPayment();
            default:
                throw new Exception("Invalid payment method");
        }
    }
}