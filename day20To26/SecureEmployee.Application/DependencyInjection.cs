using Microsoft.Extensions.DependencyInjection;
using SecureEmployee.Application.Interfaces;
using SecureEmployee.Application.Services;

namespace SecureEmployee.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IEmployeeService, EmployeeService>();
        services.AddScoped<IAuthService, AuthService>();

        return services;
    }
}
