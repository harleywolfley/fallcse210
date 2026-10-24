class ScriptureReference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _startVerse;
    private int _endVerse;
    private bool _isSingleDisplay;

    public ScriptureReference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _isSingleDisplay = true;

    }
    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _isSingleDisplay = false;
    }

    public void DisplayReference()
    {
        if (_isSingleDisplay == true)
        {
            Console.WriteLine($"{_book} {_chapter}:{_verse}");
        }
        else {
            Console.WriteLine($"{_book} {_chapter}:{_startVerse}-{_endVerse}");
        }
    }
}