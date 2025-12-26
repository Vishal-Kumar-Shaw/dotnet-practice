public interface IAuthService
{
    Task<string> AuthenticateAsync(string email, string password);
    Task RegisterAsync(RegisterRequest request);
}