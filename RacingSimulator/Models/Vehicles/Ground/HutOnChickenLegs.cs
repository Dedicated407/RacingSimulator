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
        Speed = 20;
        TimeBeforeRest = 10;
        RestDuration = 30;
    }

    internal override long Go(int distance)
    {
        var restCount = distance / Speed / TimeBeforeRest; // Количество остановок для отдыха
        long totalRestDuration = 0;

        for (var i = 1; i <= restCount; i++)
        {
            // Экспоненциальное увеличение времени отдыха
            totalRestDuration += (long)Math.Pow(RestDuration, i);
        }

        var totalTime = distance / Speed;
        var totalTimeWithRest = totalTime + totalRestDuration;

        return totalTimeWithRest;
    }
}