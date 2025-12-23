using Microsoft.EntityFrameworkCore;
using SecureEmployee.Application.Interfaces;
using SecureEmployee.Domain.Entities;
using SecureEmployee.Infrastructure.Data;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly AppDbContext _db;
    public EmployeeRepository(AppDbContext db)
    {
        _db = db;
    }
    public async Task AddAsync(Employee employee)
    {
        await _db.Employees.AddAsync(employee);
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Employee>> GetAllAsync()
    {
        return await _db.Employees.ToListAsync();
    }

    public async Task<Employee> GetByIdAsync(int id)
    {
        return await _db.Employees.FirstOrDefaultAsync(e => e.Id == id) 
               ?? throw new InvalidOperationException($"Employee with ID {id} not found.");
    }
}