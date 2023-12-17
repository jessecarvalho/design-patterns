using Design_Patterns.Interfaces;

namespace Design_Patterns;

public class FlightTransportation : ITransportationStrategy
{
    
    public void ExpectedTravelTime()
    {
        Console.WriteLine("Expected travel time: 3 hours");
    }
    
    public void ExpectedCost()
    {
        Console.WriteLine("Expected cost: $500");
    }
    
    public void ExpectedComfort()
    {
        Console.WriteLine("Expected comfort: High");
    }
    
}