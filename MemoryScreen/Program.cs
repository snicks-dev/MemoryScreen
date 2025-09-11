using MemoryScreen;

// Hide cursor
Console.CursorVisible = false;

TimeSpan tickRate = TimeSpan.FromMilliseconds(100);

const int screenWidth = 64;
const int screenHeight = 16;
Screen screen = new(screenWidth, screenHeight);

Random rnd = new();
Point ballStartPos = new(rnd.Next(1, screenWidth), rnd.Next(1, screenHeight));
Ball ball = new(ballStartPos);

MemoryScreenManager memoryScreenManager = new(screen, ball);

while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter))
{
    memoryScreenManager.UpdateContent();
    memoryScreenManager.Render();
    Thread.Sleep(tickRate);
}

// Small workaround to keep the console open after stopping.
Console.ReadKey();