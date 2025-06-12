class Word
{
    private string _text;

    private bool _ishidden;

    public Word(string text)
    {
        _text = text;
        _ishidden = false;
    }
    public string GetText()
    {
        if (!_ishidden)
        {
            return _text;
        }
        else
        {
            return new string('_', _text.Length);
        }
    }

    public bool IsHidden()
    {
        return _ishidden;
    }
    public void Hide()
    {
        _ishidden = true;
    }
}