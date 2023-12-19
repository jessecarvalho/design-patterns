using Adapter.Interfaces;

namespace Adapter.Adapters;

public class HandballPlayerAdapter : IHandBallPlayer
{
    private readonly IFootballPlayer _footballPlayer;

    public HandballPlayerAdapter(IFootballPlayer footballPlayer) {
        _footballPlayer = footballPlayer;
    }

    public void Throw() {
        _footballPlayer.Kick(); 
    }

    public void Run() {
        _footballPlayer.Run(); 
    }

    public void Jump() {
        _footballPlayer.Jump();
    }
}
