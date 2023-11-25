using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Ground;

/// <summary>
/// Избушка на курьих ножках
/// </summary>
internal sealed class HutOnChickenLegs : GroundVehicle
{
    internal HutOnChickenLegs()
    {
        Name = "Избушка на курьих ножках";
        Speed = 6;
        TimeBeforeRest = 40;
        RestDuration = 12;
    }

    internal override long Go(short distance)
    {
        var restCount = distance / TimeBeforeRest % Speed; // Количество остановок для отдыха
        long totalRestDuration = 0;

        for (var i = 1; i <= restCount; i++)
        {
            // Экспоненциальное увеличение времени отдыха
            totalRestDuration += (long)Math.Pow(RestDuration, i);
        }

        var time = distance / Speed;
        var totalTime = time is 0 ? 1 : time;
        const int timeToStart = 2;
        var totalTimeWithRest = totalTime + totalRestDuration + timeToStart;

        return totalTimeWithRest;
    }
}