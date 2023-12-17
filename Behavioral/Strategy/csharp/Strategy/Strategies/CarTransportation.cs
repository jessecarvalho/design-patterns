using Design_Patterns.Interfaces;

namespace Design_Patterns;

public class CarTransportation : ITransportationStrategy
{
    
    public void ExpectedTravelTime()
    {
        Console.WriteLine("Expected travel time: 22 hours");
    }
    
    public void ExpectedCost()
    {
        Console.WriteLine("Expected cost: $500");
    }
    
    public void ExpectedComfort()
    {
        Console.WriteLine("Expected comfort: Medium");
    }
    
}