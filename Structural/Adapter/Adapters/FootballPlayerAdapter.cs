using Adapter.Interfaces;

namespace Adapter.Adapters;

public class FootballPlayerAdapter : IFootballPlayer
{
    private readonly IHandBallPlayer _handBallPlayer;

    public FootballPlayerAdapter(IHandBallPlayer handBallPlayer) {
        _handBallPlayer = handBallPlayer;
    }

    public void Kick() {
        _handBallPlayer.Throw();
    }

    public void Run() {
        _handBallPlayer.Run();
    }

    public void Jump() {
        _handBallPlayer.Jump();
    }

}