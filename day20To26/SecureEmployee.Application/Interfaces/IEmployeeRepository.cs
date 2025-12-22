// SecureEmployee.Application/Interfaces/IEmployeeRepository.cs
using SecureEmployee.Domain.Entities;

namespace SecureEmployee.Application.Interfaces;

public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> GetAllAsync();
}