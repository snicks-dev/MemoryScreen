using NUnit.Framework;

namespace MemoryScreen.Tests;

[TestFixture]
[TestOf(typeof(MemoryScreenManager))]
internal sealed class MemoryScreenManagerTest
{
    [TestCase(42, 24, 10, 15)]
    public void Render_WhenScreenFuncsCalled_ShouldPass(int width, int height, int x, int y)
    {
        ScreenStub screenStub = new(width, height);
        BallStub ballStub = new(new Point(x, y));

        MemoryScreenManager memoryScreenManager = new(screenStub, ballStub);
        memoryScreenManager.Render();

        Assert.That(screenStub.IsScreenCleared, Is.True, "Clear() called. Screen should be cleared");
        Assert.That(screenStub.IsBorderDrawn, Is.True, "DrawBorder() called. Border should be drawn.");
        Assert.That(screenStub.IsPointDrawn, Is.True, "DrawPoint() called. Point should be drawn.");
        Assert.That(ballStub.Position, Is.EqualTo(screenStub.DrawPointPosition),
            "Drawn point in buffer should be the same as the balls position");
        Assert.That(screenStub.IsScreenRendered, Is.True, "Render() called. Screen buffer should be written.");
    }

    [TestCase(42, 24, 10, 15)]
    [TestCase(12, 12, 5, 5)]
    [TestCase(32, 64, 24, 32)]
    public void UpdateContent_WhenBallFuncCalled_ShouldPassAndUpdateBall(int width, int height, int ballX, int ballY)
    {
        ScreenStub screenStub = new(width, height);
        BallStub ballStub = new(new Point(ballX, ballY));

        MemoryScreenManager memoryScreenManager = new(screenStub, ballStub);
        memoryScreenManager.UpdateContent();

        Assert.That(width, Is.EqualTo(ballStub.CalledWithWidth), 
            "Move() called. Screen width should be correctly passed to respect screen dimensions.");
        Assert.That(height, Is.EqualTo(ballStub.CalledWithHeight), 
            "Move() called. Height should be correctly passed to respect screen dimensions.");
        Assert.That(new Point(ballX + 1, ballY + 1), Is.EqualTo(ballStub.Position), 
            "Move() called. Ball position should be correctly updated to Position + velocity.");
    }
}

file class BallStub : IBall
{
    public Point Position { get; private set; }
    public int CalledWithWidth {get; private set; }
    public int CalledWithHeight {get; private set; }

    public BallStub(Point position)
    {
        Position = position;
    }

    public void Move(int screenWidth, int screenHeight)
    {
        Position = new Point(Position.X + 1, Position.Y + 1);
        CalledWithWidth = screenWidth;
        CalledWithHeight = screenHeight;
    }
}

file class ScreenStub : IScreen
{
    public bool IsScreenCleared { get; private set; }
    public bool IsBorderDrawn { get; private set; }
    public bool IsPointDrawn { get; private set; }
    public Point DrawPointPosition { get; private set; }
    public bool IsScreenRendered { get; private set; }
    public int Width { get; }
    public int Height { get; }

    public ScreenStub(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public void Clear()
    {
        IsScreenCleared = true;
    }

    public void DrawScreenBorder()
    {
        IsBorderDrawn = true;
    }

    public void DrawPoint(Point point)
    {
        IsPointDrawn = true;
        DrawPointPosition = point;
    }

    public void Render()
    {
        IsScreenRendered = true;
    }
}