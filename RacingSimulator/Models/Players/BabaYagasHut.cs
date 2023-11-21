using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Players;

/// <summary>
/// Ступа Бабы Яги
/// </summary>
internal sealed class BabaYagasHut : IAirVehicle
{
    public int Speed { get; } = 4;

    public int AccelerationCoefficient { get; }

    public BabaYagasHut(int distance)
    {
        AccelerationCoefficient = distance * 20;
    }
}