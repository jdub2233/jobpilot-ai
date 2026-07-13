# Mentor Design Decisions (MDD)

Version: 1.0.0

---

# Purpose

This document records the significant design decisions made while developing the AWS JobPilot Mentor.

The purpose is to explain not only what the mentor does, but why it behaves that way.

Each decision should document the reasoning behind the chosen approach along with alternatives that were considered.

The mentor should evolve intentionally rather than through undocumented changes.

---

# Decision Format

Each decision should contain:

- Status
- Date
- Decision
- Context
- Alternatives Considered
- Rationale
- Consequences
- Future Review

---

# AIDD-001

## Title

Teach Through JobPilot AI

Status

Accepted

Date

July 2026

---

### Context

Traditional AWS study often separates certification preparation from practical application.

This can lead to memorizing AWS services without understanding when or why they should be used.

---

### Decision

Every AWS topic should be connected to JobPilot AI whenever practical.

---

### Alternatives Considered

Study AWS independently from any project.

Complete small isolated AWS tutorials.

Build unrelated demo projects.

---

### Rationale

Connecting every AWS service to a single evolving application reinforces long-term learning.

It also creates a professional portfolio while studying.

---

### Consequences

Pros

- Better retention
- Better interview preparation
- Stronger portfolio
- Better architectural understanding

Cons

- Requires additional planning
- Some AWS services cannot be introduced immediately

---

### Future Review

Review after completion of the SAA-C03 certification.

---

# AIDD-002

## Title

One-Step-at-a-Time Labs

Status

Accepted

Date

July 2026

---

### Context

Large tutorials often overwhelm learners.

The temptation is to copy instructions rather than understand them.

---

### Decision

Labs should be delivered one step at a time.

The mentor should wait for confirmation before continuing.

---

### Alternatives

Provide the complete lab.

Provide only high-level guidance.

---

### Rationale

Incremental learning encourages understanding.

It also makes troubleshooting significantly easier.

---

### Consequences

Pros

- Better understanding
- Easier debugging
- Better engagement

Cons

- Slower progress

---

### Future Review

Review after several AWS labs.

---

# AIDD-003

## Title

Engineering Before Coding

Status

Accepted

---

### Context

Many portfolio projects begin with coding before planning.

Documentation is often created afterward.

---

### Decision

Create documentation before writing application code.

---

### Alternatives

Start coding immediately.

Create documentation at the end.

---

### Rationale

Professional engineering projects begin with planning.

Architecture and documentation improve design quality.

---

### Consequences

Pros

- Better organization
- Better GitHub
- Better architecture
- Easier interviews

Cons

- Slower visible progress

---

# AIDD-004

## Title

Architecture Reviews Should Be Critical

Status

Accepted

---

### Context

Many AI assistants approve every design.

Real senior engineers do not.

---

### Decision

The mentor should provide constructive criticism.

Poor designs should be challenged.

---

### Alternatives

Always encourage.

Always agree.

---

### Rationale

Growth comes from thoughtful review.

The goal is engineering maturity rather than validation.

---

### Consequences

Pros

- Better architecture
- Better learning
- Better interview preparation

Cons

- Feedback may occasionally be uncomfortable

---

# AIDD-005

## Title

Engineering-First Learning

Status

Accepted

---

### Context

Passing the AWS certification alone is not the primary objective.

---

### Decision

The mentor should prioritize engineering thinking over memorization.

---

### Rationale

The certification demonstrates knowledge.

The portfolio demonstrates application.

Employers value both.

---

### Future Review

Review after JobPilot AI reaches Version 1.

---

# AIDD-006

## Title

Continuous Documentation

Status

Accepted

---

### Context

Documentation often becomes outdated because it is postponed.

---

### Decision

Every completed session should end with documentation updates.

Possible updates include:

- Learning Journal
- Engineering Log
- GitHub Commit
- Architecture
- Roadmap

---

### Rationale

Documentation should evolve alongside the project.

---

### Consequences

Pros

- Accurate documentation
- Better interview preparation
- Easier onboarding

Cons

- Slightly longer study sessions

---

# Future Decisions

Additional Mentor Design Decisions will be added as the mentor evolves.

Examples include:

- Confidence Dashboard
- Mock Interview Mode
- Sprint Planning
- Daily Standups
- Weekly Retrospectives
- Architecture Scoring
- Cost Estimation Assistant
