namespace RacingSimulator.Models.Abstracts;

public interface IGroundVehicle : IVehicle
{
    /// <summary>
    /// время движения до необходимого отдыха (в условных единицах)
    /// </summary>
    int TimeBeforeRest { get; }

    /// <summary>
    /// длительность отдыха, которая зависит от порядкового номера остановки (условных единицах)
    /// </summary>
    int RestDuration { get; }
}