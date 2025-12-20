public class EmployeeRepository: IEmployeeRepository
{
    private readonly List<Employee> _employees = new()
    {
        new Employee{Id = 1, Name = "Vishal", Salary = 60000, Department = "IT"},
        new Employee{Id=2, Name="Rahul", Salary=70000, Department="HR"}
    }; 
    public async Task<List<Employee>> GetAllEmployeeAsync()
    {
        await Task.Delay(1000);
        return _employees;
    }
    public async Task<Employee?> GetEmployeeByIdAsync(int id)
    {
        await Task.Delay(1000);
        return _employees.FirstOrDefault(emp => emp.Id==id);

    }
    public async Task AddAsync(Employee employee)
    {
        await Task.Delay(1000);
        _employees.Add(employee);
    }
}