class Scripture
{
    private List<Word> _words;

    // TODO - Add Scripture Reference

    public Scripture (string bookName, int chapter, int verse, string text) {
        _words = ConvertToWordList(text);

        _words[3].Hide();
    }

    public Scripture (string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        // TODO


    }

    public void ShowScripture ()
    {
        foreach (Word word in _words)
        {
            word.Display();
        }
    }

    /* ConvertToWordList() - take string, split into words, add to list, return list
    */

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