namespace OOP_1.Simulator.Models;

public class Train
{
    public double Weight { get; private set; }
    public double Speed { get; private set; }
    public double Boost { get; private set; }
    public double MaxPermissibleForce { get; private set; }

    public Train(double weight, double maxPermissibleForce, double startValueOfSpeed = 0, double startValueOfBoost = 0)
    {
        Weight = weight;
        MaxPermissibleForce = maxPermissibleForce;
        Speed = startValueOfSpeed;
        Boost = startValueOfBoost;

    }

    public bool AppliedForce(double forse)
    {
        if (forse > MaxPermissibleForce)
            return false;

        Boost = forse / Weight;
        return true;
    }
    
        

    public double CalculateTravelTime(double distance, double precision, double countTime = 0)
    {
        double time = countTime;
        double remainingDistance = distance;

        while (remainingDistance >= 0)
        {
            Speed += Boost * precision;
            double traveled = Speed * precision;
            remainingDistance -= traveled;
            time += precision;

            if ((Speed < 0) || (Speed == 0 && Boost == 0))
                return -1;

        }

        return time;
    }
}