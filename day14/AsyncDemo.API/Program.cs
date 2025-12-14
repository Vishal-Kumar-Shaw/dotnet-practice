var builder = WebApplication.CreateBuilder(args);

// 👇 THIS IS REQUIRED
builder.Services.AddControllers();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

// 👇 THIS IS REQUIRED
app.MapControllers();

app.Run();
