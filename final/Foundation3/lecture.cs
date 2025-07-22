// Lecture.cs
public class Lecture : Event
{
    private string presenterName;
    private int    maxAttendees;

    public Lecture(string nameInput, string infoInput, string dateInput, string timeInput, Address venueInput,
                   string presenterInput, int attendeesInput)
        : base(nameInput, infoInput, dateInput, timeInput, venueInput)
    {
        presenterName = presenterInput;
        maxAttendees  = attendeesInput;
    }

    public override string GetFullDetails()
    {
        return $"{ShowBasicInfo()}\nType: Lecture\nPresenter: {presenterName}\nCapacity: {maxAttendees}";
    }

    public override string GetBriefInfo()
    {
        return $"Lecture - {base.GetBriefInfo()}";
    }
}
