using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/employees")]
public class EmployeeController: ControllerBase
{
    private readonly IEmployeeService _service;
    public EmployeeController(IEmployeeService service)
    {
        _service = service;
    }
    [HttpGet]
    public async Task<IActionResult> GetAllEmployeeAsync()
    {
        var employees = _service.GetAllEmployeeAsync();
        return Ok(employees);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetEmployeeById(int id)
    {
        var emp = await _service.GetEmployeeByIdAsync(id);
        return Ok(emp);
    }
    [HttpPost]
    public async Task AddEmployee(Employee emp)
    {
        await _service.AddEmployeeAsync(emp);
        Ok("Employee Created");
    }
}