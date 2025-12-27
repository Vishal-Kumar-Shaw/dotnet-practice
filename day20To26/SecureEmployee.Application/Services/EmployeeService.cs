using SecureEmployee.Application.Interfaces;
using SecureEmployee.Domain.Entities;
using SecureEmployee.Application.Common.Interfaces;
using SecureEmployee.Application.Common.Exceptions;

namespace SecureEmployee.Application.Services;
public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _repo;
    private readonly ICurrentUserService _currentUserService;
    public EmployeeService(IEmployeeRepository repo, ICurrentUserService currentUserService)
    {
        _repo = repo;
        _currentUserService = currentUserService;
    }
    public async Task AddAsync(Employee employee)
    {
        await _repo.AddAsync(employee);
    }

    public async Task DeleteAsync(int id)
    {
        await _repo.DeleteAsync(id);
    }

    public async Task<List<Employee>> GetAllAsync()
    {
        Console.WriteLine($"User {_currentUserService.Email} with role {_currentUserService.Role} accessed employees");
        var employees = await _repo.GetAllAsync();
        return employees.ToList();
    }

    public async Task<Employee> GetByIdAsync(int id)
    {
        
        var emp = await _repo.GetByIdAsync(id);
        if(emp == null)
        {
            throw new NotFoundException("Employee not found");
        }
        // owner check
        if(_currentUserService.Role != "GlobalAdmin" && emp.UserId != _currentUserService.UserId)
        {
            throw new ForbiddenException("You do not have access to this employee");
        }
        return emp;
    }
}