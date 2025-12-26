using Microsoft.AspNetCore.Mvc;
using SecureEmployee.Application.Interfaces;
using SecureEmployee.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using SecureEmployee.Application.Common.Interfaces;

[ApiController] 
[Route("api/employees")]

public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;
    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }
    [Authorize(Roles = "GlobalAdmin")]
    [HttpGet]
    public async Task<IActionResult> GetAllEmployees()
    {
        var employees = await _employeeService.GetAllAsync();
        return Ok(employees);
    }
    [Authorize]
    [HttpGet("{id}")]
    public async Task<IActionResult> GetEmployeeById(int id)
    {
        var employee = await _employeeService.GetByIdAsync(id);
        return Ok(employee);
    }
    [Authorize(Roles = "GlobalAdmin")]
    [HttpPost]
    public async Task<IActionResult> AddEmployee(Employee employee)
    {
        await _employeeService.AddAsync(employee);
        return Ok(employee);
    }
    [Authorize(Roles = "GlobalAdmin")]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEmployee(int id)
    {
        await _employeeService.DeleteAsync(id);
        return Ok();
    }
    [Authorize]
    [HttpGet("me")]
    public IActionResult Me([FromServices] ICurrentUserService currentUser)
    {
        return Ok(new
        {
            currentUser.IsAuthenticated,
            currentUser.UserId,
            currentUser.Email,
            currentUser.Role
        });
    }

}