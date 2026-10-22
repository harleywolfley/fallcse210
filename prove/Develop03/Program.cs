using System;

class Program
{
    static void Main(string[] args)
    {
        // Word myWord = new Word("Secret");

        // myWord.Display();
        // myWord.Hide();
        // myWord.Display();

        Scripture myScripture = new Scripture("Moses", 2, 5, "Behold this is my work and my glory.");
        myScripture.ShowScripture();
    }
}