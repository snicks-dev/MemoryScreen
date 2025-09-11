namespace MemoryScreen;

public interface IScreen : IRenderer
{
    int Width { get; }
    int Height { get; }
    
    void Clear();
    void DrawScreenBorder();
    void DrawPoint(Point point);
}