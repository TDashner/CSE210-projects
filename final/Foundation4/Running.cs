using System;

public class Running : Activity
{
    private double _distanceInMiles;

    public double DistanceInMiles
    {
        get {return _distanceInMiles;}
        set{_distanceInMiles = value;}
    }



    public Running(DateTime date, int duration, double distanceInMiles)
        : base(date, duration)
    {
        _distanceInMiles = distanceInMiles;
    }

    public override double GetDistance()
    {
        return _distanceInMiles;
    }

    public override double GetSpeed()
    {
        return (_distanceInMiles / DurationInMinutes) * 60;
    }

    public override double GetPace()
    {
        return DurationInMinutes / _distanceInMiles;
    }
}
