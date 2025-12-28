using SecureEmployee.Application.DTOs;
public interface IAuthService
{
    Task<AuthResponseDTO> AuthenticateAsync(string email, string password);
    Task RegisterAsync(RegisterRequest request);
    Task<AuthResponseDTO> RefreshTokenAsync(string refreshToken);
}