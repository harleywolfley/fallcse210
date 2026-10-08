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
        _prompt = "How was your day?"; /* update to list of random prompts */
        Console.Write($"{_prompt}: ");
        _response = Console.ReadLine();
    }
}