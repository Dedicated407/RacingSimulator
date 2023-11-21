using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Air;

/// <summary>
/// Ковер-самолет
/// </summary>
internal sealed class FlyingCarpet : AirVehicle
{
    public FlyingCarpet()
    {
        // TODO: обновить свойства
        Name = "Ковер-самолет";
        Speed = 0_0;
        AccelerationCoefficient = 0_0;
    }

    public override int Go(int distance)
    {
        throw new NotImplementedException();
    }
}