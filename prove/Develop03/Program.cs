using System;

class Program
{
    static void Main(string[] args)
    {

        Scripture myScripture = new Scripture("Moses", 2, 5, "Behold this is my work and my glory.");
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