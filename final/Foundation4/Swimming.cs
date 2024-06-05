using System;

public class Swimming : Activity
{
    private int _laps; // number of laps

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0; // Convert meters to kilometers
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _duration) * 60;
    }

    public override double GetPace()
    {
        return _duration / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Swimming ({_duration} min): Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}
