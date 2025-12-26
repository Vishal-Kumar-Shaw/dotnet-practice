using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using SecureEmployee.Application.Common.Interfaces;

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
    
    public Guid UserId =>
        Guid.Parse(User?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "0");

    public string Email =>
        User?.FindFirst(ClaimTypes.Email)?.Value ?? string.Empty;

    public string Role =>
        User?.FindFirst(ClaimTypes.Role)?.Value ?? string.Empty;
}