# JobPilot AI Initial Domain Model

## Purpose

This document defines the initial business entities, relationships, and database design for JobPilot AI.

The initial model supports tracking employers, job positions, applications, application status history, and follow-up reminders.

This is a learning implementation intended for the first local version of the application. It may evolve as requirements become clearer.

## Scope

### Included

- Employers
- Job positions
- Job applications
- Application status history
- Follow-up reminders

### Deferred

- User authentication and authorization
- Resume uploads
- Job-description file storage
- AI-assisted resume matching
- Interview preparation
- Analytics
- Notifications
- AWS infrastructure


## Core Entities

### Employer

Represents a company or organization offering job opportunities.

Suggested attributes:

- Id
- Name
- WebsiteUrl
- Industry
- Notes
- CreatedAt
- UpdatedAt

### JobPosition

Represents a specific job opening at an employer.

Suggested attributes:

- Id
- EmployerId
- Title
- Location
- EmploymentType
- JobPostingUrl
- SalaryMinimum
- SalaryMaximum
- Description
- DatePosted
- CreatedAt
- UpdatedAt

### JobApplication

Represents an application submitted for a specific job position.

Suggested attributes:

- Id
- JobPositionId
- CurrentStatus
- AppliedDate
- Source
- Notes
- CreatedAt
- UpdatedAt

### ApplicationStatusHistory

Represents a recorded change in an application's status.

Suggested attributes:

- Id
- JobApplicationId
- Status
- ChangedAt
- Notes

### FollowUpReminder

Represents a reminder related to a job application.

Suggested attributes:

- Id
- JobApplicationId
- DueAt
- ReminderType
- Notes
- IsCompleted
- CompletedAt
- CreatedAt

## Entity Relationships

### Employer → JobPosition

- One Employer can have many JobPositions.
- Each JobPosition belongs to one Employer.

Relationship:
Employer (1) -----> (*) JobPosition

---

### JobPosition → JobApplication

- One JobPosition can have many JobApplications.
- Each JobApplication belongs to one JobPosition.

Relationship:
JobPosition (1) -----> (*) JobApplication

---

### JobApplication → ApplicationStatusHistory

- One JobApplication can have many status history records.
- Each status history record belongs to one JobApplication.

Relationship:
JobApplication (1) -----> (*) ApplicationStatusHistory

---

### JobApplication → FollowUpReminder

- One JobApplication can have many FollowUpReminders.
- Each reminder belongs to one JobApplication.

Relationship:
JobApplication (1) -----> (*) FollowUpReminder
