namespace RacingSimulator.Models.Abstracts;

public interface IVehicle
{
    /// <summary>
    /// скорость движения (в условных единицах)
    /// </summary>
    int Speed { get; }
}