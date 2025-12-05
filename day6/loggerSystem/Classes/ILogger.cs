public interface ILogger
{
    void Log(string message);
    void Info(string info)
    {
        Console.WriteLine("Info: "+info);
    }
}