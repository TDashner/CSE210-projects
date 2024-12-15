using System;

public class Cycling : Activity
{
    private double _speedInMph;

    public double SpeedInMph
    {
        get {return _speedInMph;}
        set{_speedInMph = value;}
    }



    public Cycling(DateTime date, int duration, double speedInMph)
        : base(date, duration)
    {
        _speedInMph = speedInMph;
    }

    public override double GetDistance()
    {
        return (_speedInMph * DurationInMinutes) / 60;
    }

    public override double GetSpeed()
    {
        return _speedInMph;
    }

    public override double GetPace()
    {
        return 60 / _speedInMph;
    }
}
