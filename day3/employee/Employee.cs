class Employee
{
    private string _name;
    private decimal _salary;
    public string Name
    {
        get =>  _name;
        set
        {
            if(value == "" || value == null)
            {
                Console.WriteLine("Error: Name Can't be empty");
                // throw new ArgumentExeption("Name Can't be empty");
            }
            else
            {
                _name = value;
            }
        }

    }
    public decimal Salary
    {
        get => _salary;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Trying to set negative salary...");
                Console.WriteLine("Error: Salary cannot be negative.");
                throw new ArgumentException("Invalid salary");
                // return;
            }
            else
            {
                _salary = value;
            }
        }
    }

    public Employee(string name, decimal salary)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
             throw new ArgumentException("Name cannot be empty");
        }
        if (salary < 0)
        {
            throw new ArgumentException("Salary cannot be negative");
        }
        Name = name;
        Salary = salary;
        // Console.WriteLine($"Employee Created: {Name}, Salary: {Salary}");
        Display();
    }
    public void GiveBonus(decimal amount)
    {
        if (amount >= 0)
        {
            Console.WriteLine($"Adding bonus RS.{amount}");
            Salary += amount;
            Console.WriteLine($"Updated salary: {Salary}");
        }
    }
    public void Display()
    {
        Console.WriteLine($"Employee {Name} : Salary {Salary}");
    }
}