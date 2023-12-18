using Factory.Food;
using Factory.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a food");
        Console.WriteLine("1. Pasta");
        Console.WriteLine("2. Burguer");
        Console.WriteLine("3. Salad");

        var food = Console.ReadLine();

        var foodFactory = new FoodFactory();

        IFood foodToConsume = food switch
        {
            "1" => foodFactory.CreatePasta(),
            "2" => foodFactory.CreateBurguer(),
            "3" => foodFactory.CreateSalad(),
        };

        Console.WriteLine(foodToConsume.ToString());

        Console.WriteLine("Are you sure you want to consume this food? (Y/N)");

        var answer = Console.ReadLine();

        if (answer == "Y")
        {
            foodToConsume.Consume();
        }
        else
        {
            Console.WriteLine("Ok, maybe next time");
        }
    }

}

