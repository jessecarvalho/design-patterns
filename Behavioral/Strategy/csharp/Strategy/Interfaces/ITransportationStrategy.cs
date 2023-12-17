namespace Design_Patterns.Interfaces;

public interface ITransportationStrategy
{
    public void ExpectedTravelTime();
    public void ExpectedCost();
    public void ExpectedComfort();
}