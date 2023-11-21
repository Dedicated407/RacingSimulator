namespace RacingSimulator.Models.Abstracts;

public abstract class Vehicle
{
    /// <summary>
    /// Название ТС
    /// </summary>
    public string Name { get; protected init; }

    /// <summary>
    /// скорость движения (в условных единицах)
    /// </summary>
    protected int Speed { get; init; }

    /// <summary>
    /// Время пути
    /// </summary>
    /// <param name="distance">Путь, который необходимо преодолеть</param>
    /// <returns>Время прохождения пути</returns>
    public abstract int Go(int distance);
}