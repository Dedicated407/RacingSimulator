using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Players;

/// <summary>
/// Ступа Бабы Яги
/// </summary>
internal sealed class BabaYagasHut : AirVehicle
{
    public int Speed { get; } = 4;

    public int AccelerationCoefficient { get; }

    public BabaYagasHut(int distance)
    {
        Name = "Ступа Бабы Яги";
        AccelerationCoefficient = distance * 20;
    }
}