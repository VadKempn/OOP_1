using System.Diagnostics.CodeAnalysis;

namespace OOP_1.Simulator.Models;

public abstract class RouteSegment
{
    public abstract bool TryPass(Train train, [NotNullWhen(true)] out double? time);
}