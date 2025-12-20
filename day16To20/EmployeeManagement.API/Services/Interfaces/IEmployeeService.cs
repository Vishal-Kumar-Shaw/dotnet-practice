public interface IEmployeeService
{
    Task<List<Employee>> GetAllEmployeeAsync();
    Task<Employee?> GetEmployeeByIdAsync(int id);
    Task AddEmployeeAsync(Employee employee);
}