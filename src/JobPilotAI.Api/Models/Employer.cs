namespace JobPilotAI.Api.Models;

public class Employer
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? WebsiteUrl { get; set; }

    public string? Industry { get; set; }

    public string? Notes { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public ICollection<JobPosition> JobPositions { get; set; } = [];
}