using JobPilotAI.Api.Data;
using JobPilotAI.Api.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString =
    builder.Configuration.GetConnectionString("JobPilotDatabase")
    ?? throw new InvalidOperationException(
        "Connection string 'JobPilotDatabase' was not found.");

builder.Services.AddDbContext<JobPilotDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddScoped<IEmployerRepository, EmployerRepository>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
