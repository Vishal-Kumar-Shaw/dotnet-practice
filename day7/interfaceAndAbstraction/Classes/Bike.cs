public class Bike: Vehicle
{
    public Bike(string brand, string model): base(brand, model){}
    public override void Start()
    {
        Console.WriteLine("Bike Started...");
    }
}