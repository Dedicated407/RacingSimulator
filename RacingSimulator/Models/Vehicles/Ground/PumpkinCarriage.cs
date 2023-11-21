using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Ground;

/// <summary>
/// Карета-тыква
/// </summary>
internal sealed class PumpkinCarriage : GroundVehicle
{
    public PumpkinCarriage()
    {
        // TODO: обновить свойства
        Name = "Карета-тыква";
        Speed = 0_0;
        TimeBeforeRest = 0_0;
        RestDuration = 0_0;
    }

    public override int Go(int distance)
    {
        throw new NotImplementedException();
    }
}