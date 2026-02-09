# General Information
Project Name: GitHub Copilot Learning

## Naming Conventions

Use descriptive, intention-revealing names.

```javascript
// Avoid
const d = new Date();
const x = users.filter(u => u.active);

// Prefer
const currentDate = new Date();
const activeUsers = users.filter(u => u.active);
```

# General Code Review Standards

## Code Quality Essentials

- Functions should be focused and appropriately sized
- Use clear, descriptive naming conventions
- Ensure proper error handling throughout

## Security Standards

- Never hardcode credentials or API keys
- Validate all user inputs
- Use parameterized queries to prevent SQL injection

## Documentation Expectations

- All public functions must include doc comments
- Complex algorithms should have explanatory comments
- README files must be kept up to date
