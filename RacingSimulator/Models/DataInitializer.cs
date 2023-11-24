using RacingSimulator.Models.Abstracts;
using RacingSimulator.Models.Vehicles.Air;
using RacingSimulator.Models.Vehicles.Ground;

namespace RacingSimulator.Models;

internal static class DataInitializer
{
    internal static List<GroundVehicle> InitGroundVehicles() => new()
    {
        new Centaur(),
        new HutOnChickenLegs(),
        new PumpkinCarriage(),
        new SpeedyBoots()
    };

    internal static List<AirVehicle> InitAirVehicles() => new()
    {
        new BabaYagasHut(),
        new Broom(),
        new FlyingCarpet(),
        new FlyingShip()
    };
}