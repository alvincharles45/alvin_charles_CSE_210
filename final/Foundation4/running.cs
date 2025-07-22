// Running.cs
public class Running : Activity
{
    private double _distanceKm;

    public Running(string date, int durationMin, double distanceKm)
        : base(date, durationMin)
    {
        _distanceKm = distanceKm;
    }

    public override double GetDistance() => _distanceKm;

    public override double GetSpeed()    => (_distanceKm / GetDuration()) * 60;

    public override double GetPace()     => GetDuration() / _distanceKm;
}
