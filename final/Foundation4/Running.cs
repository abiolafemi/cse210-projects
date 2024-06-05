using System;

public class Running : Activity
{
    private double _distance; // in kilometers

    public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _duration) * 60;
    }

    public override double GetPace()
    {
        return _duration / _distance;
    }

    public override string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Running ({_duration} min): Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}
