# Coding Exercise — Memory Screen (C#)

## Goal

Treat a block of memory as a screen. 
Use it to draw a rectangular border and place a ball that moves and bounces inside the border. 
Render the screen to the console.

## Environment 

.NET 6+ C# Console App (no external packages).

## Requirements

- [ ] Represent the screen as a block of memory.
- [ ] Draw a visible border.
- [ ] Place a ball inside.
- [ ] Make the ball move across frames.
- [ ] Make the ball bounce when it hits the border.

### Object-Oriented

- Implement with multiple small classes.
- No monolithic Main; keep responsibilities separated.
- Avoid global/static mutable state.

### Constraints

- Use only the console for output.
- Do not use external libraries.
- Focus on readability and simplicity.

## What to Submit

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