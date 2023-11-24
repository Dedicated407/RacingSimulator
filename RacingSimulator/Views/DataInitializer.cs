using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Views;

public static partial class Menu
{
    private static void DisplayAvailableVehicles(IReadOnlyList<Vehicle> vehicles)
    {
        Console.WriteLine("------------------------");
        ShowInfoMessage("Доступные ТС для заезда:");
        for (var i = 0; i < vehicles.Count; i++)
        {
            Console.WriteLine($"{i}. {vehicles[i].Name}");
        }

        ShowSuccessMessage("Для начала гонки введите: поехали");
        Console.WriteLine("------------------------");
    }
}