using JobPilotAI.Api.Data;
using JobPilotAI.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPilotAI.Api.Repositories;

public class EmployerRepository : IEmployerRepository
{
    private readonly JobPilotDbContext _dbContext;

    public EmployerRepository(JobPilotDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IReadOnlyList<Employer>> GetAllAsync()
    {
        return await _dbContext.Employers
            .AsNoTracking()
            .OrderBy(e => e.Name)
            .ToListAsync();
    }

    public async Task<Employer?> GetByIdAsync(int id)
    {
        return await _dbContext.Employers
            .AsNoTracking()
            .FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task<Employer> CreateAsync(Employer employer)
    {
        _dbContext.Employers.Add(employer);
        await _dbContext.SaveChangesAsync();

        return employer;
    }

    public async Task<bool> UpdateAsync(Employer employer)
    {
        var existingEmployer = await _dbContext.Employers
            .FirstOrDefaultAsync(e => e.Id == employer.Id);

        if (existingEmployer is null)
        {
            return false;
        }

        existingEmployer.Name = employer.Name;
        existingEmployer.WebsiteUrl = employer.WebsiteUrl;
        existingEmployer.Industry = employer.Industry;
        existingEmployer.Notes = employer.Notes;
        existingEmployer.UpdatedAt = employer.UpdatedAt;

        await _dbContext.SaveChangesAsync();

        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var employer = await _dbContext.Employers
            .FirstOrDefaultAsync(e => e.Id == id);

        if (employer is null)
        {
            return false;
        }

        _dbContext.Employers.Remove(employer);
        await _dbContext.SaveChangesAsync();

        return true;
    }
}