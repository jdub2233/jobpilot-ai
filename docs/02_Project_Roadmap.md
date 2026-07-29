# JobPilot AI Project Roadmap

## Purpose

This roadmap describes the planned evolution of JobPilot AI from an initial local application into a deployed AWS cloud portfolio project.

The roadmap supports two goals:

1. Build a useful job-search and career-management application.
2. Apply AWS concepts while preparing for the AWS Certified Solutions Architect – Associate certification.

## Roadmap Status Definitions

- **Planned** — Approved for future work but not started.
- **In Progress** — Actively being designed or implemented.
- **Completed** — Implemented, verified, and documented.
- **Deferred** — Intentionally postponed until a later stage.

## Current Project Status

**Sprint:** Sprint 1  
**Phase:** Core Application Development  
**Overall Status:** In Progress

## Project Phases

### Phase 1 – Foundation & Planning
**Status:** Completed

Establish the project foundation, documentation, architecture, development environment, and Git repository.

### Milestones

- [x] Define the project vision and objectives
- [x] Create the Project Charter
- [x] Create the initial Project Roadmap
- [x] Establish the GitHub repository structure
- [x] Create the engineering documentation structure
- [x] Create the AI Mentor documentation
- [x] Define the application architecture
- [x] Create the initial domain model and database design
- [x] Set up the local development environment
- [x] Install and configure Claude Code
- [x] Create the project CLAUDE.md guidance file
- [x] Validate the AI-assisted development workflow
- [x] Create the ASP.NET Core Web API solution
- [x] Configure Entity Framework Core
- [x] Configure PostgreSQL for local development
- [x] Connect the API to PostgreSQL
- [x] Create the initial database migration
- [x] Verify the complete local development environment
- [x] Implement core Entity Framework domain entities
- [x] Create database schema from domain model
- [x] Verify database schema using PostgreSQL
- [x] Document Sprint 0 deliverables

---

### Phase 2 – Core Application Development
**Status:** In-Progress

Develop the initial JobPilot AI application with a React frontend, ASP.NET Core Web API backend, Entity Framework Core, and PostgreSQL database.

### Goals


- [ ] Develop ASP.NET Core REST API
- [ ] Implement CRUD endpoints
- [ ] Implement business logic
- [ ] Build the React frontend
- [ ] Connect React to the API
- [ ] Authentication
- [ ] Application features
- [ ] Prepare for AWS deployment

---

### Phase 3 – AWS Cloud Deployment
**Status:** Planned

Deploy the application to AWS using cloud infrastructure while applying AWS architectural best practices.

### Goals

- Provision AWS infrastructure
- Deploy the ASP.NET Core API
- Deploy the PostgreSQL database
- Configure networking and security
- Implement monitoring and logging
- Validate a complete cloud deployment

---

### Phase 4 – Cloud Enhancements
**Status:** Planned

Expand the application using additional AWS services for storage, monitoring, messaging, security, and scalability.

### Goals

- Add scalable file storage
- Introduce asynchronous processing
- Improve application security
- Implement Infrastructure as Code
- Add CI/CD automation
- Enhance observability
- Optimize cost and performance

---

### Phase 5 – Portfolio Polish
**Status:** Planned

Improve documentation, testing, automation, cost optimization, and presentation to create a portfolio-quality project suitable for technical interviews.

### Goals

- Improve project documentation
- Add architecture diagrams
- Perform application testing
- Refine deployment procedures
- Produce portfolio screenshots and demos
- Prepare interview-ready documentation

## Current Focus

**Current Sprint:** Sprint 1

**Current Day:** Day 8

Current Milestone:
Employer API Vertical Slice

Current Objective:
Implement the first complete REST API vertical slice for the Employer entity, including DTOs, repository, controller, CRUD endpoints, and Swagger testing.

## Next Milestone

Complete the Employer API vertical slice:

- Employer DTOs
- Repository
- Dependency Injection
- CRUD endpoints
- Swagger verification
- Engineering documentation

---

## Phase Progress

| Phase | Status |
|-------|--------|
|------|--------|
| Phase 1 - Foundation & Planning | 🟢 Complete |
| Phase 2 - Core Application Development | 🟡 In Progress |
| Phase 3 - AWS Cloud Deployment | ⚪ Planned |
| Phase 4 - Cloud Enhancements | ⚪ Planned |
| Phase 5 - Portfolio Polish | ⚪ Planned |

---

## Next Milestone

Define the initial application architecture and document the high-level system design.
