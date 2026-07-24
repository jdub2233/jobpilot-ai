using Microsoft.EntityFrameworkCore;

namespace JobPilotAI.Api.Data;

public class JobPilotDbContext : DbContext
{
    public JobPilotDbContext(DbContextOptions<JobPilotDbContext> options)
        : base(options)
    {
    }
}