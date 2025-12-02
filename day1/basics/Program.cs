// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

BankAccount account = new BankAccount("Vishal", 123456,1000.00m);
account.Deposit(500.00m);
account.Withdraw(200.00m);
account.GetBalance();