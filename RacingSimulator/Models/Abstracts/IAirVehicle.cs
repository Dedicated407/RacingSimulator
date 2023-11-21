namespace RacingSimulator.Models.Abstracts;

public interface IAirVehicle : IVehicle
{
    /// <summary>
    /// коэффициент ускорения (задается формулой, зависит от расстояния)
    /// </summary>
    int AccelerationCoefficient { get; }
}