using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using SecureEmployee.Application.Common.Interfaces;
using SecureEmployee.Application.DTOs;

public class CurrentUserService : ICurrentUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CurrentUserService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    private ClaimsPrincipal? User => _httpContextAccessor.HttpContext?.User;

    public bool IsAuthenticated =>
        User?.Identity?.IsAuthenticated ?? false;

    public Guid UserId
    {
        get
        {
            var value = User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return Guid.TryParse(value, out var id) ? id : Guid.Empty;
        }
    }

    public string Email =>
        User?.FindFirst(ClaimTypes.Email)?.Value ?? string.Empty;

    public string Role =>
        User?.FindFirst(ClaimTypes.Role)?.Value ?? string.Empty;

    public UserProfileDTO GetProfile()
    {
        return new UserProfileDTO
        {
            Id = UserId,
            Email = Email,
            Role = Role
        };
    }
}
