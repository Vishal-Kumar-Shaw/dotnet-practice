public class Response<T>
{
    public bool Success {get; set;}
    public string Message {get; set;}
    public T Data {get; set;}
    public Response(T value, bool success, string msg)
    {
        Success = success;
        Message = msg;
        Data = value;
        Console.WriteLine($"Object created value "+value);
    }
}