using System.Diagnostics.CodeAnalysis;

namespace OOP_1.Simulator.Models;

public class MagneticRouteSegment : RouteSegment
{
    private readonly double _length;
    public MagneticRouteSegment(double length)
    {
        _length = length;
    }

    public override bool TryPass(Train train, [NotNullWhen(true)] out double? time)
    {
        ArgumentNullException.ThrowIfNull(train);
        time = train.CalculateTravelTime(_length);
        return time != null;
    }
}
