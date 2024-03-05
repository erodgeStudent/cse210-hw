using System;
using System.Security.Cryptography.X509Certificates;

class Program
{  
    static void Main(string[] args)
    {
        Utils u = new Utils();
        Goal goal = new Goal("","",0);
        List<Goal> goals = new List<Goal>();
        
        Console.WriteLine("Welcome to Eternal Quest!\n");
        var running = "yes";
        do {
            var totalPoints = goal.GetTotalPoints();
            Console.WriteLine($"You have {totalPoints} points.");
            

            Menu menu = new Menu();
            menu.DisplayMenu();
            int response = menu.GetResponse();
            switch (response){
                case 1:
                    //create
                    menu.DisplayGoalMenu();
                    int goalResponse = menu.GetResponse();
                    switch (goalResponse)
                    {
                        case 1:
                            SimpleGoal simple = menu.CreateSimple();
                            goals.Add(simple);
                            break;
                        case 2:
                            EternalGoal eternalGoal = menu.CreateEternal();
                            goals.Add(eternalGoal);
                            break;
                        case 3:
                            ChecklistGoal checklistGoal = menu.CreateChecklist();
                            goals.Add(checklistGoal);
                            break;
                    }
                    break;
                case 2:
                    goal.DisplayAll(goals);
                    break;
                case 3:
                    Console.WriteLine("Inside Save");
                    Console.WriteLine("Save File As: ");
                    var filename = Console.ReadLine();
                    List<string> saveList = new List<string>();
                    foreach (Goal g in goals){
                    var saveString = goal.GetStringRepresentation(g);
                    saveList.Add(saveString);
                    }
                    goal.Save(filename, saveList);
                    break;
                case 4:
                    //load
                    goal.Load();
                    break;
                case 5:
                    menu.DisplayRecordGoalMenu(goals);
                    break;
                case 6:
                    //quit
                    Console.Write("Are you sure you want to quit? (y/n) ");
                    var quit = Console.ReadLine();
                    if (quit == "y"){
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