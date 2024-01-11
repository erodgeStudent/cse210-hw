using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        
        int magicNum;
        int guessNum;
        string result = "no";
        string userResponse = "yes";

        do {
            int count = 0;
            Console.Write("\nGuess the magic number.");
            Random randomGenerator = new Random();
            magicNum = randomGenerator.Next(1,100);

            do
            {
                Console.Write("\nWhat is your guess? ");
                string guessInput = Console.ReadLine();
                guessNum = int.Parse(guessInput);
                count ++;
            
                if (guessNum == magicNum)
                {
                    Console.WriteLine("You guessed it!");
                    result = "yes";
                }
                else if (guessNum < magicNum)
                {
                    Console.WriteLine("Higher");
                    result = "no";
                }
                else if ( guessNum > magicNum)
                {
                    Console.WriteLine("Lower");
                    result = "no";
                }
            } while (result == "no");
            Console.WriteLine($"You guessed {count} times.");
            Console.WriteLine("Would you like to play again? yes/no ");
            userResponse = Console.ReadLine();
        } while (userResponse == "yes");
    }
}