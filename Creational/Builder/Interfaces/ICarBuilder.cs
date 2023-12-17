using Builder.Entities;

namespace Builder.Interfaces;

public interface ICarBuilder
{
    public void setSeats(int Seats);
    public void setEngine(string Engine);
    public void setTripComputer(bool TripComputer);
    public void setGPS(bool Gps);
    public void setBrand(string Brand);
    public void setModel(string Model);
    public void setYear(int Year);
    public void setPrice(decimal Price);
}