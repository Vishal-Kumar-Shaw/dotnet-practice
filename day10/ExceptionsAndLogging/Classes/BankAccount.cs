public class BankAccount
{
    public string Name {get; set;}
    public double Balance {get; set;}

    public BankAccount(string name, double balance)
    {
        Name = name;
        Balance = balance;
    }
    public void Withdraw(double amount)
    {
        if(amount < 0)
        {
            throw new InvalidAmountException("Amount can't be negative");
        }
        if(amount < Balance)
        {
            throw new InsufficientFundsException("Insuffficient funds");
        }
       
        Balance -= amount;
        Console.WriteLine($"Balance withdraw successful: RS. {amount}");
    }
}