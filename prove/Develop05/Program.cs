using System;
using System.Security.Cryptography.X509Certificates;

class Program
{  
    
    static void Main(string[] args)
    {
        List<Goal> _goals = new List<Goal>();
        Console.WriteLine("Welcome to Eternal Quest!\n");
        var running = "yes";
        do {
            Goal goal = new Goal("","",0);
            var tPoints = goal.GetTotalPoints();
            Console.WriteLine($"You have {tPoints} points.");
            

            Menu menu = new Menu();
            menu.DisplayMenu();
            int response = menu.GetResponse();
            switch (response){
                case 1:
                    menu.DisplayGoalMenu();
                    int goalResponse = menu.GetResponse();
                    switch (goalResponse)
                    {
                        case 1:
                            SimpleGoal simple = menu.CreateSimple();
                            _goals.Add(simple);
                            break;
                        case 2:
                            EternalGoal eternalGoal = menu.CreateEternal();
                            _goals.Add(eternalGoal);
                            break;
                        case 3:
                            ChecklistGoal checklistGoal = menu.CreateChecklist();
                            _goals.Add(checklistGoal);
                            break;
                        default:
                            Console.WriteLine("Enter an option from the list.");
                            break;
                    }
                    break;
                case 2:
                    goal.DisplayAll(_goals);
                    break;
                case 3:
                    Console.WriteLine("Save File As: ");
                    var filename = Console.ReadLine();
                    List<string> saveList = new List<string>();
                    foreach (Goal g in _goals){
                        var saveString = g.GetStringRepresentation();
                        saveList.Add(saveString);
                    }
                    goal.Save(filename, saveList);
                    
                    break;
                case 4:
                    //load
                    
                    goal.Load(_goals);
                    break;
                case 5:
                    menu.DisplayRecordGoalMenu(_goals);
                    int index = menu.RecordResponse();
                    Goal recordIt = goal.GetGoalByIndex(index, _goals);
                    int totalP = recordIt.RecordEvent();
                    goal.SetTotalPoints(totalP);
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