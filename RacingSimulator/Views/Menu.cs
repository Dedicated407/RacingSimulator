using RacingSimulator.Models;
using RacingSimulator.Models.Abstracts;
using RacingSimulator.Models.Players;

namespace RacingSimulator.Views;

public class Menu
{
    public void Start()
    {
        Console.WriteLine("Добро пожаловать в симулятор гонок!");
        var distance = GetDistanceFromConsole();
        List<Vehicle> vehicles;

        switch (GetRaceTypeFromConsole())
        {
            case 1:
                vehicles = new List<Vehicle>(PrepareToStartGroundRace());
                break;
            case 2:
                vehicles = new List<Vehicle>(PrepareStartAirRace());
                break;
            case 3:
                vehicles = new List<Vehicle>(PrepareStartCommonRace());
                break;
            default:
                throw new ArgumentException("Тип гонки не найден!");
        }

        StartRace(vehicles, distance);
    }

    private static int GetRaceTypeFromConsole()
    {
        int raceType;
        bool isRaceTypeValid;

        do
        {
            Console.WriteLine("Выберите желаемый тип гонки (введите цифру):\n1. Наземная;\n2. Воздушная;\n3. Для всех.");
            isRaceTypeValid = int.TryParse(Console.ReadLine(), out raceType);

            if (!Enum.IsDefined(typeof(RaceTypeEnum), raceType) || !isRaceTypeValid)
            {
                isRaceTypeValid = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new ArgumentException("Тип гонки не найден!", nameof(raceType)));
                Console.ResetColor();
            }
        } while (!isRaceTypeValid);

        return raceType;
    }

    private static int GetDistanceFromConsole()
    {
        int distance;
        bool isParseDistanceValid;

        do
        {
            Console.WriteLine("Введите дистанцию гонки:");
            isParseDistanceValid = int.TryParse(Console.ReadLine(), out distance);
            if (!isParseDistanceValid)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new ArgumentException("Неверно указана дистанция!", nameof(distance)));
                Console.ResetColor();
            }
        } while (!isParseDistanceValid);

        return distance;
    }

    private static List<GroundVehicle> InitGroundVehicle()
    {
        return new List<GroundVehicle>
        {
            new Centaur(),
            new HutOnChickenLegs(),
            new PumpkinCarriage(),
            new SpeedyBoots()
        };
    }

    private IEnumerable<GroundVehicle> PrepareToStartGroundRace()
    {
        var vehicles = new List<GroundVehicle>();
        var freeVehicles = InitGroundVehicle();

        while (true)
        {
            Console.WriteLine("Доступные ТС для заезда:");
            freeVehicles = freeVehicles
                .Except(vehicles.Select(x => x))
                .ToList();
            for (var i = 0; i < freeVehicles.Count; i++)
            {
                Console.WriteLine($"{i}. {freeVehicles[i].Name}");
            }
            Console.WriteLine("Для начала гонки введите: поехали");

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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(new ArgumentException("Данный ТС не найден!", nameof(vehicleIndex)));
                    Console.ResetColor();
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

    private void StartRace(List<Vehicle> vehicles, int distance)
    {
        
    }
}