using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Ground;

/// <summary>
/// Кентавр
/// </summary>
internal sealed class Centaur : GroundVehicle
{
    internal Centaur()
    {
        Name = "Кентавр";
        Speed = 2;
        TimeBeforeRest = 2;
        RestDuration = 15;
    }

    internal override long Go(short distance)
    {
        var restCount = distance / Speed / TimeBeforeRest; // Количество остановок для отдыха
        var totalRestDuration = 0;

        for (var i = 1; i <= restCount; i++)
        {
            // Общая длительность отдыха, зависящая от порядкового номера остановки (линейная зависимость)
            totalRestDuration += RestDuration * i;
        }

        var time = distance / Speed;
        var totalTime = time is 0 ? 1 : time;
        const int timeToStart = 1;
        var totalTimeWithRest = totalTime + totalRestDuration + timeToStart;

        return totalTimeWithRest;
    }
}