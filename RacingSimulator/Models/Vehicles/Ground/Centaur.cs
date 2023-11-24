﻿using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Ground;

/// <summary>
/// Кентавр
/// </summary>
internal sealed class Centaur : GroundVehicle
{
    public Centaur()
    {
        Name = "Кентавр";
        Speed = 10;
        TimeBeforeRest = 2;
        RestDuration = 15;
    }

    public override int Go(int distance)
    {
        var restCount = distance / Speed / TimeBeforeRest; // Количество остановок для отдыха
        var totalRestDuration = 0;

        for (var i = 1; i <= restCount; i++)
        {
            // Общая длительность отдыха, зависящая от порядкового номера остановки
            totalRestDuration += RestDuration * i;
        }

        var totalTime = distance / Speed + 1;
        var totalTimeWithRest = totalTime + totalRestDuration;

        return totalTimeWithRest;
    }
}