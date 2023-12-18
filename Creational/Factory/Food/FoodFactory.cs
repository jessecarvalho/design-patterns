using Factory.Interfaces;

namespace Factory.Food;

public class FoodFactory
{
    public IFood CreateBurguer()
    {
        return new Burger();
    }
    
    public IFood CreatePasta()
    {
        return new Pasta();
    }
    
    public IFood CreateSalad()
    {
        return new Salad();
    }

    public IFood CreateFood(string foodName)
    {
        return foodName switch
        {
            "Burger" => CreateBurguer(),
            "Pasta" => CreatePasta(),
            "Salad" => CreateSalad(),
            _ => throw new ArgumentException("Invalid food name")
        };
    }
}