using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Air;

/// <summary>
/// Ковер-самолет
/// </summary>
internal sealed class FlyingCarpet : AirVehicle
{
    internal FlyingCarpet()
    {
        // TODO: обновить свойства
        Name = "Ковер-самолет";
        Speed = 0_0;
        AccelerationCoefficient = 0_0;
    }

    internal override long Go(int distance)
    {
        throw new NotImplementedException();
    }
}