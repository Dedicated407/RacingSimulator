using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Air;

/// <summary>
/// Летучий корабль
/// </summary>
internal sealed class FlyingShip : AirVehicle
{
    public FlyingShip()
    {
        // TODO: обновить свойства
        Name = "Летучий корабль";
        Speed = 0_0;
        AccelerationCoefficient = 0_0;
    }

    public override int Go(int distance)
    {
        throw new NotImplementedException();
    }
}