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
