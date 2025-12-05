// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
IPayment p1 = new Card();
p1.Pay();
IPayment p2 = new UPI();
p2.Pay();
IPayment p3 = new Wallet();
p3.Pay();