using System.Diagnostics.CodeAnalysis;

namespace OOP_1.Simulator.Models
{
    public class Station : RouteSegment
    {
        private readonly double _speedLimit;
        private readonly double _waitingTime;

        public Station(double speedLimit, double waitingTime)
        {
            _speedLimit = speedLimit;
            _waitingTime = waitingTime;
        }

        public override bool TryPass(Train train, [NotNullWhen(true)] out double? time)
        {
            ArgumentNullException.ThrowIfNull(train);
            time = train.Speed > _speedLimit
                ? null
                : _waitingTime;
            return time != null;
        }
    }
}