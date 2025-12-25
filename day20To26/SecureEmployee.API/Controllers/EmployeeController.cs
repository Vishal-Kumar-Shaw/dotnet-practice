using Microsoft.AspNetCore.Mvc;
using SecureEmployee.Application.Interfaces;
using SecureEmployee.Domain.Entities;
using Microsoft.AspNetCore.Authorization;

[Authorize(Roles = "GlobalAdmin")]
[ApiController] 
[Route("api/employees")]

public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;
    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }
    [HttpGet]
    public async Task<IActionResult> GetAllEmployees()
    {
        var employees = await _employeeService.GetAllAsync();
        return Ok(employees);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetEmployeeById(int id)
    {
        var employee = await _employeeService.GetByIdAsync(id);
        return Ok(employee);
    }
    [HttpPost]
    public async Task<IActionResult> AddEmployee(Employee employee)
    {
        await _employeeService.AddAsync(employee);
        return Ok(employee);
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEmployee(int id)
    {
        await _employeeService.DeleteAsync(id);
        return Ok();
    }
}