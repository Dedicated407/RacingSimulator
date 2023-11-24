using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Air;

/// <summary>
/// Ступа Бабы Яги
/// </summary>
internal sealed class BabaYagasHut : AirVehicle
{
    internal BabaYagasHut()
    {
        // TODO: обновить свойства
        Name = "Ступа Бабы Яги";
        Speed = 0_0;
        AccelerationCoefficient = 0_0;
    }

    internal override long Go(int distance)
    {
        throw new NotImplementedException();
    }
}