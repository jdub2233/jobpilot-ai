# Learning Journal

## Date
July 13, 2026

## Sprint
Sprint 0 - Project Planning

## Objectives

• Create GitHub repository
• Learn GitHub workflow
• Create documentation structure
• Write Project Charter
• Create Project Roadmap

## Completed

✅ Created GitHub repository
✅ Learned how commits work
✅ Created docs folder
✅ Wrote Project Charter
✅ Created Project Roadmap
✅ Defined project phases
✅ Planned Sprint 0 milestones

## Lessons Learned

• Every meaningful change should end with a Git commit.
• Starting with documentation makes the project more organized.
• Project decisions should be documented before writing code.
• A roadmap helps organize work into manageable phases and milestones.
• Separating planning from implementation makes future development easier.

## Questions

- None

## Next Session

• Create Architecture v1
• Define high-level system components
• Create the first architecture diagram

## AWS Concepts Applied

None

This sprint focused on planning and project organization.


# Learning Journal

---

# July 13, 2026 — Sprint 0 Day 3

## Objectives

- Complete the initial application architecture document

## Completed

- ✅ Created `docs/03_Architecture.md`
- ✅ Documented the layered architecture
- ✅ Defined technology choices and rationale
- ✅ Documented the planned AWS deployment architecture
- ✅ Established architecture principles

## Lessons Learned

- A layered architecture separates responsibilities between the frontend, backend, data access, and database.
- Architecture should be documented before implementation.
- Planned AWS services should be clearly distinguished from implemented services.
- Markdown code blocks require closing backticks to avoid formatting issues.

## AWS Concepts

- EC2 (planned)
- RDS (planned)
- S3 (planned)
- CloudWatch (planned)
- IAM (planned)

## Questions to Review

- Why shouldn't the frontend access the database directly?
- What responsibilities belong in the API?

# July 15, 2026 — Sprint 0 Day 5

## Objectives

- Design the initial domain model and database schema for JobPilot AI.

## Completed

- ✅ Created `docs/04_Domain_Model.md`
- ✅ Defined the initial business entities
- ✅ Documented entity relationships
- ✅ Designed the initial PostgreSQL database schema
- ✅ Defined application status values and business rules
- ✅ Documented delete behaviors
- ✅ Planned the initial indexing strategy
- ✅ Added Entity Framework Core implementation guidance
- ✅ Recorded deferred design decisions

## Lessons Learned

- A well-designed domain model provides a strong foundation for implementation with Entity Framework Core.
- Business rules should be documented before they are enforced in code.
- Database design is about modeling the business domain rather than simply creating tables.
- Following Entity Framework Core conventions (using `Id` for primary keys and `<EntityName>Id` for foreign keys) simplifies implementation while keeping the model clear and maintainable.
- Planning relationships, constraints, and delete behaviors before coding helps avoid costly redesign later.

## AWS Concepts Applied

- None directly during this milestone.
- The database design will later support deployment to Amazon RDS for PostgreSQL during the AWS implementation phase.

## Questions to Review

- Why is `ApplicationStatusHistory` modeled as a separate entity instead of storing only the current status?
- Why should foreign key columns generally be indexed?
- When should a relationship use **Restrict** versus **Cascade** delete behavior?
- Why does Entity Framework Core recommend using `Id` as the primary key naming convention?

# July 20, 2026 — Sprint 0 Day 5 (Continued)

## Objectives

- Create the initial ASP.NET Core Web API solution for JobPilot AI.
- Verify the local development environment.
- Prepare the solution for Entity Framework Core implementation.

## Completed

- ✅ Created the `JobPilotAI.slnx` solution.
- ✅ Created the `JobPilotAI.Api` ASP.NET Core Web API project.
- ✅ Organized the solution using the `src/` folder structure.
- ✅ Added the API project to the solution.
- ✅ Verified successful builds with .NET 10.
- ✅ Investigated and resolved a transitive NuGet package vulnerability by upgrading `Microsoft.OpenApi` to version `2.7.5`.
- ✅ Configured and trusted the ASP.NET Core HTTPS development certificate.
- ✅ Verified the API over both HTTP and HTTPS.
- ✅ Removed the default WeatherForecast sample code and related template files.
- ✅ Created focused Git commits documenting the solution setup and template cleanup.

## Lessons Learned

- An ASP.NET Core solution (`.slnx`) provides a logical container for one or more projects.
- Transitive NuGet dependencies should be reviewed for security advisories before committing new projects.
- The `dotnet nuget why` command is useful for tracing dependency chains and identifying the source of transitive packages.
- Local HTTPS development requires a trusted ASP.NET Core development certificate.
- Small, single-purpose Git commits create a cleaner and more maintainable project history.

## AWS Concepts Applied

- None directly during this milestone.
- The ASP.NET Core Web API created during this session will later be deployed to Amazon EC2 and integrated with services such as Amazon RDS, CloudWatch, and Application Load Balancer.

## Questions to Review

- What is the difference between a .NET solution and a project?
- What is a transitive NuGet dependency?
- Why should security advisories be reviewed before accepting template-generated dependencies?
- Why does ASP.NET Core use a development HTTPS certificate?
- Why are small, focused Git commits considered a best practice?

# July 24, 2026 — Sprint 0 Day 6

## Objectives

- Configure Entity Framework Core.
- Configure PostgreSQL for local development.
- Connect the ASP.NET Core Web API to PostgreSQL.
- Create and apply the initial Entity Framework Core migration.
- Verify end-to-end database connectivity.

## Completed

- ✅ Installed Entity Framework Core packages.
- ✅ Installed the PostgreSQL Entity Framework Core provider.
- ✅ Installed the Entity Framework Core CLI tools (`dotnet-ef`).
- ✅ Installed PostgreSQL 18 for local development.
- ✅ Configured the PostgreSQL command-line tools (`psql`).
- ✅ Created the `Data` folder.
- ✅ Created `JobPilotDbContext`.
- ✅ Registered `JobPilotDbContext` with ASP.NET Core Dependency Injection.
- ✅ Configured PostgreSQL as the Entity Framework Core provider.
- ✅ Configured a secure local database connection using ASP.NET Core User Secrets.
- ✅ Generated the initial Entity Framework Core migration.
- ✅ Created the `JobPilotAI` PostgreSQL database.
- ✅ Applied the initial migration successfully.
- ✅ Verified the migration directly using PostgreSQL (`psql`).

## Lessons Learned

- `DbContext` is the primary gateway between an ASP.NET Core application and its database.
- ASP.NET Core Dependency Injection manages the lifetime and configuration of `DbContext`.
- Entity Framework Core uses providers (such as Npgsql) to communicate with specific database engines.
- ASP.NET Core User Secrets provide a secure way to store development credentials without committing them to source control.
- Entity Framework Core migrations provide version control for the database schema.
- The `__EFMigrationsHistory` table records which migrations have been applied.
- Connection issues are easier to troubleshoot by testing directly with `psql` before debugging application code.

## AWS Concepts Applied

- Local PostgreSQL mirrors the future use of Amazon RDS for PostgreSQL.
- ASP.NET Core User Secrets provide a development equivalent to AWS Secrets Manager.
- Entity Framework Core configuration remains consistent when transitioning from a local PostgreSQL instance to Amazon RDS.

## Questions to Review

- Why is `DbContext` registered using Dependency Injection?
- Why should connection strings never be committed to Git?
- What is the purpose of the `__EFMigrationsHistory` table?
- What is the difference between `dotnet ef migrations add` and `dotnet ef database update`?
- Why are ASP.NET Core User Secrets preferred over storing passwords in `appsettings.json`?
