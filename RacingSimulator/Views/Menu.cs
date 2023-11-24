using RacingSimulator.Services;

namespace RacingSimulator.Views;

internal static partial class Menu
{
    internal static void Start()
    {
        MessageColor.Success("Добро пожаловать в симулятор гонок!");
        var raceType = GetRaceTypeFromConsole();
        var distance = GetDistanceFromConsole();

        var vehicles = raceType switch
        {
            1 => PrepareToStartGroundRace(),
            2 => PrepareStartAirRace(),
            3 => PrepareStartCommonRace(),
            _ => throw new ArgumentException("Тип гонки не найден!")
        };

        var race = new Race(vehicles, distance);
        race.Simulate();
        race.Result();
    }
}