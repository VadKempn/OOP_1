namespace OOP_1.Simulator.Models
{
    public class Station : RouteSegment
    {
        private double _limitHighSpeedModuls;
        
        public Station(double lenght, double limitHighSpeedModuls) : base(lenght)
        {
            _limitHighSpeedModuls = limitHighSpeedModuls;
        }

        public override bool TryPass(Train train, out double time)
        {
            if (train.Speed > _limitHighSpeedModuls)
            {
                time = -1;
                return false;
            }
            time = train.CalculateTravelTime(Length, 0.1) + 1;
            return time >= 0;
        }
            
    }
}
