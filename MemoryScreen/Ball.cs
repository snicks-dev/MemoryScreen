namespace MemoryScreen;

/// <summary>
/// Represents a ball object with a position of the screen and a velocity to move.
/// </summary>
internal sealed class Ball
{
    private int _horizontalVel = 1;
    private int _verticalVel = 1;
    
    public Point Position { get; private set; }

    public Ball(Point position)
    {
        Position = position;
    }

    /// <summary>
    /// Moves the ball to a new x and y position depending on the velocity.
    /// Changes direction if colliding with the bounds of the screen.
    /// </summary>
    /// <param name="screenWidth">Width bound of the screen</param>
    /// <param name="screenHeight">Height bound of the screen</param>
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