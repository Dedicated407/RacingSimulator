using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Players;

/// <summary>
/// Ступа Бабы Яги
/// </summary>
internal sealed class BabaYagasHut : IGroundTransport
{
    private const int TimeRecovery = 20;

    public int Speed { get; } = 4;

    public int TimeBeforeRest { get; } = 15;

    public int RestDuration { get; }

    public BabaYagasHut(int numberOfStops)
    {
        RestDuration = numberOfStops * TimeRecovery;
    }
}