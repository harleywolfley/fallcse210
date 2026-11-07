using System;

class Program
{
    static void Main(string[] args)
    {

        Circle myCircle = new Circle();

        myCircle._radius = 10;
        double area = myCircle.GetArea();

        Console.WriteLine(area);
    }
}



    // static double AddNumbers(double x, int y)
    // {
    //     return x + y;
    // }

    // static string MyName()
    // {
    //     return "Bob";
    // }

    // static void DisplayGreetin(string name)
    // {
    //     Console.WriteLine($"Welcome, {name}. Nice to meet you.");
    // }


        // string name = MyName();
        // DisplayGreetin(name);
        // double total = AddNumbers(14.39023, 12);
        // Console.WriteLine(total);

        // Console.WriteLine("Hola Sandbox!");
        // Console.WriteLine("Hello Sandbox!");

        // bool done = false;

        // while (! done)
        // {
        //     Console.WriteLine("Are we done yet? (y/n)");
        //     done = Console.ReadLine() == "y";
        // }

        // bool done;

        // do
        // {
        //     Console.WriteLine("Are we done yet? (y/n)");
        //     done = Console.ReadLine() == "y";
        // } while (! done);

        // for(int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // };

        // for(int i = 0; i < 100; i+=5)
        // {
        //     Console.Write($"{i} ");
        // };

        // for(int i=100000; i > -10001; i-=1000)
        // {
        //     Console.Write($"{i} ");
        // }

        // List<string> myFriends = new List<string> {"Sarah", "Chase"};

        // myFriends.Add("Ridley");

        // foreach(string friend in myFriends)
        // {
        //     Console.WriteLine(friend);
        // }