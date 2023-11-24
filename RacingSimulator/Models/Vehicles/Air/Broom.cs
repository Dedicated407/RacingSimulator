using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Air;

/// <summary>
/// Метла
/// </summary>
internal sealed class Broom : AirVehicle
{
    internal Broom()
    {
        Name = "Метла";
        Speed = 25;
        AccelerationCoefficient = 5;
    }

    internal override long Go(short distance) => 
        distance / (Speed * AccelerationCoefficient) + 1; // При условии если distance очень маленькое :-)))
}