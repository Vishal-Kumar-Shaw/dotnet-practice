public class FileLogger: ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("Writing to file..."+message);
    }
}