class Menu
{
    public int RunMenu()
    {
        int input = 0;
        while (input < 1 || input > 5)
        {
            Console.WriteLine("Welcome to the Journal Program.");
            Console.WriteLine("Create, Display, Save, or Read Journal Entries.");
            Console.WriteLine("1. Create Journal Entry");
            Console.WriteLine("2. Display all Journal Entries");
            Console.WriteLine("3. Save Journal to a file");
            Console.WriteLine("4. Read Journal from a File");
            Console.WriteLine("5. Quit");
            Console.Write("> ");
            input = int.Parse(Console.ReadLine());
        }
        
        return input;
    }
}