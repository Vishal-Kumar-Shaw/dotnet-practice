// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var departments = new List<Department>
{
    new Department { Id = 1, Name = "IT" },
    new Department { Id = 2, Name = "HR" },
    new Department { Id = 3, Name = "Finance" },
    new Department { Id = 4, Name = "Marketing" },
    new Department { Id = 5, Name = "Operations" }
};

var employees = new List<Employee>
{
    new Employee { Id = 1, Name = "Vishal Shaw", Salary = 65000, DepartmentId = 1 },
    new Employee { Id = 2, Name = "Rohan Singh", Salary = 48000, DepartmentId = 2 },
    new Employee { Id = 3, Name = "Aditi Mehra", Salary = 54000, DepartmentId = 1 },
    new Employee { Id = 4, Name = "Karan Patel", Salary = 75000, DepartmentId = 3 },
    new Employee { Id = 5, Name = "Sneha Kapoor", Salary = 52000, DepartmentId = 4 },
    new Employee { Id = 6, Name = "Saurabh Das", Salary = 30000, DepartmentId = 2 },
    new Employee { Id = 7, Name = "Priya Nair", Salary = 85000, DepartmentId = 1 },
    new Employee { Id = 8, Name = "Aman Verma", Salary = 42000, DepartmentId = 5 },
    new Employee { Id = 9, Name = "Neha Gupta", Salary = 90000, DepartmentId = 3 },
    new Employee { Id = 10, Name = "Manish Tiwari", Salary = 38000, DepartmentId = 4 },
    new Employee { Id = 11, Name = "Harsh Sharma", Salary = 55000, DepartmentId = 1 },
    new Employee { Id = 12, Name = "Sanya Jain", Salary = 62000, DepartmentId = 5 },
    new Employee { Id = 13, Name = "Pooja Reddy", Salary = 76000, DepartmentId = 2 },
    new Employee { Id = 14, Name = "Devendra Rao", Salary = 45000, DepartmentId = 5 },
    new Employee { Id = 15, Name = "Ankit Yadav", Salary = 51000, DepartmentId = 3 }
};
// Easy ones
// 1 - Select All employees
var All_employees = employees.Select(emp => emp);
// 2 - Employee Names
var emp_names = employees.Select(emp => emp.Name);
// 3 - Employee salary > 50k
var emp_good_salary = employees.Where(emp => emp.Salary > 50000);
// 4 - Employee Name Starts with "A"
var emp_a = employees.Where(emp => emp.Name.StartsWith("A"));
// 5 - Sort employees by name ascending
var emp_asc = employees.OrderBy(emp => emp.Name);
// 6 - Sort employees by salary descending
var emp_desc_sal = employees.OrderByDescending(emp => emp.Salary);
// 7 - Find employee with Id 5
var emp_id_5 = employees.FirstOrDefault(emp => emp.Id == 5);
// 8 - Count Employee in IT department
var emp_it = employees.Join(
    departments,
    emp => emp.DepartmentId,
    dept => dept.Id,
    (emp, dept) => new { Employee = emp, Department = dept})
.Where(joined => joined.Department.Name=="IT")
.Count();
Console.WriteLine(emp_it);
// 9 - Check if any employee earns more than 1,00,000
var isEmployeeEarningLakh = employees.FirstOrDefault(x => x.Salary>100000) != null;

// 10 - Find minimum & maximum salary
int n = employees.Count();
var emp_order = employees.OrderBy(emp => emp.Salary).ToList();
Employee highest = emp_order[n-1];
Employee lowest  = emp_order[0];
Console.WriteLine($"Highest - {highest.Salary}, Lowest - {lowest.Salary}");


// Polished version By chatGPT
// 1. all employees (snapshot)
var allEmployees = employees.ToList();

// 2. employee names
var empNames = employees.Select(e => e.Name);

// 3. salary > 50k (materialized)
var empGoodSalary = employees.Where(e => e.Salary > 50000m).ToList();

// 4. Name starts with A (case-insensitive)
var empA = employees.Where(e => e.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();

// 5. Sort by name ascending
var empAsc = employees.OrderBy(e => e.Name).ToList();

// 6. Sort by salary desc
var empDescSal = employees.OrderByDescending(e => e.Salary).ToList();

// 7. Find Id = 5
var empId5 = employees.FirstOrDefault(e => e.Id == 5);
if (empId5 != null) Console.WriteLine(empId5.Name);

// 8. Count employees in IT
var itId = departments.FirstOrDefault(d => d.Name == "IT")?.Id;
var empItCount = itId.HasValue ? employees.Count(e => e.DepartmentId == itId.Value) : 0;

// 9. any earning > 1,00,000
var anyEarningLakh = employees.Any(e => e.Salary > 100000m);

// 10. min & max safely
var highest2 = employees.Count > 0 ? employees.MaxBy(e => e.Salary) : null; // .MaxBy needs .NET 6+
var lowest2  = employees.Count > 0 ? employees.MinBy(e => e.Salary) : null;

if (highest2 != null && lowest2 != null)
    Console.WriteLine($"Highest - {highest.Salary}, Lowest - {lowest.Salary}");
