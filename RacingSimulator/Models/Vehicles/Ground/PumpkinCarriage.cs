using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Ground;

/// <summary>
/// Карета-тыква
/// </summary>
internal sealed class PumpkinCarriage : GroundVehicle
{
    internal PumpkinCarriage()
    {
        // TODO: обновить свойства
        Name = "Карета-тыква";
        Speed = 0_0;
        TimeBeforeRest = 0_0;
        RestDuration = 0_0;
    }

    internal override long Go(int distance)
    {
        throw new NotImplementedException();
    }
}