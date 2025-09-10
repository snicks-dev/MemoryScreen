using MemoryScreen;

// Hide cursor
Console.CursorVisible = false;

bool isStarted;
TimeSpan tickRate = TimeSpan.FromMilliseconds(100);

const int screenWidth = 64;
const int screenHeight = 16;
Screen screen = new(screenWidth, screenHeight);

Point ballStartPos = new(screenWidth / 2, screenHeight / 2);
Ball ball = new(ballStartPos);

while (true)
{
    screen.Clear();
    screen.DrawScreenBorder();
    ball.Move(screen.Width, screen.Height);
    screen.DrawPoint(ball.Position);
    screen.Render();
    Thread.Sleep(100);
    Console.SetCursorPosition(0,0);
}