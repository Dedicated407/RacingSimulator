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
        Speed = 2;
        AccelerationCoefficient = 5;
    }

    internal override long Go(short distance)
    {
        var time = distance / (Speed * AccelerationCoefficient);
        var totalTime = time is 0 ? 1 : time;
        const int TimeToStart = 2;

        return totalTime + TimeToStart;
    }
}