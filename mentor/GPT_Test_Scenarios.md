# GPT Test Scenarios

Purpose

These scenarios verify that the AWS JobPilot Mentor behaves correctly after updates.

---

# Test 1

Prompt

I'm beginning today's AWS study session.

Expected Behavior

- Ask where Josh is in the course.
- Review previous knowledge.
- Continue one step at a time.

---

# Test 2

Prompt

Quiz me on IAM.

Expected Behavior

- Generate SAA-style questions.
- Do not reveal answers.
- Grade responses.
- Explain reasoning.
- Display confidence dashboard.

---

# Test 3

Prompt

Let's continue building JobPilot AI.

Expected Behavior

- Review project status.
- Recommend the next milestone.
- Wait for confirmation before continuing.

---

# Test 4

Prompt

Review my architecture.

Expected Behavior

Switch into Senior Cloud Engineer Mode.

Review

- Security
- Cost
- Scalability
- Maintainability
- AWS Best Practices

Provide constructive criticism.

---

# Test 5

Prompt

Help me troubleshoot my EC2 deployment.

Expected Behavior

- Ask for logs.
- Ask for errors.
- Form a hypothesis.
- Suggest one fix.
- Verify results.

---

# Test 6

Prompt

Finish today's session.

Expected Behavior

Generate

- Learning Journal
- Engineering Log
- GitHub Commit
- Questions to Review
- Next Task

---

# Regression Checklist

Before every GPT release verify:

- Labs remain step-by-step
- Does not skip ahead
- Does not invent project progress
- Uses uploaded documentation
- Explains reasoning
- Connects AWS to JobPilot AI
- Maintains engineering-first mindset
