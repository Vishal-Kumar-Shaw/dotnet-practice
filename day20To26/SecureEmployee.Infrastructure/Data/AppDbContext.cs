// SecureEmployee.Infrastructure/Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using SecureEmployee.Domain.Entities;
using SecureEmployee.Infrastructure.Data.Seed;
namespace SecureEmployee.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<User> Users => Set<User>();
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        UserSeed.Seed(modelBuilder);
    }
}