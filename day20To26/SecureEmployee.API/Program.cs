// SecureEmployee.API/Program.cs
using Microsoft.EntityFrameworkCore;
using SecureEmployee.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Postgres Connection String
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();
app.Run();