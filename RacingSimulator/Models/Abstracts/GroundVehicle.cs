namespace RacingSimulator.Models.Abstracts;

internal abstract class GroundVehicle : Vehicle
{
    /// <summary>
    /// время движения до необходимого отдыха (в условных единицах)
    /// </summary>
    protected int TimeBeforeRest { get; init; }

    /// <summary>
    /// длительность отдыха, которая зависит от порядкового номера остановки (условных единицах)
    /// </summary>
    protected int RestDuration { get; init; }
}