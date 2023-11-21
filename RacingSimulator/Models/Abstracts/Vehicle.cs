namespace RacingSimulator.Models.Abstracts;

internal abstract class Vehicle
{
    /// <summary>
    /// Название ТС
    /// </summary>
    public string Name { get; protected init; }

    /// <summary>
    /// скорость движения (в условных единицах)
    /// </summary>
    public int Speed { get; protected init; }
}