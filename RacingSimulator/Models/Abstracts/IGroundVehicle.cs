namespace RacingSimulator.Models.Abstracts;

internal abstract class GroundVehicle : Vehicle
{
    /// <summary>
    /// время движения до необходимого отдыха (в условных единицах)
    /// </summary>
    public int TimeBeforeRest { get; protected init; }

    /// <summary>
    /// длительность отдыха, которая зависит от порядкового номера остановки (условных единицах)
    /// </summary>
    public int RestDuration { get; protected init; }
}