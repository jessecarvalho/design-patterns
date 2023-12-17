using Design_Patterns;
using Design_Patterns.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        const string origin = "Guarulhos";
        const string destiny = "Salvador";

        Console.WriteLine($"{origin} -> {destiny}");

        Console.WriteLine("What is your preferred transportation? ");
        Console.WriteLine("1 - Car");
        Console.WriteLine("2 - Bicycle");
        Console.WriteLine("3 - Flight");
        Console.WriteLine("4 - Public Transportation");

        var option = Convert.ToInt32(Console.ReadLine());

        ITransportationStrategy transportationStrategy = option switch
        {
            1 => new CarTransportation(),
            2 => new BicycleTransportation(),
            3 => new FlightTransportation(),
            4 => new PublicTransportation(),
            _ => throw new ArgumentException("Invalid option")
        };

        transportationStrategy.ExpectedTravelTime();
        transportationStrategy.ExpectedComfort();
        transportationStrategy.ExpectedCost();
    }

}

