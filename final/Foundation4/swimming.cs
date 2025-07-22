// Swimming.cs
public class Swimming : Activity
{
    private int _lapCount;

    public Swimming(string date, int durationMin, int lapCount)
        : base(date, durationMin)
    {
        _lapCount = lapCount;
    }

    public override double GetDistance() => (_lapCount * 50) / 1000.0;

    public override double GetSpeed()    => (GetDistance() / GetDuration()) * 60;

    public override double GetPace()     => GetDuration() / GetDistance();
}
