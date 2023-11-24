using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Air;

/// <summary>
/// Ступа Бабы Яги
/// </summary>
internal sealed class BabaYagasHut : AirVehicle
{
    public BabaYagasHut()
    {
        // TODO: обновить свойства
        Name = "Ступа Бабы Яги";
        Speed = 0_0;
        AccelerationCoefficient = 0_0;
    }

    public override int Go(int distance)
    {
        throw new NotImplementedException();
    }
}