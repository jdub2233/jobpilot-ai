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
