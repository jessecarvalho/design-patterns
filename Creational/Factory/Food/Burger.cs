using Factory.Interfaces;

namespace Factory.Food;

public class Burger : IFood
{
    public string Name => "Burger";
    public int Calories => 1000;
    public int Servings => 1;
    
    public void Consume()
    {
        Console.WriteLine("Eating a burger");
    }
    
    public override string ToString()
    {
        return $"{Name} has {Calories} calories and {Servings} servings";
    }
}