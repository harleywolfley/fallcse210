using System.Runtime.CompilerServices;

class Word
{
    private string _word;
    private bool _hidden;
    

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public string GetWordString()
    {
        string returnstring = "";
        if(_hidden)
        {
            foreach(char c in _word)
            {
                returnstring += '_';
            }
        }
        else
        {
            returnstring = _word;
        }
        return returnstring;
    }

    public void Display()
    {
        Console.Write($"{GetWordString()} ");
    }
}