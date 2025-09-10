# Coding Exercise — Memory Screen (C#)

Treat a block of memory as a screen.
Use it to draw a rectangular border and place a ball that moves and bounces inside the border.
Render the screen to the console.

## How to run the app

- Targets .NET 8

### Compile by yourself

- Clone the repo with `git clone https://github.com/snicks-dev/MemoryScreen.git` to compile it yourself
- Navigate into the project directory and execute `dotnet run` or `dotnet run --project ./MemoryScreen/MemoryScreen.csproj`

### Run the compiled exe from the Github release page

- Download the compiled single file exe from the release `https://github.com/snicks-dev/MemoryScreen/releases/tag/0.0.1`
- The single file exe should contain everything required to run the app.

## Finished requirements

- [X] Represent the screen as a block of memory.
- [X] Draw a visible border.
- [X] Place a ball inside.
- [X] Make the ball move across frames.
- [X] Make the ball bounce when it hits the border.

---

## Original exercise description

### Environment

.NET 6+ C# Console App (no external packages).

### Requirements

- Represent the screen as a block of memory.
- Draw a visible border.
- Place a ball inside.
- Make the ball move across frames.
- Make the ball bounce when it hits the border.

### Object-Oriented

- Implement with multiple small classes.
- No monolithic Main; keep responsibilities separated.
- Avoid global/static mutable state.

### Constraints

- Use only the console for output.
- Do not use external libraries.
- Focus on readability and simplicity.

### What to Submit

- Source code (single console app).
- Short README (how to run, which requirements you finished).

## Sample of console output

```bash
############################################################
#                                                          #
#                                                          #
#                       o                                  #
#                                                          #
#                                                          #
############################################################
```
