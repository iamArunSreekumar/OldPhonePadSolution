This project is a solution to the Iron Software C# Coding Challenge, which simulates the old mobile phone keypad text input system. It includes a clean, production-ready console app written in C# with .NET 6, organized for readability, testability, and team collaboration.

---

✅ Problem Statement

Simulate the text input functionality of a classic phone keypad:

- Keypad layout example:

  2 → ABC   3 → DEF   4 → GHI  
  5 → JKL   6 → MNO   7 → PQRS  
  8 → TUV   9 → WXYZ  0 → SPACE

- Input is a string of numbers representing keypad presses.  
- Pressing a button multiple times cycles through its characters.  
- A pause (space `' '`) is needed to type two letters from the same key.  
- `*` is a backspace.  
- `#` is the "send" key and ends input.

Examples:  
OldPhonePad("33#") → "E"  
OldPhonePad("227*#") → "B"  
OldPhonePad("4433555 555666#") → "HELLO"  
OldPhonePad("8 88777444666*664#") → "TURING"

---

🧠 Solution Overview

- Written in **C# (.NET 6.0)** using clean OOP practices.  
- Core logic is encapsulated in `OldPhonePadLogic.cs`.  
- Entry point is in `Program.cs`.  
- Unit tests included in `OldPhonePadTests` project (uses xUnit).  
- Backspace and pause behavior is fully supported.  
- Designed for clarity, extensibility, and real-world robustness.

---

🏗️ Project Structure

OldPhonePadSolution/  
├── OldPhonePad/  
│   ├── OldPhonePadLogic.cs  
│   ├── Program.cs  
│   └── OldPhonePad.csproj  
├── OldPhonePadTests/  
│   ├── OldPhonePadTests.cs  
│   └── OldPhonePadTests.csproj  
└── README.md

---

✅ How to Run

1. Ensure .NET SDK is installed (tested with .NET 6): https://dotnet.microsoft.com/en-us/download/dotnet/6.0  
2. Navigate to the solution folder in terminal: `cd "OldPhonePadSolution/OldPhonePad"`  
3. Run the app: `dotnet run`

---

✅ How to Test

1. Navigate to the test project: `cd "../OldPhonePadTests"`  
2. Run tests: `dotnet test`

Tests cover normal and edge cases including empty input and backspace-only input.

---

📦 Dependencies

- .NET 6 SDK  
- xUnit (for unit tests)

---

💡 Final Thoughts

This solution demonstrates production-level engineering principles:  
- Clean code  
- Clear separation of logic  
- Robust input handling  
- Unit testing  
- Developer-friendly documentation

Looking forward to the opportunity to be part of the Iron Software team. Thank you!
