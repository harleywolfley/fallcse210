class Scripture
{
    private List<Word> _words;

    public Scripture (string bookName, int chapter, int verse, string text) {
        ScriptureReference myReference = new ScriptureReference(bookName, chapter, verse);
        myReference.DisplayReference();
        
        _words = ConvertToWordList(text);

        HideRandomWord();
    }

    public Scripture (string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        ScriptureReference myReference = new ScriptureReference(bookName, chapter, startVerse, endVerse);
        myReference.DisplayReference();
        
        _words = ConvertToWordList(text);

        HideRandomWord();
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(_words.Count);
        while (_words[index].IsHidden())
        {
            index = random.Next(_words.Count);
        }

        _words[index].Hide();
    }

    public bool IsCompletelyHidden()
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

    public void ShowScripture ()
    {
        foreach (Word word in _words)
        {
            word.Display();
        }
    }

    private List<Word> ConvertToWordList(string text)
    {
        List<Word> tempwordlist = new List<Word>();
        string[] tempWords = text.Split(" ");
        foreach (string w in tempWords)
        {
            Word tempWord = new Word(w);
            tempwordlist.Add(tempWord);
        }

        return tempwordlist;
    }
}