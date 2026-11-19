using System;

class Program
{
    static void Main(string[] args)
    {
        // BaseGoal myGoal = new BaseGoal("BaseGoal");
        //Console.WriteLine(myGoal.GetConsoleString());

        SimpleGoal mySimple = new SimpleGoal();
        Console.WriteLine(mySimple.GetConsoleString());
        mySimple.MarkComplete();
        Console.WriteLine(mySimple.GetConsoleString());
    }
}
