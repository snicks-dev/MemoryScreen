namespace MemoryScreen;

internal sealed class Ball
{
    private int _horizontalVel = 1;
    private int _verticalVel = 1;
    
    public Point Position { get; private set; }

    public Ball(Point position)
    {
        Position = position;
    }

    public void Move(int screenWidth, int screenHeight)
    {
        Point newPosition = new(Position.X + _horizontalVel, Position.Y + _verticalVel);

        if (newPosition.X <= 0 || newPosition.X >= screenWidth - 1)
        {
            _horizontalVel = -_horizontalVel;
        }

        if (newPosition.Y <= 0 || newPosition.Y >= screenHeight - 1)
        {
            _verticalVel  = -_verticalVel;
        }
        
        Position = new Point(Position.X + _horizontalVel, Position.Y + _verticalVel);
    }
}