using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Ground;

/// <summary>
/// Избушка на курьих ножках
/// </summary>
internal sealed class HutOnChickenLegs : GroundVehicle
{
    public HutOnChickenLegs()
    {
        Name = "Избушка на курьих ножках";
        Speed = 20;
        TimeBeforeRest = 10;
        RestDuration = 30;
    }

    public override int Go(int distance)
    {
        var restCount = distance / Speed / TimeBeforeRest; // Количество остановок для отдыха
        var totalRestDuration = 0;

        for (var i = 1; i <= restCount; i++)
        {
            // Экспоненциальное увеличение времени отдыха
            totalRestDuration += (int)Math.Pow(RestDuration, i);
        }

        var totalTime = distance / Speed + 1;
        var totalTimeWithRest = totalTime + totalRestDuration;

        return totalTimeWithRest;
    }
}