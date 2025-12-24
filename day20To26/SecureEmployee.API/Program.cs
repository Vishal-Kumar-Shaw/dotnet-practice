// SecureEmployee.API/Program.cs
using Microsoft.EntityFrameworkCore;
using SecureEmployee.Infrastructure.Data;
using SecureEmployee.Application.Interfaces;
using SecureEmployee.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();


builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();
app.Run();