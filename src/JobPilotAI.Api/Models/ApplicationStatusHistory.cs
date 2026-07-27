namespace JobPilotAI.Api.Models;

public class ApplicationStatusHistory
{
    public int Id { get; set; }

    public int JobApplicationId { get; set; }

    public JobApplication JobApplication { get; set; } = null!;

    public string Status { get; set; } = string.Empty;

    public DateTime ChangedAt { get; set; }

    public string? Notes { get; set; }
}
