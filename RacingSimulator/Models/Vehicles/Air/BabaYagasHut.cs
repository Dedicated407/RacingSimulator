using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Air;

/// <summary>
/// Ступа Бабы Яги
/// </summary>
internal sealed class BabaYagasHut : AirVehicle
{
    internal BabaYagasHut()
    {
        Name = "Ступа Бабы Яги";
        Speed = 20;
        AccelerationCoefficient = 4;
    }

    internal override long Go(short distance)
    {
        throw new NotImplementedException();
    }
}