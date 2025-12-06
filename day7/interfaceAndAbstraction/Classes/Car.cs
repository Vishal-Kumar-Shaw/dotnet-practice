public class Car: Vehicle
{
    public Car(string brand, string model): base(brand, model){}
    public override void Start()
    {
        Console.WriteLine("Car Started");
    }
}