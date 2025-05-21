class Journal
{
   public List<Entry> _journalEntries = new List<Entry>();

    public void Display()
    {
        foreach (Entry entry in _journalEntries)
        {
            Console.WriteLine($"displaying entry: {entry.DisplayEntry()}");
        }
    }
    public void AddJournal(Entry newEntry)
    {
        _journalEntries.Add(newEntry);
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _journalEntries)
            {
                writer.WriteLine(entry.FormatEntry());
            }
        }
    }

    public void RetrieveFromFile(string filename)
    {
       
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split("~");
                if (parts.Length == 3)
                {
                    string entryText = parts[0].Trim();
                    string date  = parts[1].Trim();
                    string prompt = parts[2].Trim();
                    Entry entry = new Entry(entryText, date, prompt);
                    _journalEntries.Add(entry);
                }
            }
    }
}