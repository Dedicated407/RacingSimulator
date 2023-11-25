using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Air;

/// <summary>
/// Ступа Бабы Яги
/// </summary>
internal sealed class BabaYagasHut : AirVehicle
{
    internal BabaYagasHut()
    {
        Name = "Ступа Бабы Яги";
        Speed = 2;
        AccelerationCoefficient = 4;
    }

    internal override long Go(short distance)
    {
        var time = distance / Speed * (AccelerationCoefficient + (long)Math.Log(distance));
        var totalTime = time is 0 ? 1 : time;
        const int timeToStart = 1;

        return totalTime + timeToStart;
    }
}