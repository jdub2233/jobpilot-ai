namespace JobPilotAI.Api.Models;

public class JobPosition
{
    public int Id { get; set; }

    public int EmployerId { get; set; }

    public Employer Employer { get; set; } = null!;

    public string Title { get; set; } = string.Empty;

    public string? Location { get; set; }

    public string? EmploymentType { get; set; }

    public string? JobPostingUrl { get; set; }

    public decimal? SalaryMinimum { get; set; }

    public decimal? SalaryMaximum { get; set; }

    public string? Description { get; set; }

    public DateOnly? DatePosted { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public ICollection<JobApplication> JobApplications { get; set; } = [];
}
