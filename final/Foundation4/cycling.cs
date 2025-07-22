// Cycling.cs
public class Cycling : Activity
{
    private double _avgSpeedKph;

    public Cycling(string date, int durationMin, double avgSpeedKph)
        : base(date, durationMin)
    {
        _avgSpeedKph = avgSpeedKph;
    }

    public override double GetDistance() => (_avgSpeedKph * GetDuration()) / 60;

    public override double GetSpeed()    => _avgSpeedKph;

    public override double GetPace()     => 60 / _avgSpeedKph;
}
