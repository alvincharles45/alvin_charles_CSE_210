// Activity.cs
using System;

public class Activity
{
    private string _activityDate;
    private int    _durationMinutes;

    public Activity(string activityDate, int durationMinutes)
    {
        _activityDate    = activityDate;
        _durationMinutes = durationMinutes;
    }

    public int    GetDuration()            => _durationMinutes;
    public virtual double GetDistance()    => 0;
    public virtual double GetSpeed()       => 0;
    public virtual double GetPace()        => 0;

    public virtual string GetSummary()
    {
        // convert km → miles and kph → mph
        double miles      = GetDistance() * 0.621371;
        double mph        = GetSpeed()    * 0.621371;
        // pace in min/km → min/mile
        double pacePerMi  = GetPace()     / 0.621371;

        return $"{_activityDate} ({_durationMinutes} min): " +
               $"Distance {miles:0.0} miles, " +
               $"Speed    {mph:0.0} mph, " +
               $"Pace     {pacePerMi:0.0} min per mile";
    }
}
