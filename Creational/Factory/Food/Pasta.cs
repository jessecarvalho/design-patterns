using Factory.Interfaces;

namespace Factory.Food;

public class Pasta : IFood
{

    public string Name => "Pasta";
    public int Calories => 500;
    public int Servings => 1;

    public void Consume()
    {
        Console.WriteLine("Eating Pasta");
    }

    public override string ToString()
    {
        return $"{Name} has {Calories} calories and {Servings} servings";
    }

}