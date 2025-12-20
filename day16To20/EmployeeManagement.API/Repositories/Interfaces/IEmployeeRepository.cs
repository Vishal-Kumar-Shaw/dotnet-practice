public interface IEmployeeRepository
{
    public Task<List<Employee>> GetAllEmployeeAsync();
    public Task<Employee?> GetEmployeeByIdAsync(int id);
    public Task AddAsync(Employee employee);
}