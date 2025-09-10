namespace MemoryScreen;

internal sealed class MemoryScreenManager : IRenderer
{
    private const int _screenWidth = 64;
    private const int _screenHeight = 16;
    private readonly Screen _screen = new(_screenWidth, _screenHeight);

    private readonly Ball _ball;

    public MemoryScreenManager()
    {
        Random rnd = new();
        Point ballStartPos = new(rnd.Next(1, _screenWidth), rnd.Next(1, _screenHeight));
        _ball = new Ball(ballStartPos);
    }

    /// <summary>
    /// Clears the screen and renders the new content that should be displayed.
    /// </summary>
    public void Render()
    {
        _screen.Clear();
        _screen.DrawScreenBorder();
        _screen.DrawPoint(_ball.Position);
        _screen.Render();
        Console.SetCursorPosition(0,0);
    }
    
    /// <summary>
    /// Update the content which should be displayed before rendering the screen.
    /// </summary>
    public void UpdateContent()
    {
        _ball.Move(_screen.Width, _screen.Height);
    }
}