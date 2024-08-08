namespace ConsoleApp1;

public abstract class Game
{
    public abstract string Name { get; }
    public virtual string Description { get; }
    public abstract void Play();
}