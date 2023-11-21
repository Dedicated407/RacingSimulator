using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Players;

/// <summary>
/// Метла
/// </summary>
internal sealed class Broom : AirVehicle
{
    public int Speed { get; } = 15;

    public int AccelerationCoefficient { get; }

    public Broom(int distance)
    {
        Name = "Метла";
        AccelerationCoefficient = distance / 20;
    }
}