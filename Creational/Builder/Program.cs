using Builder.Builders;
using Builder.Entities;

class Program
{
    static void Main(string[] args)
    {

        var someCar = new CarBuilder();
        someCar.setBrand("SomeBrand");
        someCar.setModel("SomeModel");
        someCar.setYear(2021);
        someCar.setPrice(100000);
        someCar.setEngine("SomeEngine");
        someCar.setGPS(true);
        someCar.setSeats(4);
        someCar.setTripComputer(true);
        var car = someCar.getCar();
        
        Console.WriteLine($"Model of created car: {car.Model}");
        
    }
}
