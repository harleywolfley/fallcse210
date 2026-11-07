using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Menu myMenu = new Menu();

        int response = 0;
        while (response < 4)
        {
            response = myMenu.RunMenu();
            switch (response)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.RunActivity();
                    break;
                case 2:
                    // reflection
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.RunListActivity();
                    break;
            }
        }

        

        
    }
}