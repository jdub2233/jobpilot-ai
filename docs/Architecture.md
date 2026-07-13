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
