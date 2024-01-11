using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();

        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int squared = SquareNumber(userNum);

        DisplayResult(userName, squared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        return num;
    }

    static int SquareNumber(int userNum)
    {
        int sq = userNum * userNum;
        return sq;
    }

    static void DisplayResult(string userName, double squared)
    {
        Console.WriteLine($"{userName}, the square of your number is {squared}.");
    }
}