using RacingSimulator.Models.Abstracts;
using RacingSimulator.Models.Players;

namespace RacingSimulator.Views;

public static partial class Menu
{
    private static List<GroundVehicle> InitGroundVehicle()
    {
        return new List<GroundVehicle>
        {
            new Centaur(),
            new HutOnChickenLegs(),
            new PumpkinCarriage(),
            new SpeedyBoots()
        };
    }
}