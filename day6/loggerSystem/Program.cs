// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
ILogger logger = new ConsoleLogger();
logger.Log("This is for testing");
logger.Info("This is for information testing");