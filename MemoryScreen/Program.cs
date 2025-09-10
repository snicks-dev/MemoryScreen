using MemoryScreen;

// Hide cursor
Console.CursorVisible = false;

TimeSpan tickRate = TimeSpan.FromMilliseconds(100);
MemoryScreenManager memoryScreen = new();

while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter))
{
    memoryScreen.UpdateContent();
    memoryScreen.Render();
    Thread.Sleep(tickRate);
}

// Small workaround to keep the console open after stopping.
Console.ReadKey();