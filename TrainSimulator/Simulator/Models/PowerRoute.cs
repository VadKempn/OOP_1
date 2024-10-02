namespace OOP_1.Simulator.Models
{
    public class PowerRoute : RouteSegment
    {
        private double _force;
        
        public PowerRoute(double lenght, double force) : base(lenght)
        {
            _force = force;
        }

        public override bool TryPass(Train train, out double time)
        {
            if (!train.AppliedForce(_force))
            {
                time = -1;
                return false;
            }

            time = train.CalculateTravelTime(Length, 0.1);
            return time >= 0;
        }
    }
}

