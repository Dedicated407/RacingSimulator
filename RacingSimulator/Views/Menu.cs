using RacingSimulator.Models;
using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Views;

public class Menu
{
    public void Start()
    {
        Console.WriteLine("Добро пожаловать в симулятор гонок!");
        var distance = GetDistanceFromConsole();

        switch (GetRaceTypeFromConsole())
        {
            case 1:
                StartGroundRace(distance);
                break;
            case 2:
                StartAirRace();
                break;
            case 3:
                StartRace();
                break;
        }
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

    private void StartGroundRace(int distance)
    {
        var racers = new List<IGroundVehicle>();
        
    }

    private void StartAirRace()
    {
        
    }

    private void StartRace()
    {
        
    }
}