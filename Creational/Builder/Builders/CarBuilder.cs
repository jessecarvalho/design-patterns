using Builder.Entities;
using Builder.Interfaces;

namespace Builder.Builders;

public class CarBuilder : ICarBuilder
{

    private readonly Car _car = new Car();
    
    public void setSeats(int Seats)
    {
        _car.Seats = Seats;
    }
    
    public void setEngine(string Engine)
    {
        _car.Engine = Engine;
    }
    
    public void setTripComputer(bool TripComputer)
    {
        _car.TripComputer = TripComputer;
    }
    
    public void setGPS(bool Gps)
    {
        _car.Gps = Gps;
    }
    
    public void setBrand(string Brand)
    {
        _car.Brand = Brand;
    }
    
    public void setModel(string Model)
    {
        _car.Model = Model;
    }
    
    public void setYear(int Year)
    {
        _car.Year = Year;
    }
    
    public void setPrice(decimal Price)
    {
        _car.Price = Price;
    }
    
    public Car getCar()
    {
        return _car;
    }
    
}