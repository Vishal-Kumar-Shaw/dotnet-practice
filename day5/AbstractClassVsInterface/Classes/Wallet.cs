public class Wallet: IPayment
{
    public void Pay()
    {
        Console.WriteLine("Paid using wallet");
    }
}