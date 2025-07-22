// Reception.cs
public class Reception : Event
{
    private string contactEmail;

    public Reception(string nameInput, string infoInput, string dateInput, string timeInput, Address venueInput,
                     string emailInput)
        : base(nameInput, infoInput, dateInput, timeInput, venueInput)
    {
        contactEmail = emailInput;
    }

    public override string GetFullDetails()
    {
        return $"{ShowBasicInfo()}\nType: Reception\nContact: {contactEmail}";
    }

    public override string GetBriefInfo()
    {
        return $"Reception - {base.GetBriefInfo()}";
    }
}
