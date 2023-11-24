using RacingSimulator.Models;
using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Views;

internal static partial class Menu
{
    private static IEnumerable<AirVehicle> PrepareStartAirRace() =>
        PrepareToStartRace(DataInitializer.InitAirVehicles());

    private static IEnumerable<GroundVehicle> PrepareToStartGroundRace() => 
        PrepareToStartRace(DataInitializer.InitGroundVehicles());

    private static IEnumerable<Vehicle> PrepareStartCommonRace() =>
        PrepareToStartRace(
            DataInitializer.InitAirVehicles()
                .Concat(DataInitializer.InitGroundVehicles().Cast<Vehicle>())
        );

    private static IEnumerable<T> PrepareToStartRace<T>(IEnumerable<T> vehiclesList) where T : Vehicle
    {
        var vehicles = new List<T>();
        var freeVehicles = vehiclesList.ToList();

        while (freeVehicles.Any())
        { 
            DisplayAvailableVehicles(freeVehicles);

            Console.WriteLine("Введите номер ТС, чтобы добавить его в заезд:");
            var input = Console.ReadLine();
            if (input?.ToLower() is "поехали")
            {
                if (vehicles.Any())
                {
                    return vehicles;
                }

                MessageColor.Error("В гонке не зарегистрировано ни одно ТС!");
                continue;
            }

            if (!int.TryParse(input, out var vehicleIndex) || 
                vehicleIndex >= freeVehicles.Count ||
                vehicleIndex < 0)
            {
                MessageColor.Error("Данный ТС не найден!");
                continue;
            }

            vehicles.Add(freeVehicles[vehicleIndex]);
            freeVehicles.RemoveAt(vehicleIndex);
        }

        return vehicles;
    }
}