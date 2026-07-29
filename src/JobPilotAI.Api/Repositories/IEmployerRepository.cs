using JobPilotAI.Api.Models;

namespace JobPilotAI.Api.Repositories;

public interface IEmployerRepository
{
    Task<IReadOnlyList<Employer>> GetAllAsync();

    Task<Employer?> GetByIdAsync(int id);

    Task<Employer> CreateAsync(Employer employer);

    Task<bool> UpdateAsync(Employer employer);

    Task<bool> DeleteAsync(int id);
}