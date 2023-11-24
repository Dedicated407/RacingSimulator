using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Ground;

/// <summary>
/// Сапоги-скороходы
/// </summary>
internal sealed class SpeedyBoots : GroundVehicle
{
    internal SpeedyBoots()
    {
        Name = "Сапоги-скороходы";
        Speed = 8;
        TimeBeforeRest = 100;
        RestDuration = 10;
    }

    internal override long Go(int distance)
    {
        var restCount = distance / Speed / TimeBeforeRest; // Количество остановок для отдыха
        var totalRestDuration = 0;

        for (var i = 1; i <= restCount; i++)
        {
            // Обратно пропорциональное увеличение времени отдыха
            totalRestDuration += RestDuration / i;
        }

        var totalTime = distance / Speed;
        var totalTimeWithRest = totalTime + totalRestDuration;

        return totalTimeWithRest;
    }
}