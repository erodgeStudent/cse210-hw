using System;

class Program
{  
    public static int points = 0;
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Eternal Quest!\n");
        var running = "yes";
        do {
            Console.WriteLine($"You have {points} points.\n");
            List<Goal> goals = new List<Goal>();

            Menu menu = new Menu();
            menu.DisplayMenu();
            int response = menu.GetResponse();
            switch (response){
                case 1:
                    //create
                    break;
                case 2:
                    //list
                    break;
                case 3:
                    //save
                    break;
                case 4:
                    //load
                    break;
                case 5:
                    //record event
                    break;
                case 6:
                    //quit
                    Console.Write("Are you sure you want to quit? (y/n)");
                    var quit = Console.ReadLine();
                    if (quit == "yes"){
                        running = "no";
                    }
                    else{
                        return;
                    }
                    
                    break;
                default:
                    break;
            }
        } while (running == "yes");
    }
}