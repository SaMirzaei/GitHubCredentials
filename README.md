# GitHub Copilot Certification Quiz (GH-300)

An interactive quiz application for studying and preparing for the GitHub Copilot Certification (GH-300) exam. This repository contains practice questions and a web-based quiz interface to help developers learn and test their knowledge of GitHub Copilot features, best practices, and responsible AI usage.

## 📋 About

This project is designed to help developers prepare for the GitHub Copilot Certification exam. It includes:
- Comprehensive quiz questions covering all certification topics
- Interactive HTML-based quiz interface
- Practical notes and learning materials
- Session handouts and resources

## ✨ Features

- **50+ Practice Questions**: Covering topics such as:
  - Responsible AI with GitHub Copilot
  - GitHub Copilot features and capabilities
  - Code suggestions and completions
  - Best practices and governance
  - Security and compliance considerations
  
- **Interactive Quiz Interface**: A user-friendly web application with:
  - Real-time score tracking
  - Detailed explanations for each answer
  - Topic categorization
  - Progress tracking

- **Learning Resources**: Including practical notes and session materials

## 📁 Repository Structure

```
.
├── README.md                           # This file
├── Practical.md                        # Practical notes on GitHub Copilot usage
├── src/                                # Source files
│   ├── questions.json                  # Quiz questions for GH-300 certification
│   ├── questions2.json                 # Additional quiz questions
│   └── quiz.html                       # Interactive quiz web interface
├── session2/                           # Session materials
│   └── copilot_session2_handout.pdf    # Training handout
└── .vscode/                            # VS Code configuration
```

## 🚀 Getting Started

### Prerequisites

- A modern web browser (Chrome, Firefox, Safari, or Edge)
- (Optional) A code editor like VS Code for viewing/modifying questions

### Running the Quiz

1. **Clone the repository**:
   ```bash
   git clone https://github.com/SaMirzaei/GitHubCredentials.git
   cd GitHubCredentials
   ```

2. **Open the quiz**:
   - Navigate to the `src` folder
   - Open `quiz.html` in your web browser
   - Start taking the quiz!

   ```bash
   # On macOS
   open src/quiz.html
   
   # On Linux
   xdg-open src/quiz.html
   
   # On Windows
   start src/quiz.html
   ```

## 💾 Database

This application uses a **file-based JSON database** approach for storing quiz questions. No external database server or setup is required.

### Data Storage Structure

- **questions.json**: Primary quiz questions database containing 50+ questions for the GH-300 certification exam
- **questions2.json**: Additional quiz questions database with extended question sets

### JSON Schema

Each question in the database follows this structure:

```json
{
  "id": 1,
  "topic": "Responsible AI with GitHub Copilot",
  "question": "Question text here?",
  "potentialAnswers": [
    "Answer option 1",
    "Answer option 2",
    "Answer option 3",
    "Answer option 4"
  ],
  "rightAnswer": "The correct answer",
  "explanation": "Detailed explanation of why this is the correct answer"
}
```

### Adding New Questions

To add new questions to the quiz:

1. Open `src/questions.json` or `src/questions2.json`
2. Add a new question object following the schema above
3. Ensure the `id` is unique
4. Assign an appropriate `topic` (existing topics include: "Responsible AI with GitHub Copilot", "GitHub Copilot Features", "Best Practices", "Governance and Compliance")
5. Save the file - no database migration or server restart needed!

### Data Persistence

- **Quiz State**: Currently stored in browser memory during the quiz session
- **Question Data**: Static JSON files loaded when the quiz starts
- **No Backend Required**: The application runs entirely client-side with no server or database dependencies

## 📚 Study Materials

- **Practical.md**: Contains practical notes about GitHub Copilot features including:
  - GitHub Copilot Extension setup
  - Authentication
  - Chat features and LLM models
  - Agent modes (Ask, Edit, Agent, Plan)
  - Context usage
  - Voice functionality
  - Examples and tips

- **Session Handouts**: Check the `session2` directory for PDF materials

## 🎯 Quiz Topics Covered

The certification quiz covers the following key areas:

1. **Responsible AI with GitHub Copilot**
   - Code validation and human review
   - Licensing and IP considerations
   - Bias mitigation

2. **GitHub Copilot Features**
   - Code suggestions and completions
   - Chat functionality
   - Context awareness

3. **Best Practices**
   - Security considerations
   - Code quality
   - Team collaboration

4. **Governance and Compliance**
   - Enterprise policies
   - Data privacy
   - Usage guidelines

## 🤝 Contributing

Contributions are welcome! If you'd like to add more questions, improve the quiz interface, or fix any issues:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/improvement`)
3. Make your changes
4. Commit your changes (`git commit -m 'Add some improvement'`)
5. Push to the branch (`git push origin feature/improvement`)
6. Open a Pull Request

## 📝 License

This project is intended for educational purposes to help developers prepare for the GitHub Copilot Certification exam.

## 📞 Contact

For questions or feedback, please open an issue in the repository.

---

**Good luck with your GitHub Copilot Certification! 🎉**
