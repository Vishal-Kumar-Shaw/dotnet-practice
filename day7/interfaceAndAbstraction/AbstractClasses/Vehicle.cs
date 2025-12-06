public abstract class Vehicle
{
    public string Brand;
    public string Model;
    public Vehicle(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }
    public void ShowDetails()
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model}");
    }
    public abstract void Start();
}