namespace OOP_1.Simulator.Models;

public abstract class RouteSegment
{
        public double Length { get; }

        protected RouteSegment(double length)
        {
            Length = length;
        }

        public abstract bool TryPass(Train train, out double time);
}