using SecureEmployee.Domain.Entities;
using SecureEmployee.Application.Interfaces;
using System.Data.Common;

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
    public async Task RegisterAsync(RegisterRequest request)
    {
        var existingUser = await _repo.GetByEmailAsync(request.Email);
        if (existingUser != null)
            throw new InvalidOperationException("User already exists");

        var passwordHash = _hasher.Hash(request.Password);
        var id = Guid.NewGuid();

        var newUser = new User
        {
            Id = id,
            Email = request.Email,
            PasswordHash = passwordHash,
            Role = request.Role,
            IsActive = "Yes"
        };

        await _repo.AddAsync(newUser);
    }
}