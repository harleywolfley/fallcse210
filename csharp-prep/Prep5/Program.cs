using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNum = SquareNumber(userNumber);
        int birthYear;
        PromptUserBirthYear(out birthYear);

        DisplayResult(userName, squaredNum, birthYear);

    }

    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }
        
        static int PromptUserNumber()
        {
           Console.Write("What is your favorite number? ");
            int favNum = int.Parse(Console.ReadLine()); 
            return favNum;
        }
        
        static void PromptUserBirthYear(out int birthYear)
        {
            Console.Write("What is your birth year? ");
            birthYear = int.Parse(Console.ReadLine());
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        
        static void DisplayResult(string name, int square, int birthYear)
        {
            Console.WriteLine($"{name}, the square of your number is {square}.");
            Console.WriteLine($"{name}, you will turn {2026-birthYear} years old this year.");
        }
}