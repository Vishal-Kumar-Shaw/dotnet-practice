// SecureEmployee.Application/Interfaces/IEmployeeRepository.cs
using SecureEmployee.Domain.Entities;

namespace SecureEmployee.Application.Interfaces;

public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> GetAllAsync();
    Task<Employee> GetByIdAsync(int id);
    Task AddAsync(Employee employee);
    Task DeleteAsync(int id);
}