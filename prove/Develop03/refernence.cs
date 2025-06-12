class Reference

{
    private string _book;
    private string _chno;

    private string _startverse;
    private string _endverse;

    public Reference(string book, string chno, string startverse, string endverse)
    {
        _book = book;
        _chno = chno;
        _startverse = startverse;
        _endverse = endverse;

    }


    public Reference(string book, string chno, string startverse)
    {
        _book = book;
        _chno = chno;
        _startverse = startverse;

    }

    public static string[] textsplitter(string text)
    {
        string[] splitText = text.Split(':');
        int lastSpace = splitText[0].LastIndexOf(' ');
        string book = splitText[0].Substring(0, lastSpace).Trim();
        string chapter = splitText[0].Substring(lastSpace + 1).Trim();
        string[] verses = splitText[1].Split('-');
        string startVerse = verses[0].Trim();
        string endVerse = verses.Length > 1 ? verses[1].Trim() : startVerse;

        return new string[] { book, chapter, startVerse, endVerse };

        
    }

}