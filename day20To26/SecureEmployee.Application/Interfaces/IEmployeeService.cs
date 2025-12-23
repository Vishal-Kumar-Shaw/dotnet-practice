using SecureEmployee.Domain.Entities;

public interface IEmployeeService
{
    Task<List<Employee>> GetAllAsync();
    Task<Employee> GetByIdAsync(int id);
    Task AddAsync(Employee employee);

}