
# AGENTS.md

## Project Overview
This project is a simple educational VB.NET WinForms application that implements a small game called "Камни 21" (21 Stones).

The purpose of the application is to demonstrate the use of While loops and basic programming constructs in a beginner-level programming course.

The code should be simple, readable, and similar to introductory classroom examples.

This project intentionally avoids complex architecture, advanced patterns, or external libraries.

---

# Application Requirements

## Technology
- Language: VB.NET
- Framework: WinForms
- Project type: Single-form desktop application
- Target audience: beginner programming students

Do not introduce:
- dependency injection
- advanced design patterns
- async logic
- external packages

Keep implementation procedural and simple.

---

# Game Description

## Game Name
Камни 21 (21 Stones)

## Rules
1. The game starts with 21 stones.
2. The player and the computer take turns.
3. On each turn a player can take 1, 2, or 3 stones.
4. The player who takes the last stone loses.
5. When stones reach 0, the game ends immediately.

---

# Educational Goal

The project must demonstrate the use of While loops.

While loops should be used in at least two places:

### 1. Player input validation
The program must repeatedly check input until it is valid.

Invalid input includes:
- non-numeric input
- numbers less than 1
- numbers greater than 3
- numbers greater than remaining stones

### 2. Computer move validation
The computer must ensure that its move is valid using a While loop.

---

# User Interface Requirements

Create a single form Form1.

The following controls must exist with these exact names.

## Labels

### LabelStones
Displays the number of stones remaining.

Example text:
Осталось камней: 21

### LabelStatus
Displays game messages.

Examples:
- Ваш ход. Возьмите 1-3 камня.
- Ход компьютера...
- Вы выиграли
- Вы проиграли

## Input

### TextBoxTake
Player enters how many stones to take.

Allowed values:
1
2
3

## Buttons

### ButtonTake
Text:
Взять

Function:
Execute the player's move.

### ButtonNew
Text:
Новая игра

Function:
Reset the game state.

## Game Log

### ListBoxLog
Displays history of moves.

Examples:
Игрок взял: 2, осталось: 19
Компьютер взял: 3, осталось: 16

## Progress Bar

### ProgressBar1
Represents remaining stones.

Settings:
Minimum = 0
Maximum = 21
Value = current stones

---

# Program State Variables

Inside Form1 define the following variables.

Dim stones As Integer
Dim turnPlayer As Boolean

stones represents how many stones remain.
turnPlayer indicates if it is the player's turn.

---

# Program Flow

## On Application Start
Call NewGame().

## NewGame()

Responsibilities:
- Reset stones to 21
- Clear move history
- Reset UI
- Enable player input
- Reset progress bar
- Set player turn

## Player Move

Triggered by:
ButtonTake_Click

Steps:
1. Read value from TextBoxTake
2. Validate input
3. Use While loop to check if value is valid
4. Subtract stones
5. Update UI
6. Log move
7. Check for game end
8. If game continues call computer move

## Computer Move

Method:
Sub ComputerTurn()

Strategy:
Prefer leaving stone counts:
1
5
9
13
17

Calculation:
take = (stones - 1) Mod 4

If result is invalid:
take = Int(Rnd() * 3) + 1

Use While loop to guarantee the move is valid.

## EndGame(message)

Responsibilities:
- Show win/lose message
- Disable ButtonTake
- Keep ButtonNew active

---

# Code Style Requirements

Keep the code simple and similar to classroom examples.

Preferred style:
- short procedures
- minimal abstraction
- simple variable names
- direct UI updates
- avoid complex logic

Allowed constructs:
- If
- While
- Sub procedures
- Integer variables

Avoid:
- classes beyond Form1
- LINQ
- collections unless necessary
- advanced VB features

---

# UI Simplicity

The interface should be clean but simple.

Optional improvements allowed:
- larger font for labels
- centered layout
- title label like:

Камни 21

But do not add unnecessary UI complexity.

---

# Expected Result

The finished application should:
- compile without errors
- start a playable game
- correctly enforce rules
- demonstrate While loops clearly
- be understandable by beginner programmers

---

# End of AGENTS.md
