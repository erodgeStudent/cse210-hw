using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

public class Program
{     
      
    public static List<string> options = new List<string>(){
        "1. Write",
        "2. Display",
        "3. Load",
        "4. Save",
        "5. Quit"
    };
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");
        
        //display the menu options
        string quit = "no";
        do{
            Console.WriteLine("\nWhat would you like to do?");
            foreach (string option in options)
            {
                Console.WriteLine(option);
            }
            int input = int.Parse(Console.ReadLine());
            
            switch (input)
            {
                case 1:
                //add new entry
                    journal.AddNewEntry();
                    break;

                case 2:
                    //display all the entries in file
                    journal.DisplayJournal();
                    break;

                case 3:
                    //Load Journal
                    journal.LoadJournal();
                    break;
                case 4:
                    //Save Journal
                    journal.SaveJournal();
                    break;
                case 5:
                    journal.QuitJournal();
                    break;
                default:
                    quit = "no";
                    break;


            }
        
        } while (quit == "no");

    }

    
}
