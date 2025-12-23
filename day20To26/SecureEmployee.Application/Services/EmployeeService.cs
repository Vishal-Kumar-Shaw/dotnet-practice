using SecureEmployee.Application.Interfaces;
using SecureEmployee.Domain.Entities;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _repo;
    public EmployeeService(IEmployeeRepository repo)
    {
        _repo = repo;
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
        var employees = await _repo.GetAllAsync();
        return employees.ToList();
    }

    public async Task<Employee> GetByIdAsync(int id)
    {
        return await _repo.GetByIdAsync(id);
    }
}