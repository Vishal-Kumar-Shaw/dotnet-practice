// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Response<int> r1 = new Response<int>(5,true,"This is the first one");
Response<string> r2 = new Response<string>("Vishal", false, "This is the second one");

Response<Employee> r3 = new Response<Employee>(new Employee("Vishal", "IT"), true, "this is an employee");
