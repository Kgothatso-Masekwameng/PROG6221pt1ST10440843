🛡️ Cybersecurity Awareness Chatbot (PROG6221)
A console-based C# chatbot designed to educate users on cybersecurity best practices, detect emotional tone, and offer empathetic responses. The bot uses keyword recognition, memory persistence, and randomized fallback responses to simulate intelligent conversation and promote online safety.

📌 Features
✅ Keyword Recognition: Recognizes key cybersecurity terms like password, phishing, and safe browsing.

🧠 Sentiment Detection: Responds empathetically to emotional states such as worried, frustrated, or anxious.

🗂️ Memory Persistence: Remembers the user’s name across sessions using local file storage.

🎲 Randomized Fallbacks: If no keyword or emotion is detected, a helpful generic message is displayed.

🔄 Dual Keyword Handling: Capable of detecting multiple keywords in a single input.

🎨 User-Friendly Interface: Clean command-line interface with personalized prompts.

🏁 Getting Started
🔧 Requirements
.NET 6 or later

Any C# IDE or text editor (e.g., Visual Studio, VS Code)

▶️ Running the Program
Clone the repository or download the source files.

Open the solution/project in your C# IDE.

Build and run the application.

bash
Copy
Edit
dotnet build
dotnet run
🧪 Example Interaction
text
Copy
Edit
Bot: Welcome back, Sarah!
Bot: Type something to begin. Type 'exit' to quit.

Sarah: I'm anxious about phishing attacks.
Bot: I understand you're feeling that way. Cybersecurity can be overwhelming, but you're not alone. Let’s take it one step at a time.
Bot: Don’t click on suspicious links or attachments. Verify email sources.
📁 Project Structure
bash
Copy
Edit
PROG6221pt1/
│
├── Program.cs             # Entry point
├── ResponseToUser.cs      # Handles conversation logic
├── MemoryManager.cs       # Manages saving/loading user's name
└── user_memory.txt        # Stores persistent user name
📚 Educational Value
This chatbot is part of a Cybersecurity Awareness initiative for educational purposes. It aims to help users become more aware of online threats and how to protect themselves in a friendly and interactive way.

🔒 Sample Keywords & Responses
Keyword	Bot Response
password	Use long, unique passwords and enable two-factor authentication.
phishing	Don’t click on suspicious links or attachments. Verify email sources.
safe browsing	Always check the URL, use HTTPS sites, and avoid public Wi-Fi for sensitive tasks.
worried, anxious, frustrated	I understand you're feeling that way... (empathetic message)

💡 Future Improvements
🧠 Save full chat history or topics of interest.

🌐 GUI integration using WPF or Blazor.

🗣️ Text-to-speech and voice input.

🔍 AI/NLP integration using external APIs for smarter parsing.

👨‍💻 Author
Module: PROG6221 – Programming 2A

Institution: [Your University/College Name]

Language: C# (.NET Console Application)# PROG6221pt1
# PROG6221
# 🛡️ Cybersecurity Awareness Bot -

Welcome to the **Cybersecurity Awareness Bot**, a simple yet interactive command-line chatbot built in **C#**. This is Part 1 of a multi-phase Portfolio of Evidence (POE) project focused on promoting safe online practices through conversational interaction.

---

## 💡 Project Overview

This chatbot helps users learn the basics of cybersecurity through friendly conversation. It includes:

- Voice greeting when the application launches.
- ASCII art logo for branding and presentation.
- Personalized text-based greetings.
- Basic interaction with predefined cybersecurity-related questions.
- Input validation to gracefully handle unexpected input.
- Enhanced console UI using color and spacing.
- GitHub Version Control and CI with GitHub Actions.

---

## 🎯 Objectives Met

- ✅ Write a console program that requires user input.
- ✅ Apply string manipulation and conditional logic to solve a problem.
- ✅ Use automatic properties and methods to structure code logically.
- ✅ Enhance the UI with ASCII and console formatting.
- ✅ Use GitHub and Continuous Integration (CI) to manage code effectively.

---

## 🚀 How to Run the Bot

1. Clone the repository or download the project files.
2. Ensure you have **.NET SDK 8.0+** installed.
3. Place a `Greeting.wav` file (short voice message) in the project root directory.
4. Build and run the project with:

```bash
dotnet build
dotnet run
