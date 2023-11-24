namespace RacingSimulator.Models.Abstracts;

internal abstract class AirVehicle : Vehicle
{
    /// <summary>
    /// коэффициент ускорения (задается формулой, зависит от расстояния)
    /// </summary>
    internal int AccelerationCoefficient { get; init; }
}