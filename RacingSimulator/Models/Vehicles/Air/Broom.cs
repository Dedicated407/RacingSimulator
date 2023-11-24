using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Air;

/// <summary>
/// Метла
/// </summary>
internal sealed class Broom : AirVehicle
{
    internal Broom()
    {
        // TODO: обновить свойства
        Name = "Метла";
        Speed = 0_0;
        AccelerationCoefficient = 0_0;
    }

    internal override long Go(int distance)
    {
        throw new NotImplementedException();
    }
}