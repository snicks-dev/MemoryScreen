namespace MemoryScreen;

internal sealed class MemoryScreenManager : IRenderer
{
    private readonly IScreen _screen;

    private readonly IBall _ball;

    public MemoryScreenManager(IScreen screen, IBall ball)
    {
        _screen = screen;
        _ball = ball;
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
    }
    
    /// <summary>
    /// Update the content which should be displayed before rendering the screen.
    /// </summary>
    public void UpdateContent()
    {
        _ball.Move(_screen.Width, _screen.Height);
    }
}