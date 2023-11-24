﻿using RacingSimulator.Models.Abstracts;

namespace RacingSimulator.Models.Vehicles.Air;

/// <summary>
/// Летучий корабль
/// </summary>
internal sealed class FlyingShip : AirVehicle
{
    internal FlyingShip()
    {
        Name = "Летучий корабль";
        Speed = 50;
        AccelerationCoefficient = 2;
    }

    internal override long Go(short distance) => 
        distance / Speed + (long)Math.Sqrt(distance) / (int)Math.Pow(AccelerationCoefficient, 2);
}