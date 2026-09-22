using System;

class Program
{
    static void Main(string[] args)
    {
        int numGrade;
        Console.Write("Enter your grade percentage: ");
        numGrade = int.Parse(Console.ReadLine());
        if (numGrade >= 90) 
        {
        Console.Write("Your grade is an A.");
        } else if (numGrade >= 80)
        {
            Console.Write("Your grade is a B.");
        } else if (numGrade >= 70)
        {
            Console.Write("Your grade is a C.");
        } else if (numGrade >= 60)
        {
            Console.Write("Your grade is a D.");
        } else if (numGrade < 59.9999)
        {
            Console.Write("You failed.");
        } else
        {
            Console.Write("Please enter a valid percentage when you try again.");
        }
    }
}