using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Players;

/// <summary>
/// Метла
/// </summary>
internal sealed class Broom : IAirVehicle
{
    public int Speed { get; } = 15;

    public int AccelerationCoefficient { get; }

    public Broom(int distance)
    {
        AccelerationCoefficient = distance / 20;
    }
}