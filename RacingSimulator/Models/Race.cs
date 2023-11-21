using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models;

public class Race : IRace
{
    private IEnumerable<Vehicle> _vehicles;
    private int _distance;

    public Race(IEnumerable<Vehicle> vehicles, int distance)
    {
        _vehicles = vehicles;
        _distance = distance;
    }

    public void Registration()
    {
        
    }

    public void Simulate()
    {
        
    }
}