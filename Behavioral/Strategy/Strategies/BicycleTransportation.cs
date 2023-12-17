using Design_Patterns.Interfaces;

namespace Design_Patterns;

public class BicycleTransportation : ITransportationStrategy
{
    
    public void ExpectedTravelTime()
    {
        Console.WriteLine("Expected travel time: 4 days");
    }
    
    public void ExpectedCost()
    {
        Console.WriteLine("Expected cost: $0");
    }
    
    public void ExpectedComfort()
    {
        Console.WriteLine("Expected comfort: Low");
    }
    
}