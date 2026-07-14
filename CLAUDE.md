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

## Project Source of Truth

Before proposing or implementing work, review these files when they exist:

- `docs/00_Project_Status.md`
- `docs/01_Project_Charter.md`
- `docs/02_Project_Roadmap.md`
- `docs/03_Architecture.md`

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
