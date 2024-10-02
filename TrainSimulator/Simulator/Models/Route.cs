namespace OOP_1.Simulator.Models
{
    public class Route : RouteSegment
    {
        public Route(double lenght) : base(lenght)
        {
        }

        public override bool TryPass(Train train, out double time)
        {
            time = train.CalculateTravelTime(Length, 0.1);
            return time >= 0;
        }
    }
}