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

## Initial Database Schema

### Employers

| Column | Type | Required | Notes |
|---|---|---:|---|
| Id | integer | Yes | Primary key |
| Name | varchar(200) | Yes | Employer name |
| WebsiteUrl | varchar(500) | No | Company website |
| Industry | varchar(150) | No | Employer industry |
| Notes | text | No | General notes |
| CreatedAt | timestamp with time zone | Yes | Record creation time |
| UpdatedAt | timestamp with time zone | Yes | Last update time |

Constraints:

- `Id` is the primary key.
- `Name` cannot be empty.

---

### JobPositions

| Column | Type | Required | Notes |
|---|---|---:|---|
| Id | integer | Yes | Primary key |
| EmployerId | integer | Yes | Foreign key to Employers |
| Title | varchar(200) | Yes | Position title |
| Location | varchar(200) | No | Job location |
| EmploymentType | varchar(50) | No | Full-time, contract, or another type |
| JobPostingUrl | varchar(1000) | No | Link to the job posting |
| SalaryMinimum | numeric(12,2) | No | Minimum advertised salary |
| SalaryMaximum | numeric(12,2) | No | Maximum advertised salary |
| Description | text | No | Job description |
| DatePosted | date | No | Date the position was posted |
| CreatedAt | timestamp with time zone | Yes | Record creation time |
| UpdatedAt | timestamp with time zone | Yes | Last update time |

Constraints:

- `Id` is the primary key.
- `EmployerId` references `Employers.Id`.
- `Title` cannot be empty.
- `SalaryMinimum` cannot be negative.
- `SalaryMaximum` cannot be negative.
- When both salary values are provided, `SalaryMaximum` must be greater than or equal to `SalaryMinimum`.

---

### JobApplications

| Column | Type | Required | Notes |
|---|---|---:|---|
| Id | integer | Yes | Primary key |
| JobPositionId | integer | Yes | Foreign key to JobPositions |
| CurrentStatus | varchar(50) | Yes | Current application status |
| AppliedDate | date | No | Date the application was submitted |
| Source | varchar(100) | No | LinkedIn, company site, referral, or another source |
| Notes | text | No | Application notes |
| CreatedAt | timestamp with time zone | Yes | Record creation time |
| UpdatedAt | timestamp with time zone | Yes | Last update time |

Constraints:

- `Id` is the primary key.
- `JobPositionId` references `JobPositions.Id`.
- `CurrentStatus` cannot be empty.

---

### ApplicationStatusHistory

| Column | Type | Required | Notes |
|---|---|---:|---|
| Id | integer | Yes | Primary key |
| JobApplicationId | integer | Yes | Foreign key to JobApplications |
| Status | varchar(50) | Yes | Application status at this point in time |
| ChangedAt | timestamp with time zone | Yes | Time the status became effective |
| Notes | text | No | Optional explanation |

Constraints:

- `Id` is the primary key.
- `JobApplicationId` references `JobApplications.Id`.
- `Status` cannot be empty.

---

### FollowUpReminders

| Column | Type | Required | Notes |
|---|---|---:|---|
| Id | integer | Yes | Primary key |
| JobApplicationId | integer | Yes | Foreign key to JobApplications |
| DueAt | timestamp with time zone | Yes | Reminder due time |
| ReminderType | varchar(100) | Yes | Email, call, application check, or another type |
| Notes | text | No | Reminder details |
| IsCompleted | boolean | Yes | Indicates whether the reminder is complete |
| CompletedAt | timestamp with time zone | No | Time the reminder was completed |
| CreatedAt | timestamp with time zone | Yes | Record creation time |

Constraints:

- `Id` is the primary key.
- `JobApplicationId` references `JobApplications.Id`.
- `ReminderType` cannot be empty.
- `CompletedAt` should be null when `IsCompleted` is false.

## Status Values and Business Rules

### Application Status

Initial supported values:

- Interested
- Applied
- Screening
- Interviewing
- Offer
- Accepted
- Rejected
- Withdrawn
- Closed

Business rules:

- A new application must have a current status.
- Changing `JobApplication.CurrentStatus` should also create an `ApplicationStatusHistory` record.
- Status history records should not be edited after creation except to correct documented data-entry mistakes.
- `AppliedDate` may be null while the application status is `Interested`.
- `AppliedDate` should be populated when the application reaches `Applied` or a later stage.

### Employment Type

Initial supported values:

- FullTime
- PartTime
- Contract
- Temporary
- Internship
- Other

### Reminder Type

Initial supported values:

- FollowUp
- Interview
- RecruiterContact
- ApplicationCheck
- ThankYou
- Other

### Follow-Up Reminder Rules

- A reminder must belong to a job application.
- `DueAt` is required.
- New reminders default to `IsCompleted = false`.
- `CompletedAt` should be null while `IsCompleted` is false.
- When a reminder is completed, `CompletedAt` should record the completion time.
- Reopening a reminder should clear `CompletedAt`.

### Timestamp Rules

- Application timestamps will be stored in UTC.
- `CreatedAt` is assigned when a record is created.
- `UpdatedAt` is updated whenever a mutable record changes.
- User-facing dates and times may later be converted to the user's local time.

### Salary Rules

- Salary values use decimal precision.
- Salary values cannot be negative.
- `SalaryMaximum` cannot be less than `SalaryMinimum`.
- The initial model assumes annual salary values.
- Hourly compensation and currency support are deferred.

## Deletion Behavior

### Employer

An Employer cannot be deleted while related JobPositions exist.

Recommended behavior:

- Restrict deletion
- Preserve employer and position history
- Allow archival to be considered later

### JobPosition

A JobPosition cannot be deleted while related JobApplications exist.

Recommended behavior:

- Restrict deletion
- Preserve application history
- Correct or archive inaccurate positions instead of deleting them

### JobApplication

Deleting a JobApplication may also delete its dependent records:

- ApplicationStatusHistory
- FollowUpReminders

Recommended behavior:

- Cascade deletion for dependent status history and reminders
- Require explicit confirmation at the application layer
- Consider soft deletion before portfolio-quality deployment

### ApplicationStatusHistory

Status history records should normally not be deleted individually.

Exceptions may include:

- Correcting accidental duplicate records
- Removing invalid test data during development

### FollowUpReminder

A FollowUpReminder may be deleted independently because it is an operational task rather than permanent application history.

## Initial Delete Rules

| Parent Entity | Dependent Entity | Delete Behavior |
|---|---|---|
| Employer | JobPosition | Restrict |
| JobPosition | JobApplication | Restrict |
| JobApplication | ApplicationStatusHistory | Cascade |
| JobApplication | FollowUpReminder | Cascade |

Relationship:
JobApplication (1) -----> (*) FollowUpReminder

## Indexes and Uniqueness

### Employers

Recommended indexes:

- Index on `Name`

Initial uniqueness decision:

- Employer names are not required to be unique.
- Different companies may share similar names.
- Duplicate prevention will initially be handled through application validation and user review.

### JobPositions

Recommended indexes:

- Index on `EmployerId`
- Index on `Title`
- Composite index on `EmployerId` and `Title`

Initial uniqueness decision:

- Job position titles are not unique.
- The same employer may post the same title multiple times.
- Job posting URL uniqueness is deferred because URLs may change or be reused.

### JobApplications

Recommended indexes:

- Index on `JobPositionId`
- Index on `CurrentStatus`
- Index on `AppliedDate`
- Composite index on `CurrentStatus` and `AppliedDate`

### ApplicationStatusHistory

Recommended indexes:

- Index on `JobApplicationId`
- Composite index on `JobApplicationId` and `ChangedAt`

This supports retrieving an application's status timeline in chronological order.

### FollowUpReminders

Recommended indexes:

- Index on `JobApplicationId`
- Index on `DueAt`
- Composite index on `IsCompleted` and `DueAt`

This supports queries such as:

- Find all incomplete reminders
- Find reminders due soon
- Find reminders for a specific application

## Indexing Principles

- Foreign key columns should usually be indexed.
- Indexes should support real query patterns.
- Too many indexes increase storage usage and slow inserts and updates.
- Additional indexes should be added only after query behavior is understood.

## Domain Relationship Diagram

```text
Employer
  1
  |
  | has many
  |
  *
JobPosition
  1
  |
  | has many
  |
  *
JobApplication
  1
  |-------------------------|
  | has many                | has many
  |                         |
  *                         *
ApplicationStatusHistory    FollowUpReminder
```
