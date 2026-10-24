using System;

class Program
{
    static void Main(string[] args)
    {

        Scripture myScripture = new Scripture("Proverbs", 3, 5, 6, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        myScripture.ShowScripture();
        Console.WriteLine();

        while (!myScripture.IsCompletelyHidden())
        {
            Console.WriteLine("When ready, press enter to hide words or type 'quit' and press enter: ");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }
            else 
            {
                Console.Clear();
                myScripture.HideRandomWord();
                myScripture.ShowScripture();
                Console.WriteLine();
            }
        }
    }
}