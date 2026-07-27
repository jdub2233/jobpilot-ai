namespace JobPilotAI.Api.Models;

public class FollowUpReminder
{
    public int Id { get; set; }

    public int JobApplicationId { get; set; }

    public JobApplication JobApplication { get; set; } = null!;

    public DateTime DueAt { get; set; }

    public string ReminderType { get; set; } = string.Empty;

    public string? Notes { get; set; }

    public bool IsCompleted { get; set; }

    public DateTime? CompletedAt { get; set; }

    public DateTime CreatedAt { get; set; }
}
