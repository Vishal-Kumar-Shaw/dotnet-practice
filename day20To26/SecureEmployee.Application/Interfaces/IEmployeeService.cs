using SecureEmployee.Domain.Entities;
using SecureEmployee.Application.DTOs;
namespace SecureEmployee.Application.Interfaces;


public interface IEmployeeService
{
    Task<List<EmployeeResponseDTO>> GetAllAsync();
    Task<Employee> GetByIdAsync(int id);
    Task AddAsync(Employee employee);
    Task DeleteAsync(int id);
}