# Engineering Log
---
### 2026-07-13

Created docs/PROJECT_ROADMAP.md and documented the project's phased delivery plan. Established roadmap status definitions, Phase 1 milestones, goals for future phases, and a progress tracking section to support incremental development and documentation.

## Sprint

Sprint 0 – Day 3

## Milestone

Define the application architecture

## Work Completed

- Created `docs/03_Architecture.md`
- Added the system overview
- Documented architectural layers
- Recorded technology decisions
- Added the request flow
- Documented the planned AWS deployment architecture
- Defined architecture principles

## Decisions Made

- Adopt a layered architecture.
- Use React + ASP.NET Core + EF Core + PostgreSQL.
- Keep AWS deployment documentation separate from current implementation.

## Files Modified

- docs/03_Architecture.md
- docs/Project_Status.md

## Next Task

Create the initial domain model and database design.

# July 15, 2026

## Sprint

Sprint 0 – Day 5

## Milestone

Create the initial domain model and database design.

## Work Completed

- Created `docs/04_Domain_Model.md`
- Documented the project scope and deferred features
- Defined five core business entities:
  - Employer
  - JobPosition
  - JobApplication
  - ApplicationStatusHistory
  - FollowUpReminder
- Documented entity relationships and cardinality
- Designed the initial PostgreSQL database schema
- Defined application status values and business rules
- Documented delete behaviors for all relationships
- Identified recommended indexes and uniqueness strategy
- Added an entity relationship diagram
- Added Entity Framework Core implementation notes
- Documented deferred architectural decisions

## Architectural Decisions

- Adopt Entity Framework Core conventions using `Id` as the primary key for all entities.
- Use `<EntityName>Id` for foreign keys.
- Preserve application history through a dedicated `ApplicationStatusHistory` entity.
- Restrict deletion of parent entities to protect historical application data.
- Defer authentication, resume storage, AI features, interview management, and multi-user support until future milestones.

## Files Modified

- `docs/04_Domain_Model.md`
- `docs/Project_Status.md` *(after milestone completion)*

## Next Task

Set up the local development environment and create the ASP.NET Core Web API solution.

This includes:

- Create the Visual Studio solution
- Create the ASP.NET Core Web API project
- Verify the solution builds successfully
- Prepare for Entity Framework Core and PostgreSQL configuration

# July 20, 2026 — Sprint 0 Day 5

## Milestone

- Create the initial ASP.NET Core Web API solution.

## Completed

- ✅ Created the `JobPilotAI.slnx` solution.
- ✅ Created the `JobPilotAI.Api` ASP.NET Core Web API project.
- ✅ Organized the solution using the `src/` folder structure.
- ✅ Added the API project to the solution.
- ✅ Verified successful builds with .NET 10.
- ✅ Investigated a transitive NuGet dependency vulnerability.
- ✅ Added an explicit reference to `Microsoft.OpenApi` version `2.7.5`.
- ✅ Verified no vulnerable NuGet packages remained.
- ✅ Configured and trusted the ASP.NET Core HTTPS development certificate.
- ✅ Verified the API over both HTTP and HTTPS.
- ✅ Removed the default ASP.NET Core template files (`WeatherForecastController`, `WeatherForecast`, and `.http` file).
- ✅ Simplified `Program.cs` to establish a clean application foundation.
- ✅ Created focused Git commits for the initial solution setup and template cleanup.

## Verification

- ✅ Solution builds successfully.
- ✅ Application starts without errors.
- ✅ HTTPS endpoint responds successfully.
- ✅ No remaining vulnerable NuGet packages detected.
- ✅ Repository contains a clean ASP.NET Core API ready for Entity Framework Core implementation.

## Repository Changes

**Commit 1**
```text
Create initial ASP.NET Core Web API solution
```

**Commit 2**
```text
Remove ASP.NET Core template sample code
```

## Next Task

- Configure Entity Framework Core.
- Install and configure PostgreSQL for local development.
- Create the initial `JobPilotDbContext`.
- Generate the first Entity Framework Core migration.

# July 24, 2026

## Sprint

Sprint 0 – Day 6

## Milestone

Configure Entity Framework Core and PostgreSQL data layer.

## Work Completed

- Installed Entity Framework Core packages.
- Installed the Npgsql PostgreSQL provider.
- Installed the Entity Framework Core CLI (`dotnet-ef`).
- Installed PostgreSQL 18 for local development.
- Configured the PostgreSQL command-line tools (`psql`).
- Created the `Data` folder.
- Implemented `JobPilotDbContext`.
- Registered Entity Framework Core with ASP.NET Core Dependency Injection.
- Configured PostgreSQL as the application's database provider.
- Configured a secure local database connection using ASP.NET Core User Secrets.
- Generated the initial Entity Framework Core migration.
- Created the `JobPilotAI` PostgreSQL database.
- Applied the initial migration successfully.
- Verified the database and migration history directly using PostgreSQL (`psql`).

## Architectural Decisions

- Use Entity Framework Core as the application's ORM.
- Use PostgreSQL for local development to align with the planned deployment to Amazon RDS for PostgreSQL.
- Store local development connection strings using ASP.NET Core User Secrets instead of source-controlled configuration files.
- Configure `JobPilotDbContext` using ASP.NET Core Dependency Injection to support maintainability and future cloud deployment.

## Verification

- ✅ Solution builds successfully.
- ✅ Entity Framework Core migration created successfully.
- ✅ PostgreSQL database created successfully.
- ✅ `__EFMigrationsHistory` table created.
- ✅ Initial migration recorded successfully.
- ✅ Direct PostgreSQL verification completed using `psql`.

## Repository Changes

**Commit**

```text
Configure Entity Framework Core and PostgreSQL data layer
```

## Next Task

Implement the first domain entity (`Employer`), add it to `JobPilotDbContext`, generate a new migration, and verify the `Employers` table is created.
