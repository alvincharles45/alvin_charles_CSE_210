// Event.cs
using System;

public class Event
{
    private string eventName;
    private string eventInfo;
    private string eventDate;
    private string eventTime;
    private Address venue;

    public Event(string nameInput, string infoInput, string dateInput, string timeInput, Address venueInput)
    {
        eventName  = nameInput;
        eventInfo  = infoInput;
        eventDate  = dateInput;
        eventTime  = timeInput;
        venue      = venueInput;
    }

    public virtual string ShowBasicInfo()
    {
        return $"{eventName}\n{eventInfo}\nDate: {eventDate}\nTime: {eventTime}\nVenue: {venue.FormatAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return ShowBasicInfo();
    }

    public virtual string GetBriefInfo()
    {
        return $"{eventName} on {eventDate}";
    }
}
