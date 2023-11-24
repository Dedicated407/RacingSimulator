namespace RacingSimulator.Models.Abstracts;

internal abstract class GroundVehicle : Vehicle
{
    /// <summary>
    /// время движения до необходимого отдыха (в условных единицах)
    /// </summary>
    internal int TimeBeforeRest { get; init; }

    /// <summary>
    /// длительность отдыха, которая зависит от порядкового номера остановки (условных единицах)
    /// </summary>
    internal int RestDuration { get; init; }
}