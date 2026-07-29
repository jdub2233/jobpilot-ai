namespace JobPilotAI.Api.Dtos.Employer
{
    public class EmployerDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? WebsiteUrl { get; set; }

        public string? Industry { get; set; }

        public string? Notes { get; set; }
    }
}
