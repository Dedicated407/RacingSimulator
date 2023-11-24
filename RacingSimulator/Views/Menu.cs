using RacingSimulator.Models;
using RacingSimulator.Models.Abstracts;
using RacingSimulator.Services;

namespace RacingSimulator.Views;

internal static partial class Menu
{
    internal static void Start()
    {
        ShowSuccessMessage("Добро пожаловать в симулятор гонок!");
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

    private static IEnumerable<GroundVehicle> PrepareToStartGroundRace()
    {
        var vehicles = new List<GroundVehicle>();
        var freeVehicles = DataInitializer.InitGroundVehicles();

        while (true)
        {
            freeVehicles = freeVehicles
                .Except(vehicles.Select(x => x))
                .ToList();

            bool isInputValid;
            do
            {
                DisplayAvailableVehicles(freeVehicles);

                Console.WriteLine("Введите номер ТС, чтобы добавить его в заезд:");
                var input = Console.ReadLine();
                if (input?.ToLower() is "поехали")
                {
                    if (vehicles.Count is not 0)
                    {
                        return vehicles;
                    }

                    ShowErrorMessage("В гонке не зарегистрировано ни одно ТС!");
                    isInputValid = false;
                    continue;
                }

                isInputValid = int.TryParse(input, out var vehicleIndex);

                if (isInputValid && vehicleIndex < freeVehicles.Count)
                {
                    vehicles.Add(freeVehicles[vehicleIndex]);
                    freeVehicles.RemoveAt(vehicleIndex);
                }
                else
                {
                    isInputValid = false;
                    ShowErrorMessage("Данный ТС не найден!");
                }

                if (freeVehicles.Count is 0)
                {
                    return vehicles;
                }
            } while (!isInputValid);
        }
    }

    private static IEnumerable<AirVehicle> PrepareStartAirRace()
    {
        throw new NotImplementedException();
    }

    private static IEnumerable<Vehicle> PrepareStartCommonRace()
    {
        throw new NotImplementedException();
    }
}