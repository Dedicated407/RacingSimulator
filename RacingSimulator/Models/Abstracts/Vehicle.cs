namespace RacingSimulator.Models.Abstracts;

public abstract class Vehicle
{
    /// <summary>
    /// Название ТС
    /// </summary>
    internal string Name { get; init; }

    /// <summary>
    /// скорость движения (в условных единицах)
    /// </summary>
    internal long Speed { get; init; }

    /// <summary>
    /// Время пути
    /// </summary>
    /// <param name="distance">Путь, который необходимо преодолеть</param>
    /// <returns>Время прохождения пути</returns>
    internal abstract long Go(int distance);
}