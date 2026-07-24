# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

# JobPilot AI — Claude Code Instructions

## Project Purpose

JobPilot AI is a personal cloud-engineering portfolio project that helps job seekers organize and improve their job search.

The project is also being used to develop practical skills in:

- AWS
- ASP.NET Core
- Entity Framework Core
- PostgreSQL
- React and TypeScript
- AI-assisted software development

The project prioritizes learning, maintainability, security, and clear documentation over development speed.

## Current Technology Direction

- React with TypeScript
- ASP.NET Core Web API with C#
- Entity Framework Core using Code First migrations
- PostgreSQL for local development
- Amazon RDS for PostgreSQL in a later AWS phase
- Git and GitHub
- GitHub Actions later
- Infrastructure as Code later

## Current Codebase State

As of Sprint 0, only the backend skeleton exists. Concretely, as of the last review:

- `src/JobPilotAI.Api` is a bare ASP.NET Core Web API (`net10.0`) with the template sample code (e.g. `WeatherForecast`) already removed.
- `Program.cs` is minimal: `AddControllers()`, `UseHttpsRedirection()`, `MapControllers()`. No controllers exist yet.
- No Entity Framework Core packages, `DbContext`, or PostgreSQL connection are configured yet.
- No React/TypeScript frontend project exists yet.
- No test project exists yet.
- `.github/workflows/` exists but is empty — no CI is configured yet.
- The only `.sln`-equivalent is `JobPilotAI.slnx` at the repo root, referencing the single API project.

Do not assume EF Core, PostgreSQL, authentication, the frontend, or CI exist just because they're described in the architecture docs or roadmap — check `docs/00_Project_Status.md` for what's actually done before proposing work that depends on it.

## Build, Run, and Test Commands

Run from the repository root unless noted otherwise.

- Restore dependencies: `dotnet restore`
- Build: `dotnet build JobPilotAI.slnx`
- Run the API: `dotnet run --project src/JobPilotAI.Api`
  - HTTP: `http://localhost:5225`
  - HTTPS: `https://localhost:7163` (see `src/JobPilotAI.Api/Properties/launchSettings.json`)
- Tests: no test project exists yet. When one is added, prefer `dotnet test` scoped to that project.

There is no frontend project yet, so there are no `npm`/frontend build commands to document until Phase 2 begins.

## Project Source of Truth

Before proposing or implementing work, review these files when they exist:

- `docs/00_Project_Status.md` — current sprint, day, milestone, and blockers
- `docs/01_Project_Charter.md` — project vision and objectives
- `docs/02_Project_Roadmap.md` — phase-by-phase plan and milestone checklist
- `docs/03_Architecture.md` — layered architecture, tech decisions, planned AWS deployment
- `docs/06_Domain_Model.md` — entities, relationships, schema, and business rules for the job-search domain

Treat the latest project documentation as authoritative.

Always distinguish between:

- Planned
- In progress
- Completed
- Deferred

Do not assume that a planned feature, service, or milestone has already been implemented.

## Working Method

For substantial tasks:

1. Inspect the relevant files.
2. Explain the current implementation.
3. Propose a small implementation plan.
4. Wait for approval before making broad or architectural changes.
5. Implement only the approved scope.
6. Summarize every file changed.
7. Run or recommend the appropriate build and tests.
8. Identify anything that still requires manual verification.

Keep changes small, focused, and easy to review.

Do not modify unrelated files.

## Code Standards

- Use current, supported .NET and React practices.
- Prefer clear, maintainable code over clever code.
- Explain significant design choices.
- Avoid unnecessary abstractions.
- Do not add a package without explaining why it is needed.
- Use dependency injection appropriately.
- Use asynchronous APIs where appropriate.
- Include useful validation, error handling, and logging.
- Add or update tests when the task justifies them.

## Entity Framework Core

- Use a Code First approach.
- Use migrations to manage schema changes.
- Explain entity relationships and constraints.
- Avoid repository abstractions that merely duplicate `DbContext`.
- Do not run destructive migrations or delete data without explicit approval.
- Do not place sensitive connection strings in committed files.

## Security

Never expose or commit:

- AWS credentials
- Passwords
- Private keys
- Session tokens
- Secrets
- Credential-bearing connection strings
- `.env` files containing sensitive values

Apply least privilege when AWS access is introduced.

Do not hardcode credentials.

## AWS Cost and Resource Safety

- Prefer Free Tier or low-cost resources.
- Warn before suggesting commands that may create charges.
- Do not create, modify, or delete AWS resources without explicit approval.
- Include cleanup steps for temporary AWS resources.

## Git Rules

- Do not commit automatically.
- Do not push automatically.
- Do not rewrite Git history.
- Do not merge branches automatically.
- Josh will review changes and perform final commits.
- Suggest a focused commit message after verified work.

## Human Responsibility

Claude Code is an implementation assistant.

Josh remains responsible for:

- Architecture
- Understanding all generated code
- Reviewing diffs
- Testing
- Security
- Documentation
- Final approval

Do not present generated code as complete until it has been reviewed and verified.
