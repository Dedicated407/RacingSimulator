using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Air;

/// <summary>
/// Летучий корабль
/// </summary>
internal sealed class FlyingShip : AirVehicle
{
    internal FlyingShip()
    {
        // TODO: обновить свойства
        Name = "Летучий корабль";
        Speed = 0_0;
        AccelerationCoefficient = 0_0;
    }

    internal override long Go(int distance)
    {
        throw new NotImplementedException();
    }
}