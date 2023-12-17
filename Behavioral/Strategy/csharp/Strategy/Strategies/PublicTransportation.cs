using Design_Patterns.Interfaces;

namespace Design_Patterns;

public class PublicTransportation : ITransportationStrategy
{
    
    public void ExpectedTravelTime()
    {
        Console.WriteLine("Expected travel time: 3 days");
    }
    
    public void ExpectedCost()
    {
        Console.WriteLine("Expected cost: $320");
    }
    
    public void ExpectedComfort()
    {
        Console.WriteLine("Expected comfort: Low");
    }
    
}