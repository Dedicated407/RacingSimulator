using RacingSimulator.Models;
using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Views;

public partial class Menu
{
    public void Start()
    {
        Console.WriteLine("Добро пожаловать в симулятор гонок!");
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
    }

    private IEnumerable<GroundVehicle> PrepareToStartGroundRace()
    {
        var vehicles = new List<GroundVehicle>();
        var freeVehicles = InitGroundVehicle();

        while (true)
        {
            freeVehicles = freeVehicles
                .Except(vehicles.Select(x => x))
                .ToList();
            DisplayAvailableVehicles(freeVehicles);

            var input = Console.ReadLine();
            if (input == "поехали")
            {
                break;
            }

            bool isInputValid;
            do
            {
                Console.WriteLine("Введите номер ТС, чтобы добавить его в заезд:");
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
                    input = Console.ReadLine();
                }
            } while (!isInputValid);
        }

        return vehicles;
    }

    private IEnumerable<AirVehicle> PrepareStartAirRace()
    {
        throw new NotImplementedException();
    }

    private IEnumerable<Vehicle> PrepareStartCommonRace()
    {
        throw new NotImplementedException();
    }

    private static void DisplayAvailableVehicles(IReadOnlyList<Vehicle> vehicles)
    {
        Console.WriteLine("Доступные ТС для заезда:");
        for (var i = 0; i < vehicles.Count; i++)
        {
            Console.WriteLine($"{i}. {vehicles[i].Name}");
        }
        Console.WriteLine("Для начала гонки введите: поехали");
    }
}