// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Vehicle v1 = new Car("Tata", "Nexon");
v1.Start();
v1.ShowDetails();


VehicleManager vm1 = new VehicleManager(new CarService());
vm1.PerformService();

VehicleManager vm2 = new VehicleManager(new BikeService());
vm2.PerformService();

