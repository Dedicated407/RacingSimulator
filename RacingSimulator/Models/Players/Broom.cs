using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Players;

/// <summary>
/// Метла
/// </summary>
public class Broom : IAirTransport
{
    public int Speed { get; } = 15;

    public int AccelerationCoefficient { get; }

    public Broom(int distance)
    {
        AccelerationCoefficient = distance / 20;
    }
}