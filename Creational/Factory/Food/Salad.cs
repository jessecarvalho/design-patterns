using Factory.Interfaces;

namespace Factory.Food;

public class Salad : IFood
{
    public string Name => "Salad";
    public int Calories => 100;
    public int Servings => 1;
    
    public void Consume()
    {
        Console.WriteLine("Eating a salad");
    }

    public override string ToString()
    {
        return $"{Name} has {Calories} calories and {Servings} servings";
    }
}