using JobPilotAI.Api.Dtos.Employer;
using JobPilotAI.Api.Models;
using JobPilotAI.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace JobPilotAI.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployersController : ControllerBase
{
    private readonly IEmployerRepository _employerRepository;

    public EmployersController(IEmployerRepository employerRepository)
    {
        _employerRepository = employerRepository;
    }

    [HttpPost]
    [ProducesResponseType<EmployerDto>(StatusCodes.Status201Created)]
    public async Task<ActionResult<EmployerDto>> CreateEmployer(
        EmployerCreateDto createDto)
    {
        var now = DateTime.UtcNow;

        var employer = new Employer
        {
            Name = createDto.Name,
            WebsiteUrl = createDto.WebsiteUrl,
            Industry = createDto.Industry,
            Notes = createDto.Notes,
            CreatedAt = now,
            UpdatedAt = now
        };

        var createdEmployer =
            await _employerRepository.CreateAsync(employer);

        var employerDto = new EmployerDto
        {
            Id = createdEmployer.Id,
            Name = createdEmployer.Name,
            WebsiteUrl = createdEmployer.WebsiteUrl,
            Industry = createdEmployer.Industry,
            Notes = createdEmployer.Notes
        };

        return Created(
            $"/api/employers/{createdEmployer.Id}",
            employerDto);
    }
}