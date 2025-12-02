class Student
{
    private string Name;
    private int Marks;

    public Student(string name, int marks)
    {
        Name = name;
        SetMarks(marks);
        Console.WriteLine($"Student Created: {Name} , Marks: {Marks}");
    }
    public string GetName()
    {
        return Name;
    }
    public void SetName(string name)
    {
        Name = name;
    }
    public int GetMarks()
    {
        return Marks;
    }
    public void SetMarks(int marks)
    {
        if (marks >= 0 && marks <= 100)
        {
            Marks = marks;
        }
        else
        {
            Console.WriteLine($"Trying to set invalid marks: {marks}");
        }
    }

    public void AddGraceMarks(int grace)
    {
        if (grace > 0)
        {
            if(Marks + grace <= 100)
            {
                Marks += grace;
            }
            else
            {
                Marks = 100;
            }
            Console.WriteLine($"Adding grace marks: {grace}");
            Console.WriteLine($"New Marks: {Marks}");
        }
        else
        {
            Console.WriteLine("Grace marks should be positive.");
        }
    }

}