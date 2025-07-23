// OutdoorGathering.cs
public class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string nameInput, string infoInput, string dateInput, string timeInput, Address venueInput,
                            string forecastInput)
        : base(nameInput, infoInput, dateInput, timeInput, venueInput)
    {
        weatherForecast = forecastInput;
    }

    public override string GetFullDetails()
    {
        return $"{ShowBasicInfo()}\nType: Outdoor Gathering\nWeather: {weatherForecast}";
    }

    public override string GetBriefInfo()
    {
        return $"Outdoor Gathering - {base.GetBriefInfo()}";
    }
}
