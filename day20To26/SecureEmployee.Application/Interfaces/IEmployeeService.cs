using SecureEmployee.Domain.Entities;
namespace SecureEmployee.Application.Interfaces;
public interface IEmployeeService
{
    Task<List<Employee>> GetAllAsync();
    Task<Employee> GetByIdAsync(int id);
    Task AddAsync(Employee employee);
    Task DeleteAsync(int id);
}