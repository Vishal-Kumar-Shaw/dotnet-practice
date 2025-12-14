using Microsoft.AspNetCore.Mvc;

namespace AsyncDemo.API.Controllers;
[ApiController]
[Route("api/[controller]")]
public class UserController: ControllerBase
{
    private readonly IUserService _userService;
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("test")]
    public IActionResult Test()
    {
        return Ok("API is working");
    }

    [HttpGet("users")]
    public async Task<IActionResult> GetUsers()
    {
        var users = await _userService.GetUsersAsync();
        return Ok(users);
    }
    [HttpGet("users-sync")]
    public IActionResult GetUsersAsync()
    {
        Thread.Sleep(3000);
        return Ok("Sync Users");

    } 
}