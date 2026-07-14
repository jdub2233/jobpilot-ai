# AI-Assisted Development

## Document Status

- **Status:** Active
- **Project:** JobPilot AI
- **Owner:** Josh Williams
- **Initial Version:** 1.0
- **Last Updated:** 2026-07-13

## Purpose

JobPilot AI uses an AI-assisted software-development workflow to improve productivity while preserving human ownership of architecture, code quality, security, testing, and delivery.

Claude Code will assist with implementation-oriented work inside the repository.

AWS JobPilot Mentor will assist with project planning, AWS education, architecture, documentation, and learning assessment.

AI tools are used as engineering assistants, not autonomous decision-makers.

## Objectives

The AI-assisted workflow is intended to help develop practical skills in:

- Codebase exploration
- Technical planning
- Prompting and task decomposition
- AI-assisted implementation
- Code review
- Automated testing
- Troubleshooting
- Refactoring
- Security review
- Documentation
- Human verification of generated work

## Tool Responsibilities

### AWS JobPilot Mentor

AWS JobPilot Mentor is responsible for:

- Reviewing Project Status and the Project Roadmap
- Identifying the next milestone
- Teaching AWS concepts
- Explaining architecture and tradeoffs
- Defining acceptance criteria
- Creating hands-on learning plans
- Reviewing completed milestones
- Helping update project documentation
- Generating certification practice questions

AWS JobPilot Mentor should not assume that planned work has been completed.

### Claude Code

Claude Code is responsible for assisting with:

- Repository exploration
- File and dependency analysis
- Implementation planning
- Small, approved code changes
- Test generation and execution
- Debugging
- Refactoring
- Build verification
- Code explanation
- Review of implementation risks

Claude Code should follow the repository-level instructions in `CLAUDE.md`.

### Developer

The developer remains responsible for:

- Selecting and approving the task
- Making architectural decisions
- Reviewing implementation plans
- Understanding generated code
- Inspecting Git diffs
- Running and evaluating tests
- Protecting credentials and sensitive information
- Rejecting incorrect or unnecessary changes
- Updating documentation
- Performing Git commits and pushes

## Standard AI-Assisted Development Workflow

### 1. Determine the Milestone

Begin with the AWS JobPilot Mentor.

Review:

- Project Status
- Project Roadmap
- Architecture
- Current sprint and day

Define:

- The task
- Why it is needed
- Acceptance criteria
- Files or components likely affected
- Security and cost considerations

### 2. Ask Claude Code to Inspect

Before allowing changes, ask Claude Code to inspect the relevant repository area.

Example prompt:

```text
Review the project documentation and relevant source files.

Explain:

1. The current implementation
2. The files likely affected
3. A proposed implementation plan
4. Risks, assumptions, or questions

Do not modify files yet.
