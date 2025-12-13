public class StockItem
{
    public int Id {get; set;}
    public string Name {get; set;}
    public int Quantity {get; set;}
    public StockItem(int id, string name, int quantity)
    {
        Id = id;
        Name = name;
        Quantity = quantity;
    }
    // the below is the event - It will shout(pub) and whoever subscribes will listen(sub)
    public event StockAlertHandler StockLow;
    // action event
    public void ReduceStock(int amount)
    {
        Quantity -= amount;
        if(Quantity <= 5)
        {
            StockLow?.Invoke($"Stock low! for {Name}, Quantity left {Quantity}");
        }
    }

}