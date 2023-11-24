using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Air;

/// <summary>
/// Метла
/// </summary>
internal sealed class Broom : AirVehicle
{
    internal Broom()
    {
        Name = "Метла";
        Speed = 25;
        AccelerationCoefficient = 5;
    }

    internal override long Go(short distance)
    {
        throw new NotImplementedException();
    }
}