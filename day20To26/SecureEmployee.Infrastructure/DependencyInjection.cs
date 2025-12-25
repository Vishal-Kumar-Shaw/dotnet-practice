using Microsoft.Extensions.DependencyInjection;
using SecureEmployee.Application.Interfaces;
using SecureEmployee.Infrastructure.Repositories;
using SecureEmployee.Infrastructure.Security;

namespace SecureEmployee.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<IPasswordHasher, BCryptPasswordHasher>();
        services.AddScoped<IJwtTokenService, JwtTokenService>();

        return services;
    }
}
