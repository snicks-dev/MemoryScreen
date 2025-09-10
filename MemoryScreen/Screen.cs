namespace MemoryScreen;

internal sealed class Screen
{
    private readonly char[,] _buffer;

    public int Width { get; }

    public int Height { get; }

    public Screen(int width, int height)
    {
        Width = width;
        Height = height;
        _buffer = new char[height, width];
    }

    public void Clear()
    {
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                _buffer[i, j] = ' ';
            }
        }
    }
    
    public void DrawScreenBorder()
    {
        // Generate top and bottom border
        for (int i = 0; i < Width; i++)
        {
            _buffer[0, i] = '#';
            _buffer[Height - 1, i] = '#';
        }
        // Generate left and right border
        for (int i = 0; i < Height - 1; i++)
        {
            _buffer[i + 1, 0] = '#';
            _buffer[i + 1, Width - 1] = '#';
        }
    }

    public void DrawPoint(Point point)
    {
        _buffer[point.Y, point.X] = 'o';
    }

    public void Render()
    {
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                Console.Write(_buffer[i, j]);
            }
            Console.WriteLine();
        }
    }
}