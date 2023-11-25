using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Air;

/// <summary>
/// Летучий корабль
/// </summary>
internal sealed class FlyingShip : AirVehicle
{
    internal FlyingShip()
    {
        Name = "Летучий корабль";
        Speed = 2;
        AccelerationCoefficient = 2;
    }

    internal override long Go(short distance)
    {
        var time = distance / Speed + (long)Math.Sqrt(distance) / (int)Math.Pow(AccelerationCoefficient, 2);
        var totalTime = time is 0 ? 1 : time;
        const int timeToStart = 5;

        return totalTime + timeToStart;
    }
}