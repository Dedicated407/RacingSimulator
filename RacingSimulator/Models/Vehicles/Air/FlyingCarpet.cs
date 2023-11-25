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
        Speed = 2;
        AccelerationCoefficient = 2;
    }

    internal override long Go(short distance) => 
        distance / (Speed * (long)Math.Sqrt(distance) / AccelerationCoefficient);
}