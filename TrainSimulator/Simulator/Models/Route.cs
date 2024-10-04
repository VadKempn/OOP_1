using System.Diagnostics.CodeAnalysis;

namespace OOP_1.Simulator.Models;

public class Route
{
    private readonly IReadOnlyList<RouteSegment> _segments;
    private readonly double _speedLimit;

    public Route(IEnumerable<RouteSegment> segments, double speedLimit)
    {
        ArgumentNullException.ThrowIfNull(segments);
        _segments = segments.ToList();
        _speedLimit = speedLimit;
    }

    public bool TryComplete(Train train,[NotNullWhen(true)] out double? totalTime)
    {
        ArgumentNullException.ThrowIfNull(train);
        
        totalTime = 0;

        foreach (var segment in _segments)
        {
            if (!segment.TryPass(train, out var segmentTime))
            {
                totalTime = null;
                return false;
            }

            totalTime += segmentTime;
        }

        if (train.Speed > _speedLimit)
        {
            totalTime = null;
            return false;
        }
        return true;
    }
}