[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/nVrNDqsS)
[![Open in Visual Studio Code](https://classroom.github.com/assets/open-in-vscode-2e0aaae1b6195c2367325f4f02e2d04e9abb55f0b24a779b69b11b9e10269abc.svg)](https://classroom.github.com/online_ide?assignment_repo_id=23839550&assignment_repo_type=AssignmentRepo)
# 💻 C# Final Project 2026

**Course:** Introduction to Programming (C#)  
**Due:** See your teacher for the deadline  
**Time to Complete:** 46 minutes (in-class) or as assigned  
**Total Points: 200**

---

## 📋 Overview

For your final project, you will **design and build your own C# application or game** using the skills you have learned this semester. You get to choose what you create — as long as it uses the concepts listed below.

This is your chance to be creative! You could build a quiz game, a story adventure, a calculator app, a number guessing game, a grade checker, or anything else you can imagine.

---

## ✅ Required Concepts

Your project **must** include all of the following:

- [ ] At least **3 variables** that store meaningful data (`string`, `int`, `double`, or `bool`)
- [ ] At least **one `Console.ReadLine()`** that asks the user for something
- [ ] At least **one type conversion** (`int.Parse()`, `double.Parse()`, or `Convert.ToInt32()`)
- [ ] At least **one `if` / `else if` / `else`** statement that changes what happens based on user input or a variable
- [ ] At least **3 `Console.WriteLine()`** statements that display output to the user
- [ ] Code that is **readable** — use clear variable names and leave a `//` comment explaining each major section

---

## 🔄 Python → C# Quick Reference

| Python | C# Equivalent |
|--------|---------------|
| `print("Hello")` | `Console.WriteLine("Hello");` |
| `input("Your name: ")` | `Console.Write("Your name: "); string name = Console.ReadLine();` |
| `int("42")` | `int.Parse("42")` or `Convert.ToInt32("42")` |
| `float("3.14")` | `double.Parse("3.14")` |
| `# comment` | `// comment` |
| `if x > 10:` | `if (x > 10) { }` |
| `elif x > 5:` | `else if (x > 5) { }` |
| `else:` | `else { }` |
| Variable (no type needed) | Must declare type: `int score = 0;` |

---

## 🎮 Project Ideas (Pick One or Invent Your Own!)

| Idea | Description |
|------|-------------|
| **Number Guessing Game** | Pick a secret number; let the user guess; tell them if they’re too high, too low, or correct |
| **Quiz Game** | Ask the user 3–5 questions; check answers; give a final score |
| **Story Adventure** | Tell a story and let the user make choices that change the ending |
| **Grade Calculator** | Ask for test scores; calculate an average; print a letter grade |
| **Simple Calculator** | Ask for two numbers and an operation (+, -, *, /); print the result |
| **Personality Quiz** | Ask fun questions; use `if/else if/else` to give a result based on answers |
| **Your Own Idea** | Pitch any idea — if it meets the requirements, go for it! |

---

## 📁 Files in This Repository

| File | Purpose |
|------|---------|
| `Program.cs` | Your starter code file — **write all your code here** |
| `CSharpFinal2026.csproj` | Project configuration — do not edit |
| `CSharpFinal2026.sln` | Visual Studio solution file — open this to launch the project |
| `PLANNING.md` | Fill this out **before** you start coding |
| `RUBRIC.md` | How your project will be graded (200 points total) |

---

## 🖥️ Getting Started with GitHub Classroom

This assignment is distributed through **GitHub Classroom**. Follow these steps to get your personal copy and open it in Visual Studio.

### Step 1 — Accept the Assignment
1. Click the **GitHub Classroom assignment link** provided by your teacher in Canvas.
2. Sign in to GitHub (create a free account at [github.com](https://github.com) if you don’t have one).
3. Click **Accept this assignment**. GitHub will automatically create a personal repository for you.
4. Your repo will be named something like `csharp-final-2026-YourUsername`. This is YOUR copy.

---

## 🛠️ Opening in Visual Studio Community

> **Visual Studio Community is free.** Download it at [visualstudio.microsoft.com](https://visualstudio.microsoft.com/vs/community/) if you don’t have it. During install, make sure to select **“.NET desktop development”**.

### Option A — Clone from GitHub (Recommended)
1. Open **Visual Studio Community**.
2. On the start screen, click **“Clone a repository”**.
3. Paste your GitHub repository URL (e.g. `https://github.com/ECCCompSci/csharp-final-2026-YourUsername`) into the box.
4. Choose a folder on your computer to save it, then click **Clone**.
5. Visual Studio will open the project automatically. If it doesn’t, double-click `CSharpFinal2026.sln` in the Solution Explorer.

### Option B — Download ZIP and Open
1. On your GitHub repository page, click the green **Code** button.
2. Click **Download ZIP** and extract it to a folder on your computer.
3. Open **Visual Studio Community**.
4. Click **Open a project or solution**.
5. Navigate to the extracted folder and open **`CSharpFinal2026.sln`**.

---

## ▶️ Running Your Code in Visual Studio

1. Open `Program.cs` from the **Solution Explorer** panel on the right.
2. Write your code in the sections marked with `// ----`.
3. Press **F5** (or click the green ▶ **Start** button at the top) to **build and run** your program.
4. A console window will appear — this is where your program runs and where users type input.
5. If you see red squiggly lines, hover over them to read the error before running.

> 💡 **Tip:** Press **Ctrl + F5** to run without the debugger — the console window will stay open after the program finishes so you can read the output.

---

## 📤 Submitting from Visual Studio

### If you cloned from GitHub (Option A):
1. After finishing your code, go to **Git → Commit or Stash** (top menu bar).
2. Type a commit message like `"Final project complete"` and click **Commit All**.
3. Then click **Git → Push** to send your code to GitHub.
4. Copy your repository URL and paste it into the **Canvas assignment submission box**.

### If you downloaded a ZIP (Option B):
1. Go to your GitHub repository page in a browser.
2. Click on `Program.cs`, then click the **pencil icon** to edit it.
3. Copy and paste your finished code from Visual Studio into the browser editor.
4. Click **Commit changes**, then submit the repo URL in Canvas.

> ⚠️ **Important:** Your teacher can see every commit. Make sure your final code is pushed/committed before the deadline!

---

## 🚀 Tips for Success

- **Plan before you code.** Fill out `PLANNING.md` first — it saves time!
- **C# requires curly braces `{ }` for every `if`, `else if`, and `else` block.**
- **Every statement ends with a semicolon `;`** — this is different from Python.
- **Variable types matter.** Declare `int`, `string`, `double`, or `bool` before using a variable.
- **Use the Error List** (View → Error List) in Visual Studio to see all errors at once.
- **Commit often** — every time you finish a section, push your work.
- **Ask for help early** — don’t wait until the last minute!
