namespace RacingSimulator.Models.Abstracts;

public interface IAirTransport
{
    int Speed { get; }
    int AccelerationCoefficient { get; }
}