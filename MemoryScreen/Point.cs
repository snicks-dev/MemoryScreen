namespace MemoryScreen;

/// <summary>
/// Simple 2D coordinate to describe a position of an object.
/// </summary>
public struct Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}