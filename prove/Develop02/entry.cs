class Entry
{
    private string _entry;
    private string _date;

    private string _prompt;
   
   
    public Entry(string entry, string date, string prompt)
    {
        _entry = entry;
        _date = date;
        _prompt = prompt;
    }

    public string DisplayEntry()
    {
        return $"{_date} - {_prompt} - {_entry}";
    }

    public string FormatEntry()
    {
        return $"{_date} ~ {_prompt} ~ {_entry}";
    }
}