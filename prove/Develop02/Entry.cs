using System;

class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine($"{_response}");
    }

    public void CreateEntry()
    {
        _date = DateTime.Now.ToString();
        _prompt =  RandomPrompt.SelectPrompt();
        Console.Write($"{_prompt}: ");
        _response = Console.ReadLine();
    }
}