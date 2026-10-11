using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        Journal myJournal = new Journal();

        string filename = "myFile.txt";

        int response = 0;

        while(response != 5)
        {
            response = myMenu.RunMenu();
            switch (response)
            {
                case 1:
                    myJournal.CreateJournalEntry();
                    break;
                case 2:
                    myJournal.DisplayJournal();
                    break;
                case 3:
                    Console.Write("Where should these entries be saved to? \n> ");
                    filename = Console.ReadLine();
                    
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split("||");
                        Console.WriteLine(parts[0]);
                        Console.WriteLine(parts[1]);
                    }
                    break;
                case 4:
                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        outputFile.WriteLine($"{myJournal}");
                    }
                    break;
            }
        }
    }
}