using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        Journal myJournal = new Journal();

        int response = 0;

        while(response != 5)
        {
            response = myMenu.RunMenu();
            switch (response)
            {
                case 1:
                    Console.WriteLine("Create");
                    myJournal.CreateJournalEntry();
                    break;
                case 2:
                    Console.WriteLine("Display");
                    myJournal.DisplayJournal();
                    break;
                case 3:
                    Console.WriteLine("Read");
                    //call read
                    break;
                case 4:
                    Console.WriteLine("Write");
                    //call write
                    break;
            }
        }
    }
}