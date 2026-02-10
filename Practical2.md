1. we can assign the issues to Copilot in the background!
   1. Issues in GitHub
   2. Assign to Copilot
   3. Human is always should be in the loop
   4. look at the PR and ask for an update
   5. Approve PR

2. GitHub Extension

3. Custom-Agent
   - A specialized Copilot agent we define with a specific role, scope, tools, and rules, instead of using the generic “Copilot Chat”.
   1. Create in the workspace
   2. Copy explain the example
   3. Shwo the definition of done
   4. prompt: 'Fetch issue #2 using #issues_get_detail , then implement it locally'

4. Copilot Chat
   1. Prompts:
      - Tools <MCP Server>
      1. 'show me all issues from GitHub'
      2. '#issues_get_detail number 2'
      3. 'assing the issue to me. #issues_assigned_to_me'
      4. 'Start to implement the issue'

5. Repository-level configuration
   1. .github/copilot-config.yml
      1. Copilot changes its suggestion behavior
      2. Applies rules only to this repository
      3. Overrides global Copilot defaults (but not org-wide enforced policies)
   
   2. .github/copilot-exclusions.yml
      1. Do NOT generate suggestions for these files, folders, or patterns.

6. Quize NEW Quetsiosns *


```custom-agent
---
name: Issue Implementer
description: Describe what this custom agent does and when to use it.
argument-hint: The inputs this agent expects, e.g., "a task to implement" or "a question to answer".
# tools: ['vscode', 'execute', 'read', 'agent', 'edit', 'search', 'web', 'todo'] # specify the tools this agent can use. If not set, all enabled tools are allowed.
---

You are a pragmatic senior engineer working in my local workspace in VS Code.

Workflow (do these steps in order):
1) Ask me for the issue text if it’s not in the workspace.
2) Create a short implementation plan with a checklist.
3) Locate relevant files by searching the codebase.
4) Implement the smallest possible change that satisfies the acceptance criteria.
5) Add/adjust tests if existing.
6) Run tests/build locally (use terminal) and fix failures.
7) Summarize what changed and which commands you ran.

Rules:
- Prefer small, safe commits and minimal diffs.
- Follow existing code conventions in the repository.
- Don’t introduce new libraries unless absolutely necessary.
- Update README.md in the root of the repository and add a section about the new feature if it’s not already there.

Definition of Done (must confirm at the end):
- [ ] /README.md updated OR explicit reason given
- [ ] Files changed listed
```


```yml
version: 1

rules:
  - language: csharp
    preferences:
      use_async_await: true
      avoid_blocking_calls: true
      dependency_injection: preferred

  - path: "src/Legacy/**"
    preferences:
      modern_patterns: discouraged

```

What does mean? 
In C# files:
- Copilot will favor async/await
- Avoid .Result, .Wait()
- Prefer constructor injection
- In src/Legacy/**:
- Copilot won’t refactor to modern patterns

```yml
version: 1

exclusions:
  - path: "**/*.min.js"
  - path: "**/bin/**"
  - path: "**/obj/**"
  - path: "**/node_modules/**"
  - path: "**/*.generated.cs"

#   More enterprise
  - path: "src/Secrets/**"
  - path: "**/*.pem"
  - path: "**/*.key"
  - path: "**/*.pfx"
  - path: "**/Terraform/**"
```