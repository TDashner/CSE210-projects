using System;

public abstract class Activity
{
    private DateTime _activityDate;
    private int _durationInMinutes;

    public DateTime ActivityDate
    {
        get {return _activityDate;}
        set{_activityDate = value;}
    }

    public int DurationInMinutes
    {
        get {return _durationInMinutes;}
        set{_durationInMinutes = value;}
    }



    public Activity(DateTime date, int duration)
    {
        _activityDate = date;
        _durationInMinutes = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{ActivityDate:dd MMM yyyy} {GetType().Name} ({DurationInMinutes} min) - " +
               $"Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
