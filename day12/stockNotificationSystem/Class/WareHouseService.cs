public class WareHouseService
{
    public void OnStockLow(string message)
    {
        Console.WriteLine("Warehouse alert: "+ message);
    }
}