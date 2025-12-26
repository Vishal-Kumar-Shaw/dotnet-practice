using Microsoft.AspNetCore.Mvc;
using SecureEmployee.Application.Interfaces;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;
    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        Console.WriteLine("Login Request Received");
        var token = await _authService.AuthenticateAsync(request.Email, request.Password);
        return Ok(new { Token = token });
    }
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterRequest request)
    {
        await _authService.RegisterAsync(request);
        return Ok(new { Message = "User registered successfully" });
    }
}