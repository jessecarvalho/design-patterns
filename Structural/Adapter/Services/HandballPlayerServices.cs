using Adapter.Interfaces;

namespace Adapter.Services;

public class HandballPlayerServices : IHandBallPlayer
{
    public void Throw()
    {
        Console.WriteLine("Throwing the ball");
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