using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Air;

/// <summary>
/// Метла
/// </summary>
internal sealed class Broom : AirVehicle
{
    public Broom(int distance)
    {
        // TODO: обновить свойства
        Name = "Метла";
        Speed = 0_0;
        AccelerationCoefficient = 0_0;
    }

    public override int Go(int distance)
    {
        throw new NotImplementedException();
    }
}