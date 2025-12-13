// See https://aka.ms/new-console-template for more information
public delegate void StockAlertHandler(string message);

public class Program()
{
    public static void Main()
    {
        StockItem s1 = new StockItem(1, "Tata Motors",10);
        WareHouseService ws = new WareHouseService();

        // subscribing the event
        s1.StockLow += ws.OnStockLow;

        // action
        s1.ReduceStock(5);

    }
}


