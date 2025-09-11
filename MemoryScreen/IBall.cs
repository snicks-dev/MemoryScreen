namespace MemoryScreen;

public interface IBall
{
    Point Position { get; }
    void Move(int screenWidth, int screenHeight);
}