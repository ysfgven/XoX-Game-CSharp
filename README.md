# XoX-Game (C#)

**XoX-Game** is a console-based Tic-Tac-Toe (XoX) game written in **C#**, demonstrating object-oriented programming (OOP) concepts, encapsulation, and basic game logic.  
This project is designed to showcase clean code, class design, and console-based game development.

---

## Features

- **Two-Player Game**
  - Play Tic-Tac-Toe with two human players.
  - Supports alternating turns between Player 1 (`X`) and Player 2 (`O`).

- **Game Logic**
  - Validates player moves and prevents overwriting occupied cells.
  - Detects winning conditions for rows, columns, and diagonals.
  - Provides real-time board display with numbered positions for easy input.

- **User-Friendly Console Interface**
  - Entry screen with welcome message.
  - Clear board display after each move.
  - Announces the winner immediately upon game completion.
  - Input validation with error messages for invalid moves.

- **OOP Concepts Demonstrated**
  - Classes and encapsulation (`Player`, `GameController`, `Display`, `ScreenController`)
  - Separation of concerns between game logic, input/output, and program flow
  - Constructor initialization and method-based gameplay flow

---

## Installation

1. Clone the repository:

```bash
git clone https://github.com/ysfgven/XoX-Game-CSharp.git
```
2. Open the solution file **XoX-Game.sln** in **Visual Studio** or **Rider**.  

3. Build the project to restore dependencies.  

4. Run the application — the main entry point is in the `Program.cs` file.


---

## How to Play

1. Run the program. The entry screen will be displayed.  

2. Enter names for **Player 1** and **Player 2**.  

3. The board will display numbered positions (0–8).  

4. Players take turns entering the number of the cell where they want to place their symbol.  

5. The game ends when:  
   - One player completes a row, column, or diagonal (winner announced), or  
   - All cells are filled without a winner (tie).


---

## 📁 Project Structure

- `XoX-Game/`
  - `Program.cs` → Entry point of the application (`Main` method)  
  - `ScreenController.cs` → Manages game start and screen flow  
  - `GameController.cs` → Contains game logic, moves, and win detection  
  - `Display.cs` → Handles board display and entry screen  
  - `Player.cs` → Represents a player with ID and username  
  - `XoX-Game.csproj` → Project configuration file  
  - `.gitignore` → Git ignore rules for build files and IDE settings  
  - `bin/` and `obj/` → Build output and temporary files (ignored in Git)  

---

## Notes

- This project uses **pure C# console application** techniques — no external libraries required.  
- Demonstrates **clean code**, **OOP principles**, and **basic game development** in a console environment.  
- Designed as a simple **two-player game**; no AI implemented yet.
