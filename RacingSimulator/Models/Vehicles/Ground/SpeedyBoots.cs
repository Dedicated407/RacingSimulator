using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Ground;

/// <summary>
/// Сапоги-скороходы
/// </summary>
internal sealed class SpeedyBoots : GroundVehicle
{
    public SpeedyBoots()
    {
        // TODO: обновить свойства
        Name = "Сапоги-скороходы";
        Speed = 0_0;
        TimeBeforeRest = 0_0;
        RestDuration = 0_0;
    }

    public override int Go(int distance)
    {
        throw new NotImplementedException();
    }
}