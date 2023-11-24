using RacingSimulator.Models.Abstracts;
using RacingSimulator.Views;

namespace RacingSimulator.Services;

internal class Race
{
    private readonly List<Vehicle> _vehicles;
    private readonly short _distance;
    private Vehicle? _winner;

    internal Race(IEnumerable<Vehicle> vehicles, short distance)
    {
        _vehicles = new List<Vehicle>(vehicles);
        _distance = distance;
    }

    internal void Simulate()
    {
        Console.WriteLine("------------------------");
        MessageColor.Info("Время каждого участника:");
        var raceResult = _vehicles.OrderBy(vehicle =>
        {
            var timeResult = vehicle.Go(_distance);

            var timeSpan = TimeSpan.FromSeconds(timeResult);
            var totalDays = (int)timeSpan.TotalDays;
            var remainingTime = timeSpan.Subtract(TimeSpan.FromDays(totalDays));

            Console.WriteLine($"{vehicle.Name}: {totalDays} дней, {remainingTime:hh\\:mm\\:ss}");
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
            MessageColor.Error("Гонка не была проведена!");
        }
    }
}