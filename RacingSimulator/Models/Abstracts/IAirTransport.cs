namespace RacingSimulator.Models.Abstracts;

public interface IAirTransport
{
    /// <summary>
    /// скорость движения (в условных единицах)
    /// </summary>
    int Speed { get; }

    /// <summary>
    /// коэффициент ускорения (задается формулой, зависит от расстояния)
    /// </summary>
    int AccelerationCoefficient { get; }
}