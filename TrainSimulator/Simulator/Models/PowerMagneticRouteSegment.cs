using System.Diagnostics.CodeAnalysis;

namespace OOP_1.Simulator.Models
{
    public class PowerMagneticRouteSegment : MagneticRouteSegment
    {
        private readonly double _force;
        
        
        public PowerMagneticRouteSegment(double length, double force) : base(length)
        {
            _force = force;
        }

        public override bool TryPass(Train train, [NotNullWhen(true)] out double? time)
        {
            ArgumentNullException.ThrowIfNull(train);
            if (!train.TryApplyForce(_force))
            {
                time = null;
                return false;
            }

            return base.TryPass(train, out time);
        }
    }
}

