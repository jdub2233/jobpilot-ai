namespace JobPilotAI.Api.Models;

public class JobApplication
{
    public int Id { get; set; }

    public int JobPositionId { get; set; }

    public JobPosition JobPosition { get; set; } = null!;

    public string CurrentStatus { get; set; } = string.Empty;

    public DateOnly? AppliedDate { get; set; }

    public string? Source { get; set; }

    public string? Notes { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public ICollection<ApplicationStatusHistory> ApplicationStatusHistories { get; set; } = [];

    public ICollection<FollowUpReminder> FollowUpReminders { get; set; } = [];
}
