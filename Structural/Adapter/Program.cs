using Adapter.Adapters;
using Adapter.Interfaces;
using Adapter.Services;

class Program
{
    static void Main(string[] args)
    {
        IFootballPlayer footballPlayer = new FootballPlayerServices();

        HandballPlayerAdapter footballPlayerAdaptedIntoHandballPlayer = new HandballPlayerAdapter(footballPlayer);

        footballPlayerAdaptedIntoHandballPlayer.Throw();
        footballPlayerAdaptedIntoHandballPlayer.Run();
        footballPlayerAdaptedIntoHandballPlayer.Jump();
    }
}
