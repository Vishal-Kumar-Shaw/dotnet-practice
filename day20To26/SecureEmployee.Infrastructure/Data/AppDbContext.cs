// SecureEmployee.Infrastructure/Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using SecureEmployee.Domain.Entities;

namespace SecureEmployee.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Employee> Employees => Set<Employee>();
}