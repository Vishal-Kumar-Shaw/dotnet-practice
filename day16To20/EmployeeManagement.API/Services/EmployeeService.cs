public class EmployeeService: IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;
    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }
    public async Task<List<Employee>> GetAllEmployeeAsync()
    {
        Console.WriteLine("Request received in Service");
        return await _employeeRepository.GetAllEmployeeAsync();
    }
    public async Task<Employee?> GetEmployeeByIdAsync(int id)
    {
        var emp = await _employeeRepository.GetEmployeeByIdAsync(id) ?? throw new UserNotFoundException($"Employee with id {id} not found");
        return emp;
    }
    public async Task AddEmployeeAsync(Employee employee)
    {
        if(employee.Salary < 0)
        {
            throw new BadRequestException("Salary cannot be negative");
        }
        await _employeeRepository.AddAsync(employee);    
    }
}