using RacingSimulator.Models.Abstracts;
using RacingSimulator.Views;

namespace RacingSimulator.Services;

internal class Race
{
    private readonly List<Vehicle> _vehicles;
    private readonly int _distance;
    private Vehicle? _winner;

    internal Race(IEnumerable<Vehicle> vehicles, int distance)
    {
        _vehicles = new List<Vehicle>(vehicles);
        _distance = distance;
    }

    internal void Simulate()
    {
        Console.WriteLine("------------------------");
        Menu.ShowInfoMessage("Время каждого участника:");
        var raceResult = _vehicles.OrderBy(vehicle =>
        {
            var timeResult = vehicle.Go(_distance);
            var timeSpan = TimeSpan.FromSeconds(timeResult);
            Console.WriteLine($"{vehicle.Name}: {timeSpan:hh\\:mm\\:ss}");
            return timeResult;
        });

        _winner = raceResult.First();
        Console.WriteLine("------------------------");
    }

    internal void Result()
    {
        if (_winner != null)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"Победитель: {_winner.Name}");
            Console.WriteLine("------------------------");
        }
        else
        {
            Menu.ShowErrorMessage("Гонка не была проведена!");
        }
    }
}