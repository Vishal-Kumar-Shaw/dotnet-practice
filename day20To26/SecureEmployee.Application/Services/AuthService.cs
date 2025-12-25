using SecureEmployee.Domain.Entities;
using SecureEmployee.Application.Interfaces;
namespace SecureEmployee.Application.Services;
public class AuthService : IAuthService
{
    private readonly IUserRepository _repo;
    private readonly IPasswordHasher _hasher;
    private readonly IJwtTokenService _tokenService;
    public AuthService(IUserRepository repo, IPasswordHasher hasher, IJwtTokenService tokenService)
    {
        _repo = repo;
        _hasher = hasher;
        _tokenService = tokenService;
    }
    public async Task<string> AuthenticateAsync(string email, string password)
    {
        var user = await _repo.GetByEmailAsync(email);

        if (user == null || !_hasher.Verify(password, user.PasswordHash))
            throw new UnauthorizedAccessException("Invalid credentials");

        return _tokenService.GenerateToken(user);
    }
}