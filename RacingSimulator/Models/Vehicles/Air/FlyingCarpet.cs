using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Air;

/// <summary>
/// Ковер-самолет
/// </summary>
internal sealed class FlyingCarpet : AirVehicle
{
    internal FlyingCarpet()
    {
        Name = "Ковер-самолет";
        Speed = 22;
        AccelerationCoefficient = 6;
    }

    internal override long Go(short distance)
    {
        throw new NotImplementedException();
    }
}