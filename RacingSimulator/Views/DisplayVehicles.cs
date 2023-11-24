using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Views;

internal static partial class Menu
{
    private static void DisplayAvailableVehicles(IReadOnlyList<Vehicle> vehicles)
    {
        Console.WriteLine("------------------------");
        MessageColor.Info("Доступные ТС для заезда:");
        for (var i = 0; i < vehicles.Count; i++)
        {
            Console.WriteLine($"{i}. {vehicles[i].Name}");
        }

        MessageColor.Success("Для начала гонки введите: поехали");
        Console.WriteLine("------------------------");
    }
}