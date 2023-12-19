using Adapter.Interfaces;

namespace Adapter.Services;

public class FootballPlayerServices : IFootballPlayer
{
    public void Kick()
    {
        Console.WriteLine("Kicking the ball");
    }

    public void Run()
    {
        Console.WriteLine("Running");
    }

    public void Jump()
    {
        Console.WriteLine("Jumping");
    }
}