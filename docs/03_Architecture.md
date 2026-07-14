# JobPilot AI Application Architecture

## Document Status

- **Status:** In Progress
- **Sprint:** Sprint 0
- **Milestone:** Define the application architecture
- **Last Updated:** 2026-07-13

## System Overview

JobPilot AI is a web application designed to help users manage their job-search activities.

The initial application will use a layered architecture consisting of:

- A React and TypeScript frontend
- An ASP.NET Core Web API backend
- Entity Framework Core for data access
- PostgreSQL for relational data storage

The frontend will communicate with the backend through REST API requests. The backend will contain the application logic and use Entity Framework Core to read and write data in PostgreSQL.

The application will initially run in a local development environment. AWS deployment is planned for a later project phase and has not yet been implemented.

## Architectural Layers

### Presentation Layer

The presentation layer will be built with React and TypeScript.

Its responsibilities will include:

- Displaying the user interface
- Collecting user input
- Sending HTTP requests to the backend API
- Displaying application data and validation messages

The frontend will not access the database directly.

### Application Layer

The application layer will be implemented as an ASP.NET Core Web API.

Its responsibilities will include:

- Exposing REST API endpoints
- Validating incoming requests
- Coordinating application workflows
- Enforcing business rules
- Returning appropriate HTTP responses

### Data Access Layer

Entity Framework Core will provide the data access layer.

Its responsibilities will include:

- Mapping C# entities to relational database tables
- Querying and updating application data
- Managing database migrations
- Providing an abstraction over PostgreSQL access

### Database Layer

PostgreSQL will store the application’s relational data.

Planned data includes:

- Job applications
- Employers
- Positions
- Application status history
- Follow-up reminders
- File metadata

The initial database will run locally. Amazon RDS for PostgreSQL is planned for a later AWS deployment phase.

## Technology Decisions

| Component | Technology | Rationale |
|-----------|------------|-----------|
| Frontend | React with TypeScript | Modern, component-based UI with strong type safety and a large ecosystem. |
| Backend | ASP.NET Core Web API | Aligns with existing C# expertise and provides a robust framework for building RESTful services. |
| ORM | Entity Framework Core | Simplifies database access, supports code-first development, and integrates well with ASP.NET Core. |
| Database | PostgreSQL | Open-source relational database with strong performance and compatibility with Amazon RDS. |
| Cloud Platform | Amazon Web Services (AWS) | Supports the project's learning goals while providing scalable cloud infrastructure for future deployment. |

## High-Level System Flow

The initial application request flow will be:

1. A user interacts with the React frontend.
2. The frontend sends an HTTP request to the ASP.NET Core Web API.
3. The API validates the request and applies business rules.
4. The API uses Entity Framework Core to query or update PostgreSQL.
5. PostgreSQL returns the requested data or confirms the update.
6. The API returns an HTTP response to the frontend.
7. The frontend updates the user interface.

```text
User
  |
  v
React + TypeScript Frontend
  |
  | HTTPS / REST
  v
ASP.NET Core Web API
  |
  | Entity Framework Core
  v
PostgreSQL
```

---

## Development Workflow

JobPilot AI follows an AI-assisted engineering workflow that combines architectural planning, AI-assisted implementation, and human engineering judgment.

Each development task follows a structured process to ensure that implementation aligns with the project roadmap, architectural decisions, and AWS learning objectives.

The development workflow is:

```text
Project Documentation
(Project Status, Roadmap, Architecture)
                │
                ▼
AWS JobPilot Mentor
(Project Planning & Architecture)
                │
                ▼
Claude Code
(Code Exploration & Implementation)
                │
                ▼
Developer Review
(Code Review & Understanding)
                │
                ▼
Build & Testing
                │
                ▼
Documentation Updates
                │
                ▼
GitHub Commit
```

### Workflow Responsibilities

#### AWS JobPilot Mentor

Provides engineering guidance by:

- Reviewing project documentation
- Planning sprint milestones
- Teaching AWS concepts
- Explaining architectural decisions
- Generating hands-on learning tasks
- Producing documentation updates
- Preparing certification quizzes

#### Claude Code

Assists with software implementation by:

- Exploring the repository
- Proposing implementation plans
- Generating and explaining code
- Assisting with refactoring
- Troubleshooting issues
- Suggesting and updating tests
- Reviewing implementation details

#### Developer

The developer remains responsible for:

- Architectural decisions
- Understanding all generated code
- Reviewing every AI-generated change
- Running builds and tests
- Verifying functionality
- Approving Git commits
- Maintaining project documentation

This workflow ensures that AI accelerates development while engineering judgment, testing, and documentation remain the responsibility of the developer.

## Planned AWS Deployment Architecture

AWS deployment is planned for a later project phase. No AWS application infrastructure has been implemented yet.

The initial learning deployment is expected to use:

- Amazon EC2 to host the ASP.NET Core Web API
- Amazon RDS for PostgreSQL to host the relational database
- Amazon S3 to store uploaded resumes and job-description files
- Amazon CloudWatch for application logs, metrics, and alarms
- AWS Identity and Access Management (IAM) for permissions and service access
- AWS Systems Manager Parameter Store or AWS Secrets Manager for sensitive configuration

Future portfolio-quality improvements may include:

- An Application Load Balancer
- Auto Scaling
- Amazon Cognito for authentication
- Amazon CloudFront for content delivery
- Amazon Route 53 for DNS
- Amazon SQS and AWS Lambda for background processing
- Infrastructure as Code
- Automated deployment through GitHub Actions

These services will be introduced only when they solve a documented application, security, availability, or operational requirement.

## Architecture Principles

The architecture of JobPilot AI will follow these principles throughout the project:

- **Separation of Concerns** — Keep the frontend, backend, data access, and database responsibilities independent.
- **Security First** — Apply least privilege, protect sensitive data, and avoid exposing internal services directly.
- **Maintainability** — Favor clear, well-documented, and modular code over unnecessary complexity.
- **Scalability** — Design components so they can be expanded as application usage grows.
- **Cost Awareness** — Prefer low-cost and AWS Free Tier services while learning.
- **Observability** — Add logging, monitoring, and metrics as cloud services are introduced.
- **Infrastructure as Code** — Manage cloud infrastructure through version-controlled definitions when the project reaches that stage.

## Document Status

**Status:** Completed

This document describes the planned high-level architecture for JobPilot AI during Sprint 0. It will evolve as the application is implemented, AI-assisted development practices mature, and new AWS services are introduced.
