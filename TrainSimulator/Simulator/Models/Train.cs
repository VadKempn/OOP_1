namespace OOP_1.Simulator.Models;

public class Train
{
    public double Weight { get; set; }
    public double Speed { get; private set; }
    public double Boost { get; set; }
    public double MaxPermissibleForce { get; set; }


    public Train(double weight, double maxPermissibleForce, double startValueOfSpeed = 0, double startValueOfBoost = 0)
    {
        Weight = weight;
        MaxPermissibleForce = maxPermissibleForce;
        Speed = startValueOfSpeed;
        Boost = startValueOfBoost;
    }

    public bool TryApplyForce(double force)
    {
        if (force > MaxPermissibleForce)
            return false;

        Boost = force / Weight;
        return true;
    }

    public double? CalculateTravelTime(double distance, double precision = 0.1)
    {
        double time = 0;
        double passedDistance = 0;

        while (passedDistance < distance)
        {
            Speed += Boost * precision;
            passedDistance += Speed * precision;
            time += precision;

            if ((Speed < 0) || (Speed == 0 && Boost <= 0))
                return null;
        }

        return time;
    }
}