// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
IPayment factory = PaymentFactory.CreatePaymentMethod("upi");
factory.Pay();