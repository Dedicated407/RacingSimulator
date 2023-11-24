using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Ground;

/// <summary>
/// Карета-тыква
/// </summary>
internal sealed class PumpkinCarriage : GroundVehicle
{
    internal PumpkinCarriage()
    {
        Name = "Карета-тыква";
        Speed = 15;
        TimeBeforeRest = 5;
        RestDuration = 10;
    }

    internal override long Go(short distance)
    {
        var restCount = distance / Speed / TimeBeforeRest; // Количество остановок для отдыха
        var totalRestDuration = 0;

        for (var i = 1; i <= restCount; i++)
        {
            // Квадратичное увеличение времени отдыха
            totalRestDuration += RestDuration * i * i;
        }

        var totalTime = distance / Speed;
        var totalTimeWithRest = totalTime + totalRestDuration;

        return totalTimeWithRest;
    }
}