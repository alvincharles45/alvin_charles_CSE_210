class Scripture

{
    private string _reference;
    private string _verse;

    private Reference _ref;

    private List<Word> _words = new List<Word>();

    public Scripture()
    {
        _reference = "Proverbs 3:5-6";
        _verse = "5 Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6 In all thy ways acknowledge him, and he shall direct thy paths.";
        string[] parts = Reference.textsplitter(_reference);
        _ref = new Reference(parts[0], parts[1], parts[2], parts[3]);

        foreach (string word in _verse.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }
    public void DisplayScripture()
    {
        Console.WriteLine($"Reference: {_reference}");
        Console.WriteLine("Verse:");
        foreach (Word word in _words)
        {
            Console.Write(word.GetText() + " ");
        }
        Console.WriteLine();
    }

    public bool HideWords(int numberOfWords)
    {
        if (AllHidden())
        {
            return false;
        }
        Random random = new Random();
        int count = 0;

        while (count < numberOfWords)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
            }
            count++;
        } 

        return true;
    }
    
    public bool AllHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}