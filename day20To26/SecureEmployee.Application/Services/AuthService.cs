using SecureEmployee.Domain.Entities;
using SecureEmployee.Application.Interfaces;
using System.Data.Common;
using SecureEmployee.Application.DTOs;

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
    public async Task<AuthResponseDTO> AuthenticateAsync(string email, string password)
    {
        var user = await _repo.GetByEmailAsync(email);

        if (user == null || !_hasher.Verify(password, user.PasswordHash))
            throw new UnauthorizedAccessException("Invalid credentials");
        var accessToken = _tokenService.GenerateToken(user);
        user.RefreshToken = _tokenService.GenerateRefreshToken();
        user.RefreshTokenExpiryTime = DateTime.UtcNow.AddMinutes(5); // 5 for testing purposes
        await _repo.UpdateAsync(user);

        return new AuthResponseDTO
        {
            AccessToken = accessToken,
            RefreshToken = user.RefreshToken
        };
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
    public async Task<AuthResponseDTO> RefreshTokenAsync(string refreshToken)
    {
        var user = await _repo.GetByRefreshTokenAsync(refreshToken);

        if (user == null || user.RefreshTokenExpiryTime < DateTime.UtcNow)
            throw new UnauthorizedAccessException("Invalid refresh token");

        var newAccessToken = _tokenService.GenerateToken(user);
        var newRefreshToken = _tokenService.GenerateRefreshToken();

        user.RefreshToken = newRefreshToken;
        user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(7);

        await _repo.UpdateAsync(user);

        return new AuthResponseDTO
        {
            AccessToken = newAccessToken,
            RefreshToken = newRefreshToken
        };
    }
}