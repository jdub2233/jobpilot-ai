using JobPilotAI.Api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString =
    builder.Configuration.GetConnectionString("JobPilotDatabase")
    ?? throw new InvalidOperationException(
        "Connection string 'JobPilotDatabase' was not found.");

builder.Services.AddDbContext<JobPilotDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
