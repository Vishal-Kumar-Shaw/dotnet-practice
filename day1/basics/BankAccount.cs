class BankAccount
{
    public string AccountHolder;
    public int AccountNumber;
    public decimal Balance;

    public BankAccount(string accountHolder, int accountNumber, decimal initialBalance)
    {
        AccountHolder = accountHolder;
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if(amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount:C}. New Balance: {Balance:C}");

        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if(amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew: {amount:C}. New Balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }

    public void GetBalance()
    {
        Console.WriteLine($"Current Balance: {Balance:C}");
    }

    
}