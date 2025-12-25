// SecureEmployee.API/Program.cs
using Microsoft.EntityFrameworkCore;
using SecureEmployee.Infrastructure.Data;
using SecureEmployee.Application.Interfaces;
using SecureEmployee.Infrastructure.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using SecureEmployee.Infrastructure;
using SecureEmployee.Application;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,

            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!)
            ),

            ClockSkew = TimeSpan.Zero
        };
    });


builder.Services.AddInfrastructure();
builder.Services.AddApplication();


builder.Services.AddControllers();
var app = builder.Build();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.Run();