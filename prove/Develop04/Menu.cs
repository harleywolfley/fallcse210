using System.Security.Cryptography;

class Menu
{
    private int _userinput;

    public int RunMenu()
    {
        Console.WriteLine("Mindfulness Menu");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Your selection: ");
        _userinput = int.Parse(Console.ReadLine());
        
        return _userinput;
    }
}