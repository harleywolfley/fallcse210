using System;
using System.Security.Cryptography;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Random myRandom = new Random();
        int randomNumber = myRandom.Next(1,100);

        int guess = -1;

        while (guess != randomNumber)
        {
            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (randomNumber > guess)
            {
                Console.WriteLine("Higher.");
            }
            else if (randomNumber < guess)
            {
                Console.WriteLine("Lower.");
            }
            else
            {
                Console.WriteLine("That's right!");
            }
        }
    }
}