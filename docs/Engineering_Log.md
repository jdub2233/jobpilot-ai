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
