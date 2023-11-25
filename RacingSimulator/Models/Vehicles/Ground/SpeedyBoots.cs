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
        Speed = 3;
        TimeBeforeRest = 50;
        RestDuration = 10;
    }

    internal override long Go(short distance)
    {
        var restCount = distance / Speed / TimeBeforeRest; // Количество остановок для отдыха
        var totalRestDuration = 0;

        for (var i = 1; i <= restCount; i++)
        {
            // Обратно пропорциональное увеличение времени отдыха
            totalRestDuration += RestDuration / i;
        }

        var time = distance / Speed;
        var totalTime = time is 0 ? 1 : time;
        const int timeToStart = 7;
        var totalTimeWithRest = totalTime + totalRestDuration + timeToStart;

        return totalTimeWithRest;
    }
}