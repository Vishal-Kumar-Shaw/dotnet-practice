using SecureEmployee.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace SecureEmployee.Infrastructure.Data.Seed;

public static class UserSeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var adminId = Guid.Parse("11111111-1111-1111-1111-111111111111");
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = adminId,
                Email = "globaladmin@se.com",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("Admin@123"),
                Role = "GlobalAdmin",
                IsActive = "Yes"
            }
        );
    }
}
